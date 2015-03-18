using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMusica.Persistencia
{
    public class Usuario
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmacionPassword { get; set; }
        public string CorreoElecronico { get; set; }
        public string Nombre { get; set; }
        public string NombreCiudad { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
