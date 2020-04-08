using MentorOnDemand.BusinessLayer.Interfaces;
using MentorOnDemand.BusinessLayer.Repositories;
using MentorOnDemand.BusinessLayer.Services;
using Microsoft.Data.Sqlite;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MentorOnDemand.Tests.TestCases
{
    public class DatabaseConnectionTest
    {
        private IUserServices _userServices;
        private IMentorServices _mentorServices;
        string _dbLocation = "./personalFitnessTracker.db";

        public readonly Mock<IUserRepository> userService = new Mock<IUserRepository>();
        public readonly Mock<IMentorRepository> mentorServices = new Mock<IMentorRepository>();

        public DatabaseConnectionTest()
        {
            _userServices = new UserServices(userService.Object);
            _mentorServices = new MentorServices(mentorServices.Object);
        }
       
        public async Task<IDbConnection> CreateConnectionAsync()
        {
            var connection = new SqliteConnection($"Data Source={_dbLocation}");
            await connection.OpenAsync();
            return connection;
        }

        [Fact]
        public void Test_For_DatabaseConnection()
        {
            var connection = CreateConnectionAsync();
            Assert.NotNull(connection);
        }
    }
}
