using MentorOnDemand.BusinessLayer.Interfaces;
using MentorOnDemand.BusinessLayer.Repositories;
using MentorOnDemand.BusinessLayer.Services;
using MentorOnDemand.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MentorOnDemand.Tests.TestCases
{
  public  class BusinessLogicTest
    {
        private IUserServices _userServices;
        private IMentorServices _mentorServices;

        public readonly Mock<IUserRepository> userService = new Mock<IUserRepository>();
        public readonly Mock<IMentorRepository> mentorService = new Mock<IMentorRepository>();

        public BusinessLogicTest()
        {
            _userServices = new UserServices(userService.Object);
            _mentorServices = new MentorServices(mentorService.Object);
        }
        Random random = new Random();

        [Fact]
        public void Test_for_AssignRating()
        {
            MentorDetails mentor = new MentorDetails()
            {
                Rating = 5
            };
            userService.Setup(repos => repos.AssignRating(mentor.Rating));
            var IsAdded = _userServices.AssignRating(mentor.Rating);
            Assert.True(IsAdded);
        }


        [Fact]
        public async Task Test_for_RoleFordMentorAsync()
        {
            MentorDetails mentor = new MentorDetails()
            {
                Id=134,
                UserName="Abc@gmail.com",
                Rating = 5,
                Role= "Admin"
            };
            mentorService.Setup(repos => repos.ViewMentor(mentor.Id));
            var existmentor =await _mentorServices.ViewMentor(mentor.Id);
            Assert.Equal("Mentor", existmentor.Role);
        }
        [Fact]
        public async Task Test_for_RoleForUserAsync()
        {
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "abc@gmail.com",
                Password = "1234",
            };
            userService.Setup(repos => repos.GetUser(user.Id));
            var ExistUser = await _userServices.GetUser(user.Id);
            Assert.Equal("User",ExistUser.Role);
        }
        
    }
}
