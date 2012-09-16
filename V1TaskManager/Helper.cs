using System.Diagnostics;
using Microsoft.Win32;
using VersionOne.SDK.ObjectModel;

namespace V1TaskManager
{
    public class Helper
    {
        public static void OpenDetailPage(string id)
        {
            Process.Start(GetDefaultBrowserPath(), Global.Instance.Get.GetByID<BaseAsset>(id).URL);
        }

        public static string GetDefaultBrowserPath()
        {
            return
                ((string) Registry.ClassesRoot.OpenSubKey(@"htmlfile\shell\open\command", false).GetValue(null, null)).
                    Split('"')[1];
        }
    }
}