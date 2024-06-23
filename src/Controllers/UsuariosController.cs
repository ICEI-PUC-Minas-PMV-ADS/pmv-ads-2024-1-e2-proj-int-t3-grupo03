using Kippa.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Kippa.Controllers
{
    [Authorize]

    public class UsuariosController : Controller
    {
        private readonly KippaContext _context;

        public UsuariosController(KippaContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin, user")]
        public IActionResult AccessDenied()
        {
            return View();
        }
        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        [AllowAnonymous]
        public IActionResult FormLogin(string returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var dados = _context.Usuarios.FirstOrDefault(u => u.Nome == usuario.Nome);
            if (dados == null)
            {
                return ViewBag.Message = "Usuario ou senha estão inválidos";
            }
            bool senhaOK = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaOK)
            {
                // Claim são informações credenciais do usuário
                var claims = new List<Claim>
         {
             new Claim(ClaimTypes.Name, dados.Nome),
             new Claim(ClaimTypes.NameIdentifier, dados.IdUsuario.ToString()),
             new Claim(ClaimTypes.Name, dados.Nome),
             new Claim(ClaimTypes.Role, dados.Perfil.ToString())

         };

                var usuarioIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                //define quano tempo vai expirar a senha do usuário
                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Usuario ou senha estão inválidos";
                return View("FormLogin");
            }
            return RedirectToAction("Index");
        }
        // Logout
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        // GET: Usuarios/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [AllowAnonymous]
        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("IdUsuario,Email,Nome,Senha,DataNascimento,Profissao,Objetivo,DataCadastro,Perfil")] Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(usuario);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(usuario);
        //}
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,Email,Nome,Senha,DataNascimento,Profissao,Objetivo,DataCadastro,Perfil")] Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,Email,Nome,Senha,DataNascimento,Profissao,Objetivo,DataCadastro,Perfil")] Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.IdUsuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.IdUsuario == id);
        }
    }
}