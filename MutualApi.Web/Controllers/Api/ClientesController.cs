using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MutualApi.Web.Data;
using MutualApi.Web.Models;
using System.Threading.Tasks;

namespace MutualApi.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ClientesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        [Route("GetUserByDocument")]
        public async Task<IActionResult> GetUserByDocument(UsuarioRequest userRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await _dataContext.ClientesDatos.FirstOrDefaultAsync(o => o.Dni == userRequest.Dni);

            if (user == null)
            {
                return BadRequest("El Usuario no existe");
            }

            if (user.ClaveApp != userRequest.ClaveApp)
            {
                return BadRequest("Clave incorrecta");
            }
            return Ok(user);
        }
    }
}