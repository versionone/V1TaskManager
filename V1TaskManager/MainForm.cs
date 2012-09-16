using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VersionOne.SDK.ObjectModel;
using VersionOne.SDK.ObjectModel.Filters;

namespace V1TaskManager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			RefreshStuff();
		}

		private static void Clear(ToolStripItemCollection items)
		{
			while (items.Count > 2)
				items.RemoveAt(items.Count - 1);
		}

		private static List<Iteration> GetActiveIterations()
		{
			IterationFilter filter = new IterationFilter();
			filter.State.Add(IterationState.Active);
			return new List<Iteration>(Global.Instance.Get.Iterations(filter));
		}

		private void menuExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void menuConfig_Click(object sender, EventArgs e)
		{
			if (new ConfigForm().ShowDialog(this) == DialogResult.OK)
				RefreshStuff();
		}

		private void menuMyStuffRefresh_Click(object sender, EventArgs e)
		{
			RefreshStuff();
		}

		private void menuOtherStuffRefresh_Click(object sender, EventArgs e)
		{
			RefreshStuff();
		}

		private void RefreshStuff()
		{
			Clear(menuOtherStuff.DropDownItems);
			Clear(menuMyStuff.DropDownItems);
			if (Global.Config.IsValid && Global.IsValid)
			{
				PrimaryWorkitemFilter filter = new PrimaryWorkitemFilter();
				GetActiveIterations().ForEach(delegate(Iteration iteration) { filter.Iteration.Add(iteration); });
				filter.State.Add(State.Active);
				filter.OrderBy.Add("RankOrder");
				foreach (PrimaryWorkitem pw in Global.Instance.Get.PrimaryWorkitems(filter))
				{
					ToolStripMenuItem myItem = null;
					ToolStripMenuItem otherItem = null;

					if (pw.Owners.Contains(Global.Instance.LoggedInMember))
					{
						myItem = CreateMenuItem(pw);
						menuMyStuff.DropDownItems.Add(myItem);
					}
					else
					{
						otherItem = CreateMenuItem(pw);
						menuOtherStuff.DropDownItems.Add(otherItem);
					}

					TaskFilter taskFilter = new TaskFilter();
					taskFilter.Parent.Add(pw);
					taskFilter.OrderBy.Add("RankOrder");
					foreach (Task task in Global.Instance.Get.Tasks(taskFilter))
						RefreshSubItem(pw, task, ref myItem, ref otherItem);

					TestFilter testFilter = new TestFilter();
					testFilter.Parent.Add(pw);
					testFilter.OrderBy.Add("RankOrder");
					foreach (Test test in Global.Instance.Get.Tests(testFilter))
						RefreshSubItem(pw, test, ref myItem, ref otherItem);
				}
			}
		}

		private void RefreshSubItem(Workitem parent, Workitem child, ref ToolStripMenuItem myItem, ref ToolStripMenuItem otherItem)
		{
			ToolStripItem childItem = CreateMenuItem(child);

			bool isChildOwned = child.Owners.Contains(Global.Instance.LoggedInMember);
			if (isChildOwned)
			{
				if (myItem == null)
				{
					myItem = CreateMenuItem(parent);
					menuMyStuff.DropDownItems.Add(myItem);
				}
				myItem.DropDownItems.Add(childItem);
			}
			else
			{
				if (otherItem == null)
				{
					otherItem = CreateMenuItem(parent);
					menuOtherStuff.DropDownItems.Add(otherItem);
				}
				otherItem.DropDownItems.Add(childItem);
			}			
		}

		private ToolStripMenuItem CreateMenuItem(Workitem pw)
		{
			ToolStripMenuItem pwMenuItem = new ToolStripMenuItem(pw.Name, GetEntityIcon(pw));
			pwMenuItem.Tag = pw.ID;

			if (!pw.Owners.Contains(Global.Instance.LoggedInMember))
				AddTakeOption(pwMenuItem.DropDownItems, pw);

			AddCloseOption(pwMenuItem.DropDownItems, pw);
			AddUpdateOption(pwMenuItem.DropDownItems, pw);
			AddDetailsOption(pwMenuItem.DropDownItems, pw);

			return pwMenuItem;
		}

		private Image GetEntityIcon(Workitem item)
		{
			return iconList.Images[item.GetType().Name];
		}

		private void AddTakeOption(ToolStripItemCollection items, Workitem item)
		{
			CreateButton(items, "Take", Take_Click, item);
		}

		private void AddCloseOption(ToolStripItemCollection items, Workitem item)
		{
			CreateButton(items, "Close", Close_Click, item);
		}

		private void AddUpdateOption(ToolStripItemCollection items, Workitem item)
		{
			CreateButton(items, "Update", Update_Click, item);
		}

		private static void AddDetailsOption(ToolStripItemCollection items, Workitem item)
		{
			CreateButton(items, "Details", Details_Click, item);
		}

		private static void CreateButton(ToolStripItemCollection items, string title, EventHandler handler, Workitem item)
		{
			ToolStripMenuItem button = new ToolStripMenuItem(title, null, handler);
			items.Add(button);
			button.Tag = item;
		}

		private void Take_Click(object sender, EventArgs e)
		{
			Workitem item = (Workitem) ((ToolStripItem) sender).Tag;
			if (!item.Owners.Contains(Global.Instance.LoggedInMember))
			{
				item.Owners.Add(Global.Instance.LoggedInMember);
				RefreshStuff();
			}
		}

		private void Close_Click(object sender, EventArgs e)
		{
			Workitem item = (Workitem)((ToolStripItem)sender).Tag;
			if (!item.IsClosed)
			{
				item.Close();
				RefreshStuff();
			}
		}

		private void Update_Click(object sender, EventArgs e)
		{
			Workitem item = (Workitem)((ToolStripItem)sender).Tag;
			if (new UpdateForm(item).ShowDialog(this) == DialogResult.OK)
				RefreshStuff();
		}

		private static void Details_Click(object sender, EventArgs e)
		{
			Helper.OpenDetailPage(((Workitem) ((ToolStripItem) sender).Tag).ID);
		}
	}
}