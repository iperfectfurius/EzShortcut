﻿using System;
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
        private readonly string pathConfig;
        public JObject configLoaded = new();

        public Config()
        {
            pathConfig = $"{folderApplication}\\{config}";
            LoadConfig();
        }
        public void LoadConfig()
        {
            if (!File.Exists(pathConfig))
                CreateConfig();
            try
            {
                configLoaded = JObject.Parse(File.ReadAllText(pathConfig));
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
                    ))),
                new JProperty("scripts",new JArray(
                    new JObject(
                        new JProperty("Mysql","mysql -u root -p")
                    )))
                );
            
            
            File.WriteAllText(pathConfig, defaultSettings.ToString());
        }
        public void openConfig()
        {
            OpenShortcut.OpenFile(pathConfig);
        }
    }
}
