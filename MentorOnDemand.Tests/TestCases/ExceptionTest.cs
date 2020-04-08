using MentorOnDemand.BusinessLayer.Interfaces;
using MentorOnDemand.BusinessLayer.Repositories;
using MentorOnDemand.BusinessLayer.Services;
using MentorOnDemand.Entities;
using MentorOnDemand.Tests.Exceptions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MentorOnDemand.Tests.TestCases
{
   public class ExceptionTest
    {
        private IUserServices _userServices;
        private IMentorServices _mentorServices;

        public readonly Mock<IUserRepository> service = new Mock<IUserRepository>();
        public readonly Mock<IMentorRepository> services = new Mock<IMentorRepository>();

        public ExceptionTest()
        {
            _userServices = new UserServices(service.Object);
            _mentorServices = new MentorServices(services.Object);
        }

        Random random = new Random();
        [Fact]
        public async void ExceptionTestForTrainerNotFound()
        {

            //Arrange
            var user = new User { Id = 10 };
            //Action
            //Assert
            var ex = await Assert.ThrowsAsync<UserNotFoundException>(async () => await _userServices.GetUser(user.Id));
            Assert.Equal("User Not Found ", ex.Message);
        }



        [Fact]
        public async System.Threading.Tasks.Task ExceptionTestForSearchItems()
        {
            //Arrange
            MentorDetails mentor = new MentorDetails()
            { 
                Technology = ".net" 
            };
            List<MentorDetails> mentorlist = new List<MentorDetails>();
            mentorlist.Add(mentor);

            //Assert
            var ex = await Assert.ThrowsAsync<MentorNotFoundException>(async () =>await _userServices.SearchMentor(mentor.Technology));
            Assert.Equal("Mentor Not Found ", ex.Message);
        }
   }
}
