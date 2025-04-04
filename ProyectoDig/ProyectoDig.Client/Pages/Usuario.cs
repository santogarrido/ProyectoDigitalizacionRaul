using System.ComponentModel.DataAnnotations;

namespace ProyectoDig.Client.Pages
{
    public class Usuario
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El email es inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Contraseña { get; set; }

        public string Rol { get; set; }

        public Usuario(string nombre, string email, string contraseña, string rol)
        {
            Nombre = nombre;
            Email = email;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
