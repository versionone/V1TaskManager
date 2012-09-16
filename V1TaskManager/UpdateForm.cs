using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VersionOne.SDK.ObjectModel;

namespace V1TaskManager
{
	public partial class UpdateForm : Form
	{
		private readonly Workitem _workitem;

		public UpdateForm(Workitem workitem)
		{
			_workitem = workitem;

			InitializeComponent();

			txtToDo.Text = _workitem.ToDo == null ? string.Empty : ((double)_workitem.ToDo).ToString("0.00");

			if (_workitem is Story)
				FillStatusList(((Story) _workitem).Status);
			else if (_workitem is Defect)
				FillStatusList(((Defect)_workitem).Status);
			else if (_workitem is Task)
				FillStatusList(((Task)_workitem).Status);
			else if (_workitem is Test)
				FillStatusList(((Test)_workitem).Status);

			if (!_workitem.CanTrack)
			{
				todoPanel.Enabled = false;
				effortPanel.Enabled = false;
			}
			if (!Global.Instance.Configuration.EffortTrackingEnabled)
				effortPanel.Enabled = false;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			Text += " - " + _workitem.Name;
		}

		private void FillStatusList(IListValueProperty prop)
		{
			if (prop.IsValid(null))
				comboStatus.Items.Add(string.Empty);
			foreach (string name in prop.AllValues)
			{
				comboStatus.Items.Add(name);
				if (prop.CurrentValue == name)
					comboStatus.SelectedItem = name;
			}
		}

		private void UpdateStatusValue(IListValueProperty prop)
		{
			string newvalue = (string) comboStatus.SelectedItem;
			if (newvalue == string.Empty)
				newvalue = null;
			if (prop.IsValid(newvalue))
				prop.CurrentValue = newvalue;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			ExecuteUpdate();

			Close();
		}

		private void ExecuteUpdate()
		{
			bool bSave = false;

			if (todoPanel.Enabled)
			{
				double? res = null;
				double todo;
				if (double.TryParse(txtToDo.Text, out todo))
					res = todo;
				_workitem.ToDo = res;
				bSave = true;
			}

			if (statusPanel.Enabled)
			{
				if (_workitem is Story)
					UpdateStatusValue(((Story)_workitem).Status);
				else if (_workitem is Defect)
					UpdateStatusValue(((Defect)_workitem).Status);
				else if (_workitem is Task)
					UpdateStatusValue(((Task)_workitem).Status);
				else if (_workitem is Test)
					UpdateStatusValue(((Test)_workitem).Status);
				bSave = true;
			}

			if (effortPanel.Enabled)
			{
				double value;
				if (double.TryParse(txtEffort.Text, out value))
					_workitem.CreateEffort(value);
			}

			if (bSave)
				_workitem.Save();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			ExecuteUpdate();
			if (_workitem.CanClose)
				_workitem.Close();
			Close();
		}
	}
}