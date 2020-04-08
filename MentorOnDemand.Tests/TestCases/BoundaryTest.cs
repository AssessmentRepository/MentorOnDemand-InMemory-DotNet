using MentorOnDemand.BusinessLayer.Interfaces;
using MentorOnDemand.BusinessLayer.Repositories;
using MentorOnDemand.BusinessLayer.Services;
using MentorOnDemand.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace MentorOnDemand.Tests.TestCases
{
    public class BoundaryTest
    {
        private IUserServices _userServices;
        private IMentorServices _mentorServices;
        

        public readonly Mock<BusinessLayer.Repositories.IUserRepository> service = new Mock<IUserRepository>();
        public readonly Mock<IMentorRepository> services = new Mock<IMentorRepository>();

        public BoundaryTest()
        {
            _userServices = new UserServices(service.Object);
            _mentorServices = new MentorServices(services.Object);

        }

        Random random = new Random();

        [Fact]
        public void BoundaryTest_ForValidUserIdLength()
        {
            //Action
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "abc@gmail.com",
                Password = "1234",
            };
            //Assert
            Assert.InRange(user.Id, 35, 300000);

        }

        [Fact]
        public void BoundaryTest_ForValidUserPasswordLength()
        {
            //Action
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "abc@gmail.com",
                Password = "1234",
            };
            //Assert
            Assert.InRange(user.Password.Length, 4, 20);
        }

        [Fact]
        public void BoundaryTest_ForMentorPasswordLength()
        {
            MentorDetails Mentor = new MentorDetails();
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = Mentor.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


        [Fact]
        public void BoundaryTest_ForValidUsernam()
        {
            //Action
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "abc@gmail.com",
                Password = "1234",
            };

            bool isEmail = Regex.IsMatch(user.UserName, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public void BoundaryTest_ForMentorContactNumber_Length()
        {
            MentorDetails Mentor = new MentorDetails();
            var MinLength = 10;
            var MaxLength = 10;
            

            //Action
            var actualLength = Mentor.ContactNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserContactNumber_Length()
        {
            User User = new User();
            var MinLength = 10;
            var MaxLength = 10;


            //Action
            var actualLength = User.ContactNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

    }
}
