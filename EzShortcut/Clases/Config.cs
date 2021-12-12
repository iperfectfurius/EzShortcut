using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EzShortcut.Clases
{
    internal class Config
    {
        string folderApplication = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\EzShortcut";
        string config = "EZShortcut_config.json";

        public Config()
        {
            LoadConfig();
        }
        public void LoadConfig()
        {
            if (File.Exists($"{folderApplication}\\{config}")) return;
            CreateConfig();

        }
        private void CreateConfig()
        {
            if (!Directory.Exists(folderApplication))
                Directory.CreateDirectory(folderApplication);

            JObject defaultSettings = new JObject(
                new JProperty("open", new JArray(
                    new JObject(
                        new JProperty("PHP.ini(IIS)", "C:\\Program Files\\iis express\\PHP\\v7.3\\php.ini"),
                        new JProperty("PHP.ini(Apache)", "")
                    )))
                );

            File.WriteAllText($"{folderApplication}\\{config}", defaultSettings.ToString());
        }
    }
}
