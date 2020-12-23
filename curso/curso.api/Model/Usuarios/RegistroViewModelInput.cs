using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Model.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O login é obrigatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatorio")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O Senha é obrigatorio")]
        public string Email { get; set; }


    }
}
