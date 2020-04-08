using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MentorOnDemand.DataLayer
{
 public   class SqLiteConnectionFactory : IDbConnectionFactory
    {
        private readonly string _dbLocation;

        public SqLiteConnectionFactory(string dbLocation)
        {
            _dbLocation = dbLocation;
        }


        public async Task<IDbConnection> CreateConnectionAsync()
        {
            var connection = new SqliteConnection($"Data Source={_dbLocation}");
            await connection.OpenAsync();
            return connection;
        }

        public async Task SetupAsync()
        {
         if (!File.Exists(_dbLocation))
        {
            File.Create(_dbLocation).Close();
                var connection = await CreateConnectionAsync();
          //  await connection.ExecuteAsync("Drop table User");

                await connection.ExecuteAsync("CREATE TABLE User (Id NUMBER PRIMARY KEY NOT NULL, UserName TEXT NULL,Password TEXT NULL, FirstName TEXT NULL,LastName TEXT NULL,ContactNumber Number NULL,Role TEXT NULL ,LinkedinURL TEXT NULL,Experience NUMBER NULL,Active BIT NULL,ConfirmedSignUp BIT NULL,ResetPassword BIT NULL,ResetPasswordDate DATE NULL);");
       }
        }

    }
}
