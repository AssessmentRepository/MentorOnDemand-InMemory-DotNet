using MentorOnDemand.BusinessLayer.Interfaces;
using MentorOnDemand.BusinessLayer.Repositories;
using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MentorOnDemand.BusinessLayer.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        //  private readonly MockContext _context;


        public UserServices(IUserRepository userRepository)
        {

            _userRepository = userRepository;

        }

        public bool AddProfile(User User)
        {
            throw new NotImplementedException();
        }

        public bool AssignRating(int Rating)
        {
            throw new NotImplementedException();
        }

        public Task<User> EditProfile(long UserId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            try
            {
                var user = await _userRepository.GetAllUserAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public Task<IEnumerable<MentorDetails>> GetMentorDetails(string Technology)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetProfile(long UserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrainingDetails>> GetTrainings(string status)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MentorDetails>> SearchMentor(string Technology)
        {
            throw new NotImplementedException();
        }

        public Task<MentorDetails> SelectMentor(long MentorId)
        {
            throw new NotImplementedException();
        }

        public bool SendProposal(User User, long MentorId)
        {
            throw new NotImplementedException();
        }

        public Task<User> SignIn(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public async Task<User> SignUpAsync(User user)
        {
            try
            {

                var users = await _userRepository.SignUpAsync(user);
                return users;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        Task<User> IUserServices.AddProfile(User User)
        {
            throw new NotImplementedException();
        }
    }
}
