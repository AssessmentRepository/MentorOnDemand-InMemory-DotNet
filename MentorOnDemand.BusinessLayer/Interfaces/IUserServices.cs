using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MentorOnDemand.BusinessLayer.Interfaces
{
    public interface IUserServices
    {
        Task<User> SignUpAsync(User user);
        Task<User> SignIn(string UserName, string Password);
        Task<User> GetUser(int UserId);
        Task<IEnumerable<User>> GetAllUserAsync();

        Task<User> AddProfile(User User);
        Task<User> GetProfile(long UserId);
        Task<User> EditProfile(long UserId);
        Task<IEnumerable<MentorDetails>> SearchMentor(string Technology);
        Task<MentorDetails> SelectMentor(long MentorId);
        bool SendProposal(User User, long MentorId);
        bool AssignRating(int Rating);
        Task<IEnumerable<TrainingDetails>> GetTrainings(string status);
        Task<IEnumerable<MentorDetails>> GetMentorDetails(string Technology);
    }
  }
