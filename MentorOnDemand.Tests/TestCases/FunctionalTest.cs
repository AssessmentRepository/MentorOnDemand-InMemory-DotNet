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
   public class FunctionalTest
    {

        private IUserServices _userServices;
        private IMentorServices _mentorServices;

        public readonly Mock<IUserRepository> userService = new Mock<IUserRepository>();
        public readonly Mock<IMentorRepository> mentorService = new Mock<IMentorRepository>();

        public FunctionalTest()
        {
            _userServices = new UserServices(userService.Object);
            _mentorServices = new MentorServices(mentorService.Object);
        }
        Random random = new Random();

        [Fact]
        public async Task TestFor_ValidUserRegistrationAsync()
        {

            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "abc@gmail.com",
                Password = "1234",
            };

            userService.Setup(repos => repos.SignUpAsync(user)).ReturnsAsync(user);
            var registeredUser = await _userServices.SignUpAsync(user);
            Assert.Equal(user, registeredUser);
        }


        [Fact]
        public async Task Testfor_ValidUserSignin()
        {
            var user = new User()
            {
                Id = random.Next(35, 300000),
                UserName = "abc@gmail.com",
                Password = "1234",
            };
            userService.Setup(repos => repos.SignIn(user.UserName, user.Password)).ReturnsAsync(user);
            var registerdUser  = await _userServices.SignIn(user.UserName, user.Password);

            Assert.Equal(user, registerdUser); ;
        }

        [Fact]
        public async Task Testfor_GetAllUser()
        {
            //Action
            userService.Setup(repos => repos.GetAllUserAsync());
            var UserList = await _userServices.GetAllUserAsync();
            //Assertion
            Assert.NotNull(UserList);
        }

        [Fact]
        public async Task Testfor_GetUser()
        {
            //Action
            var user = new User()
            {
                Id = 35,
                UserName = "Rose",
                Password = "1234",
            };
            userService.Setup(repos => repos.GetUser(user.Id)).ReturnsAsync(user);
            var userByid = await _userServices.GetUser(user.Id);
            //Assertion
            Assert.Equal(user, userByid);
        }

        [Fact]
        public async Task Test_for_AddUserProfileAsync()
        {
            User user = new User()
            {
                Id = 1,
                UserName = "abi@gmail.com",
                FirstName = "Abi",
                LastName = "B",
                ContactNumber = 99037464774,
                Experience = 2,
            };
            userService.Setup(repos => repos.AddProfile(user)).ReturnsAsync(user);
            var addedProfile =await _userServices.AddProfile(user);
            var getprofile = await _userServices.GetProfile(user.Id);

            //Assert
            Assert.Equal(getprofile, addedProfile);
            Assert.Equal(user, addedProfile);
        }

        [Fact]
        public async Task Test_for_EditProfileAsync()
        {
            User user = new User()
            {
                Id = 1,

            };
            userService.Setup(repos => repos.EditProfile(user.Id)).ReturnsAsync(user);
            var editedProfile = await _userServices.EditProfile(user.Id);
            var getprofile = await _userServices.GetProfile(user.Id);

            //Assert
            Assert.Equal(getprofile, editedProfile);
            Assert.Equal(user, editedProfile);
        }

        [Fact]
        public void Test_for_SearchMentor()
        {
            //Arrange
           MentorDetails mentor = new MentorDetails()
           {
               Technology = ".net" 
            };
            //Action
            userService.Setup(repos => repos.SearchMentor(mentor.Technology));
            var result = _userServices.SearchMentor(mentor.Technology);
            var getSearchMentor = _userServices.GetMentorDetails(mentor.Technology);
            //Assert
            Assert.Equal(result, getSearchMentor);
        }


        [Fact]
        public  void Test_for_SendProposalAsync()
        {
            //Arrange
            User user = new User()
            {
                Id = 1,
                UserName = "aaa@gmail.com",
                FirstName = "aaa",
                LastName = "bbb",
                ContactNumber = 1111111111,
                Experience = 2,
            };
            MentorDetails mentor = new MentorDetails
            {
                Id = 1,
            };
            userService.Setup(repos => repos.SendProposal(user, mentor.Id));
            var result =_userServices.SendProposal(user, mentor.Id);
            Assert.True(result);
        }


        [Fact]
        public async Task Test_for_AddProfileMentorAsync()
        {

            MentorDetails mentordetails = new MentorDetails()
            {
                Id = 1,
                Email = "aa@gmail.com",
                Technology = "sss",
                Role = "bbb",
                Exprience = 2,
                Facilities = "qqq",
                Fees = 2000,
                WorkHours = 4

            };
            mentorService.Setup(repos => repos.AddProfile(mentordetails)).ReturnsAsync(mentordetails);
            var addedProfile = await _mentorServices.AddProfile(mentordetails);
            var getprofile = await _mentorServices.ViewProfile(mentordetails.Id);

            //Assert
            Assert.Equal(getprofile, addedProfile);
            Assert.Equal(mentordetails, addedProfile);
        }
       
        [Fact]
        public void Test_for_AcceptProposal()
        {
            User user = new User()
            {
                Id = 1,
            };
            var Acceptproposal = _mentorServices.AcceptProposal(user.Id);
            Assert.True(Acceptproposal);
        } 


        [Fact]
        public async Task Test_for_MentorEditProfileAsync()
        {
            MentorDetails mentor=new MentorDetails()
            {
                Id = 1,
            };


            mentorService.Setup(repos => repos.EditProfile(mentor.Id)).ReturnsAsync(mentor);
            var editedProfile = await _mentorServices.EditProfile(mentor.Id);
            var getprofile = await _mentorServices.ViewProfile(mentor.Id);

            //Assert
            Assert.Equal(getprofile, editedProfile);
            Assert.Equal(mentor, editedProfile);
        }
       

        //Mentor
        [Fact]
        public async Task Test_for_MentorSingupAsync()
        {
            MentorDetails mentordetail = new MentorDetails()
            {
                Role = "aaa",
                UserName = "1qq",
                Password = "111",
                ContactNumber = 111111111
            };
            mentorService.Setup(repos => repos.SignUp(mentordetail)).ReturnsAsync(mentordetail);
            var registeredMentor = await _mentorServices.SignUp(mentordetail);
            Assert.Equal(mentordetail, registeredMentor);
        }

        [Fact]
        public async Task Testfor_ValidMentorSignin()
        {
            MentorDetails mentordetail = new MentorDetails()
            {
                Role = "aaa",
                UserName = "abc@gmail.com",
                Password = "111",
                ContactNumber = 111111111
            };
            mentorService.Setup(repos => repos.SignIn(mentordetail.UserName, mentordetail.Password)).ReturnsAsync(mentordetail);
            var registerdMentor = await _mentorServices.SignIn(mentordetail.UserName, mentordetail.Password);

            Assert.Equal(mentordetail, registerdMentor); ;
        }

    }
}
