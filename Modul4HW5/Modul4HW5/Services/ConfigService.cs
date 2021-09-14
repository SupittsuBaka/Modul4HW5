﻿using System.IO;
using Newtonsoft.Json;

namespace Modul4HW5.Services
{
    public class ConfigService
    {
        private string _path = "config.json";
        private Config _config;

        public ConfigService()
        {
            Init();
        }

        public string ConnectionString => _config.ConnectionString;

        public void Init()
        {
            _config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(_path));
        }
    }
}
