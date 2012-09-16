using System;
using VersionOne.SDK.ObjectModel;

namespace V1TaskManager
{
	public static class Global
	{
		static Global()
		{
			Config.OnChanged += Configuration_OnChanged;
		}

		private static Config _config;
		public static Config Config
		{
			get
			{
				if (_config == null)
					_config = new Config();
				return _config;
			}
		}

		private static V1Instance _instance;
		public static V1Instance Instance
		{
			get
			{
				if (_instance == null)
					_instance = new V1Instance(Config.ApplicationPath ?? string.Empty, Config.Username ?? string.Empty, Config.Password ?? string.Empty, Config.UseWindowsIntegrated);
				return _instance;
			}
		}

		public static bool IsValid
		{
			get
			{
				try
				{
					Instance.Validate();
					return true;
				}
				catch
				{
					return false;
				}
			}
		}

		static void Configuration_OnChanged(object sender, EventArgs e)
		{
			_instance = null;
		}
	}
}
