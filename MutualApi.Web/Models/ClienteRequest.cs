using System;
using System.ComponentModel.DataAnnotations;

namespace MutualApi.Web.Models
{
    public class ClienteRequest
    {
        [Required]
        public int Id { get; set; }
        public string ApellidoTitular { get; set; }
        public string NombreTitular { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Cuil { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaFallecimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string LugarNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Domicilio { get; set; }
        public string Barrio { get; set; }
        public string Localidad { get; set; }
        public int? Cp { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string ApellidoConyuge { get; set; }
        public string NombreConyuge { get; set; }
        public int? DniConyuge { get; set; }
        public string CuilConyuge { get; set; }
        public DateTime? FechaNacimientoConyuge { get; set; }
        public DateTime? FechaFallecimientoConyuge { get; set; }
        public byte Categoria { get; set; }
        public bool Socio { get; set; }
        public DateTime? FechaCarga { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public string NroSocio { get; set; }
        public string NroCuentaHp { get; set; }
        public string TipoJubilacion { get; set; }
        public DateTime? FechaJubilacion { get; set; }
        public string ServicioEspecialidad { get; set; }
        public bool? AfSeguroTit { get; set; }
        public bool? AfSeguroCony { get; set; }
        public bool? TrabHp { get; set; }
        public bool? TrabFuera { get; set; }
        public string LugarTrab { get; set; }
        public bool? SegEnf { get; set; }
        public bool? SegAcc { get; set; }
        public bool? Beneficio1 { get; set; }
        public DateTime? Supervivencia { get; set; }
        public DateTime? FecPagoSepTitular { get; set; }
        public bool? EgresoPagoSepTitular { get; set; }
        public float? MontoPagoSepTitular { get; set; }
        public DateTime? FecPagoSepConyuge { get; set; }
        public bool? EgresoPagoSepConyuge { get; set; }
        public float? MontoPagoSepConyuge { get; set; }
        public DateTime? FecPagoSegEnf { get; set; }
        public bool? EgresoPagoSegEnf { get; set; }
        public float? MontoPagoSegEnf { get; set; }
        public string PlanSegEnf { get; set; }
        public string ObsSegEnfAcc { get; set; }
        public string ClaveApp { get; set; }
    }
}