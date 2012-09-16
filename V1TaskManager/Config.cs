using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace V1TaskManager
{
	public class Config
	{
		private static readonly string ConfigFilePath = "config.xml";

		public string ApplicationPath
		{
			get { return Read<string>("ApplicationPath"); }
			set { Set("ApplicationPath", value); }
		}

        public bool UseWindowsIntegrated
        {
            get { return Convert.ToBoolean(Read<string>("UseWindowsIntegrated")); }
            set { Set("UseWindowsIntegrated", value); }
        }

		public string Username
		{
			get { return Read<string>("Username"); }
			set { Set("Username", value); }
		}

		public string Password
		{
			get { return Read<string>("Password"); }
			set { Set("Password", value); }
		}

		private IList<String> _recentMessages;
		public IList<String> RecentMessages
		{
			get
			{
				if (_recentMessages == null)
					_recentMessages = ReadStringCollection("RecentMessages");
				return _recentMessages;
			}
		}

		private IList<String> _recentItems;
		public IList<String> RecentItems
		{
			get
			{
				if (_recentItems == null)
					_recentItems = ReadStringCollection("RecentItems");
				return _recentItems;
			}
		}

		private IList<String> _recentSearches;
		public IList<String> RecentSearches
		{
			get
			{
				if (_recentSearches == null)
					_recentSearches = ReadStringCollection("RecentSearches");
				return _recentSearches;
			}
		}

		public bool IsValid
		{
			get
			{
				return ApplicationPath != null && Username != null && Password != null;
			}
		}

		public event EventHandler OnChanged;

		public static void UpdateRecentList(IList<string> messages, string content, int maxitems)
		{
			if (messages.Contains(content))
				messages.Remove(content);

			messages.Insert(0, content);
			while (messages.Count > maxitems)
				messages.RemoveAt(messages.Count - 1);
		}

		#region Config Reading
		private XmlDocument _doc;
		private XmlDocument Doc
		{
			get
			{
				if (_doc == null)
				{
					_doc = new XmlDocument();
					if (File.Exists(ConfigFilePath))
						_doc.Load(ConfigFilePath);
					if (_doc.DocumentElement == null)
						_doc.AppendChild(_doc.CreateElement("Configuration"));
				}
				return _doc;
			}
		}

		private XmlNode EnsureNode(string name)
		{
			XmlNode node = Doc.DocumentElement.SelectSingleNode(name);
			if (node == null)
				node = Doc.DocumentElement.AppendChild(Doc.CreateElement(name));
			return node;
		}

		private T Read<T>(string name)
		{
			return Read(name, default(T));
		}

		private T Read<T>(string name, T def)
		{
			string text = EnsureNode(name).InnerText;
			if (string.IsNullOrEmpty(text))
				return def;
			return (T)Convert.ChangeType(text, typeof (T));
		}

		private void Set<T>(string name, T value)
		{
			Set(name, value, true);
		}

		private void Set<T>(string name, T value, bool announce)
		{
			EnsureNode(name).InnerText = (string)Convert.ChangeType(value, typeof(string));
			Save();
			if (announce && OnChanged != null)
				OnChanged(this, EventArgs.Empty);
		}

		private void Save()
		{
			Doc.Save(ConfigFilePath);
		}

		private IList<string> ReadStringCollection(string name)
		{
			return new XmlStringCollection(EnsureNode(name), this);
		}

		private class XmlStringCollection : IList<string>
		{
			private readonly IList<string> _values = new List<string>();
			private readonly XmlNode _node;
			private readonly Config _config;
			public XmlStringCollection(XmlNode node, Config config)
			{
				_node = node;
				_config = config;
				ParseNode();
			}

			private static XmlAttribute EnsureAttribute(XmlNode node, string name)
			{
				XmlAttribute attrib = node.Attributes[name];
				if (attrib == null)
					attrib = node.Attributes.Append(node.OwnerDocument.CreateAttribute(name));
				return attrib;
			}

			private static XmlNode EnsureElement(XmlNode parent, string name)
			{
				XmlNode node = parent.SelectSingleNode(name);
				if (node == null)
					node = parent.AppendChild(parent.OwnerDocument.CreateElement(name));
				return node;
			}

			private static XmlNode EnsureCData(XmlNode parent)
			{
				if (parent.ChildNodes.Count == 0)
					return parent.AppendChild(parent.OwnerDocument.CreateCDataSection(string.Empty));
				else
					return parent.ChildNodes[0];
			}

			private void ParseNode()
			{
				XmlAttribute attrib = EnsureAttribute(_node, "Count");
				int count = 0;
				string text = attrib.InnerText;
				if (!string.IsNullOrEmpty(text))
					count = int.Parse(text);
				for (int i=0;i<count;i++)
				{
					XmlNode subNode = _node.SelectSingleNode("Node" + i);
					if (subNode != null)
					{
						XmlNode cDataNode = subNode.ChildNodes[0];
						if (cDataNode != null && cDataNode.NodeType == XmlNodeType.CDATA)
							_values.Add(cDataNode.InnerText);
					}
				}
			}

			private void SaveNode()
			{
				_node.RemoveAll();

				EnsureAttribute(_node, "Count").InnerText = _values.Count.ToString();
				for (int i=0;i<_values.Count;i++)
				{
					XmlNode subNode = EnsureElement(_node, "Node" + i);
					XmlNode cDataNode = EnsureCData(subNode);
					cDataNode.InnerText = _values[i];
				}
				_config.Save();
			}

			public void Add(string item)
			{
				_values.Add(item);
				SaveNode();
			}

			public void Clear()
			{
				_values.Clear();
				SaveNode();
			}

			public bool Contains(string item)
			{
				return _values.Contains(item);
			}

			public void CopyTo(string[] array, int arrayIndex)
			{
				_values.CopyTo(array,arrayIndex);
			}

			public bool Remove(string item)
			{
				bool b = _values.Remove(item);
				SaveNode();
				return b;
			}

			public int Count { get { return _values.Count; } }
			public bool IsReadOnly { get { return false; } }

			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return _values.GetEnumerator();
			}

			public IEnumerator GetEnumerator()
			{
				return ((IEnumerable<string>) this).GetEnumerator();
			}

			public int IndexOf(string item)
			{
				return _values.IndexOf(item);
			}

			public void Insert(int index, string item)
			{
				_values.Insert(index, item);
				SaveNode();
			}

			public void RemoveAt(int index)
			{
				_values.RemoveAt(index);
				SaveNode();
			}

			public string this[int index] { get { return _values[index]; } set { _values[index] = value; SaveNode(); } }
		}
		#endregion
	}
}
