﻿using System;
using System.IO;
using System.Runtime.Serialization;
using Arrowgene.Ddon.Database.Model;
using Arrowgene.Ddon.Shared;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Database
{
    [DataContract]
    public class DatabaseSetting
    {
        public DatabaseSetting()
        {
            Type = DatabaseType.SQLite;
            SqLiteFolder = Path.Combine(Util.ExecutingDirectory(), "Files/Database");
            Host = "localhost";
            Port = 3306;
            Database = "Ddon";
            User = string.Empty;
            Password = string.Empty;
            WipeOnStartup = true;

            string envDbType = Environment.GetEnvironmentVariable("DB_TYPE");
            switch (envDbType)
            {
                case "sqlite":
                    Type = DatabaseType.SQLite;
                    break;
            }

            string envDbUser = Environment.GetEnvironmentVariable("DB_USER");
            if (!string.IsNullOrEmpty(envDbUser))
            {
                User = envDbUser;
            }

            string envDbPass = Environment.GetEnvironmentVariable("DB_PASS");
            if (!string.IsNullOrEmpty(envDbPass))
            {
                Password = envDbPass;
            }
        }

        public DatabaseSetting(DatabaseSetting databaseSettings)
        {
            Type = databaseSettings.Type;
            SqLiteFolder = databaseSettings.SqLiteFolder;
            Host = databaseSettings.Host;
            Port = databaseSettings.Port;
            User = databaseSettings.User;
            Password = databaseSettings.Password;
            Database = databaseSettings.Database;
            WipeOnStartup = databaseSettings.WipeOnStartup;
        }

        [DataMember(Order = 0)] public DatabaseType Type { get; set; }

        [DataMember(Order = 1)] public string SqLiteFolder { get; set; }

        [DataMember(Order = 2)] public string Host { get; set; }

        [DataMember(Order = 3)] public short Port { get; set; }

        [DataMember(Order = 4)] public string User { get; set; }

        [DataMember(Order = 5)] public string Password { get; set; }

        [DataMember(Order = 6)] public string Database { get; set; }

        [DataMember(Order = 6)] public bool WipeOnStartup { get; set; }
    }
}
