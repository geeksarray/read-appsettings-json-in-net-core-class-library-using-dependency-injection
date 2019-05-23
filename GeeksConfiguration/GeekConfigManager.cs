using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace GeeksConfiguration
{
    public class GeekConfigManager : IGeekConfigManager
    {
        private readonly IConfiguration _configuration;
        public GeekConfigManager(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string NorthwindConnection
        {
            get
            {    
                return this._configuration["ConnectionStrings:NorthwindDatabase"]; 
            }
        }

        public string GetConnectionString(string connectionName)
        {
            return this._configuration.GetConnectionString(connectionName);
        }

        public string EmailID
        {
            get
            {
                return this._configuration["AppSeettings:EmailID"];
            }
        }

        public string AccountKey
        {
            get
            {
                return this._configuration["AppSeettings:AccountKey"];
            }
        }

        public IConfigurationSection GetConfigurationSection(string key)
        {
           return this._configuration.GetSection(key);
        }
    }
}
