using API.Main.Models;
using Bogus;

namespace API.Main.Fake
{
    public static class Fakedata
    {
        private static List<User> _users;
        public static List<User> GetUsers(int number)
        {
            if(_users == null)
            {  
                _users = new Faker<User>()
                .RuleFor(m => m.ID, f => f.IndexFaker+1)
                .RuleFor(m => m.Firstname, f => f.Name.FirstName())
                .RuleFor(m => m.Lastname, f => f.Name.LastName())
                .RuleFor(m => m.Address, f => f.Address.FullAddress())
                .Generate(number);
            }
           
            return _users;
        }
      
    }
}
