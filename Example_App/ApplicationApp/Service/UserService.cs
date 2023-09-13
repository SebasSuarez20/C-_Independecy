using Example_App.ApplicationApp.Interface_Controller;
using Example_App.Infraestructura.Model;
using Microsoft.EntityFrameworkCore;

namespace Example_App.ApplicationApp.Service
{
    public class UserService : IUser
    {

        private AppDbContext _context;

        public UserService(AppDbContext context) { 
        
            _context = context;
        }

        public async Task<object> CreateUser()
        {
           return await _context.user.ToListAsync();
        }
    }
}
