using Example_App.ApplicationApp.Interface_Controller;
using Example_App.ApplicationApp.Service;
using Example_App.Infraestructura.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Example_App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerUser : ControllerBase
    {

        //Aca llamamos la interface para poder llamar los metodos internos creados.
        private readonly IUser _context;

        public ControllerUser(IUser _user)
        {
            _context = _user;
        }


        [HttpGet]
        public async Task<object> GetAllUser()
        {
            return await _context.CreateUser();
        }
    }
}
