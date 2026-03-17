using Microsoft.AspNetCore.Mvc;
using Samuel_e_Linerker.Models;
using Samuel_e_Linerker.Repository.Contract;

namespace Samuel_e_Linerker.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;
        
        public UsuarioController (IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            return View(_usuarioRepository.ObterTodosUsuarios());
        }

        [HttpGet]

        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Cadastrar(usuario);
            }
            return View();
        }

    }
}
