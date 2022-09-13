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

            if (user.Socio == false)
            {
                return BadRequest("El Usuario no es socio");
            }

            if (user.FechaBaja != null)
            {
                return BadRequest("El Usuario fue dado de baja");
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente([FromRoute] int id, [FromBody] ClienteRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != request.Id)
            {
                return BadRequest();
            }



            var oldCliente = await _dataContext.ClientesDatos.FindAsync(request.Id);
            if (oldCliente == null)
            {
                return BadRequest("El Cliente no existe.");
            }

            oldCliente.AfSeguroCony = request.AfSeguroCony;
            oldCliente.AfSeguroTit = request.AfSeguroTit;
            oldCliente.Apellido = request.Apellido;
            oldCliente.ApellidoConyuge = request.ApellidoConyuge;
            oldCliente.ApellidoTitular = request.ApellidoTitular;
            oldCliente.Barrio = request.Barrio;
            oldCliente.Beneficio1 = request.Beneficio1;
            oldCliente.Categoria = request.Categoria;
            oldCliente.Celular = request.Celular;
            oldCliente.ClaveApp = request.ClaveApp;
            oldCliente.Cp = request.Cp;
            oldCliente.Cuil = request.Cuil;
            oldCliente.CuilConyuge = request.CuilConyuge;
            oldCliente.Dni = request.Dni;
            oldCliente.DniConyuge = request.DniConyuge;
            oldCliente.Domicilio = request.Domicilio;
            oldCliente.EgresoPagoSegEnf = request.EgresoPagoSegEnf;
            oldCliente.EgresoPagoSepConyuge = request.EgresoPagoSepConyuge;
            oldCliente.EgresoPagoSepTitular = request.EgresoPagoSepTitular;
            oldCliente.Email = request.Email;
            oldCliente.EstadoCivil = request.EstadoCivil;
            oldCliente.FechaAlta = request.FechaAlta;
            oldCliente.FechaBaja = request.FechaBaja;
            oldCliente.FechaCarga = request.FechaCarga;
            oldCliente.FechaFallecimiento = request.FechaFallecimiento;
            oldCliente.FechaFallecimientoConyuge = request.FechaFallecimientoConyuge;
            oldCliente.FechaJubilacion = request.FechaJubilacion;
            oldCliente.FechaNacimiento = request.FechaNacimiento;
            oldCliente.FechaNacimientoConyuge = request.FechaNacimientoConyuge;
            oldCliente.FecPagoSegEnf = request.FecPagoSegEnf;
            oldCliente.FecPagoSepConyuge = request.FecPagoSepConyuge;
            oldCliente.FecPagoSepTitular = request.FecPagoSepTitular;
            oldCliente.Id = request.Id;
            oldCliente.Localidad = request.Localidad;
            oldCliente.LugarNacimiento = request.LugarNacimiento;
            oldCliente.LugarTrab = request.LugarTrab;
            oldCliente.MontoPagoSegEnf = request.MontoPagoSegEnf;
            oldCliente.MontoPagoSepConyuge = request.MontoPagoSepConyuge;
            oldCliente.MontoPagoSepTitular = request.MontoPagoSepTitular;
            oldCliente.MotivoBaja = request.MotivoBaja;
            oldCliente.Nacionalidad = request.Nacionalidad;
            oldCliente.Nombre = request.Nombre;
            oldCliente.NombreConyuge = request.NombreConyuge;
            oldCliente.NombreTitular = request.NombreTitular;
            oldCliente.NroCuentaHp = request.NroCuentaHp;
            oldCliente.NroSocio = request.NroSocio;
            oldCliente.ObsSegEnfAcc = request.ObsSegEnfAcc;
            oldCliente.PlanSegEnf = request.PlanSegEnf;
            oldCliente.SegAcc = request.SegAcc;
            oldCliente.SegEnf = request.SegEnf;
            oldCliente.ServicioEspecialidad = request.ServicioEspecialidad;
            oldCliente.Sexo = request.Sexo;
            oldCliente.Socio = request.Socio;
            oldCliente.Supervivencia = request.Supervivencia;
            oldCliente.Telefono = request.Telefono;
            oldCliente.TipoJubilacion = request.TipoJubilacion;
            oldCliente.TrabFuera = request.TrabFuera;
            oldCliente.TrabHp = request.TrabHp;
            

            _dataContext.ClientesDatos.Update(oldCliente);
            await _dataContext.SaveChangesAsync();
            return Ok();
        }
    }
}