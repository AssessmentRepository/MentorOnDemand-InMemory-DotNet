using MentorOnDemand.BusinessLayer.Interfaces;
using MentorOnDemand.BusinessLayer.Repositories;
using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MentorOnDemand.BusinessLayer.Services
{
    public class MentorServices : IMentorServices
    {
        private readonly IMentorRepository _mentorRepository;

        public MentorServices(IMentorRepository mentorRepository)
        {
            _mentorRepository = mentorRepository;
        }

        public bool AcceptProposal(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<MentorDetails> AddProfile(MentorDetails mentor)
        {
            throw new NotImplementedException();
        }

        public Task<MentorDetails> EditProfile(long MentorId)
        {
            throw new NotImplementedException();
        }

        public Task<MentorDetails> SignIn(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<MentorDetails> SignUp(MentorDetails mentor)
        {
            throw new NotImplementedException();
        }

        public Task<MentorDetails> ViewMentor(long MentorId)
        {
            throw new NotImplementedException();
        }

        public Task<MentorDetails> ViewProfile(long MentorId)
        {
            throw new NotImplementedException();
        }

        public Task<User> ViewProposal(long UserId)
        {
            throw new NotImplementedException();
        }
    }
}
