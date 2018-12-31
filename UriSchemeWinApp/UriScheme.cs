using Microsoft.Win32;
using System.Windows.Forms;

namespace UriSchemeWinApp {
    public class UriScheme {

        public static void Register(string uriSchemeName) {
            using (var key = Registry.CurrentUser.CreateSubKey(string.Format(@"SOFTWARE\Classes\{0}", uriSchemeName))) {
                key.SetValue("", string.Format("URL:{0} Protocol", uriSchemeName));
                key.SetValue("URL Protocol", "");

                using (var defaultIcon = key.CreateSubKey("DefaultIcon")) {
                    defaultIcon.SetValue("", string.Format("{0},1", Application.ExecutablePath));
                }

                using (var commandKey = key.CreateSubKey(@"shell\open\command")) {
                    commandKey.SetValue("", string.Format("\"{0}\" \"%1\"", Application.ExecutablePath));
                }
            }
        }
    }
}
