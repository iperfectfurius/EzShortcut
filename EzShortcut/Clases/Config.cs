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
        private readonly string folderApplication = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\EzShortcut";
        private const string config = "EZShortcut_config.json";
        public JObject configLoaded = new JObject();

        public Config()
        {
            LoadConfig();

        }
        public void LoadConfig()
        {
            if (!File.Exists($"{folderApplication}\\{config}"))
                CreateConfig();
            try
            {
                configLoaded = JObject.Parse(File.ReadAllText($"{folderApplication}\\{config}"));
            }
            catch
            {
                MessageBox.Show("La configuración no es correcta.");
            }
        }
        private void CreateConfig()
        {
            if (!Directory.Exists(folderApplication))
                Directory.CreateDirectory(folderApplication);

            JObject defaultSettings = new JObject(
                new JProperty("open", new JArray(
                    new JObject(
                        new JProperty("PHP.ini(IIS)", "C:\\Program Files\\iis express\\PHP\\v7.3\\php.ini"),
                        new JProperty("PHP.ini(Apache)", "C:\\PHP\\php.ini")
                    )))
                );
            
            File.WriteAllText($"{folderApplication}\\{config}", defaultSettings.ToString());
        }
    }
}
