using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MentorOnDemand.BusinessLayer.Repositories
{
    public interface IMentorRepository
    {
        Task<MentorDetails> SignUp(MentorDetails mentor);
        Task<MentorDetails> SignIn(string UserName, string Password);
        Task<MentorDetails> AddProfile(MentorDetails mentor);
        Task<MentorDetails> ViewProfile(long MentorId);
        Task<MentorDetails> EditProfile(long MentorId);
        Task<User> ViewProposal(long UserId);
        Task<MentorDetails> ViewMentor(long MentorId);
        bool AcceptProposal(int UserId);
    }
}
