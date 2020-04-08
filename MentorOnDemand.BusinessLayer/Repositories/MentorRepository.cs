using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MentorOnDemand.DataLayer;
using MentorOnDemand.Entities;

namespace MentorOnDemand.BusinessLayer.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public MentorRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

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
