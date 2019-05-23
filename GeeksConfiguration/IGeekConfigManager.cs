using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace GeeksConfiguration
{
    public interface IGeekConfigManager 
    {
        string NorthwindConnection { get; }

        string EmailID { get; }

        string AccountKey { get; }

        string GetConnectionString(string connectionName);

        IConfigurationSection GetConfigurationSection(string Key);
    }
}
