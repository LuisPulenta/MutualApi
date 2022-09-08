using System.ComponentModel.DataAnnotations;

namespace MutualApi.Web.Models
{
    public class UsuarioRequest
    {
        [Required]
        public int Dni { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6)]
        public string ClaveApp { get; set; }
    }
}