using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class UsuariosController : ApiController
    {
        Usuario[] usuarios = new Usuario[]
        {
           new Usuario{login="aluno", senha="unit"},
           new Usuario{login="teste", senha="teste1"}
        };

        public IEnumerable<Usuario> GetUsuarios()
        {
            return usuarios;
        }
    }
}
