using Dapper;
using MentorOnDemand.DataLayer;
using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MentorOnDemand.BusinessLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public UserRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }

        public async Task<User> SignUpAsync(User user)
        {
            try
            {
                var connection = await _dbConnectionFactory.CreateConnectionAsync();

                await connection.ExecuteAsync("Insert into User (Id, UserName, Password, FirstName, LastName, ContactNumber, Role, LinkedinURL, Experience, Active, ConfirmedSignUp, ResetPassword, ResetPasswordDate) VALUES (@id, @userName, @password, @firstName,@lastName, @contactNumber, @role, @linkedinURL, @experience, @active, @confirmedSignUp, @resetPassword, @resetPasswordDate)", new { id = user.Id, userName = user.UserName, password = user.Password, firstName = user.FirstName, lastName = user.LastName, contactNumber = user.ContactNumber, role = user.Role, linkedinURL = user.LinkedinURL, experience = user.Experience, active = user.Active, confirmedSignUp = user.ConfirmedSignUp, resetPassword = user.ResetPassword, resetPasswordDate = user.ResetPasswordDate});
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            try
            {
                var connection = await _dbConnectionFactory.CreateConnectionAsync();
                return await connection.QueryAsync<User>("select * from User");
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public Task<User> SignIn(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<User> AddProfile(User User)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetProfile(long UserId)
        {
            throw new NotImplementedException();
        }

        public Task<User> EditProfile(long UserId)
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

        public bool AssignRating(int Rating)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrainingDetails>> GetTrainings(string status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MentorDetails>> GetMentorDetails(string Technology)
        {
            throw new NotImplementedException();
        }
    }
}
