using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpgApi.Data;
using Microsoft.EntityFrameworkCore;

namespace RpgApi-1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosControllers : ControllerBase
    {
        private readonly DataContext _context;

        public UsuariosControllers(DataContext _context)
        {
            _context = _context;

        }

       private async Task<bool> UsuarioExistente(string username)
        {
            if (await _context.TB_USUARIOS.AnyAsync(x => x.Username.ToLower() ))
            {
                return true;
            }
            return false;
          }

         [HttpPost ("Registrar")]

        public async Task<IActionResult> RegistrarUsuario(Usuario user)
        {
            try
            {
                if(await UsuarioExistente(user.Username))
                throw new System.Exception("Nome de usuário já existe");

                Criptografia.CriarPasswordHash(user.PasswordString, out byte[] hash , out byte[] salt);
                user.PasswordString = string.Empty;
                user.PasswordHash = hash;
                user.PasswordSalt = salt;    
                await _context.TB_USUARIOS.AddAsync(user);
                await _context.SaveChangesAsync();

                return ok (user.id);

            }
            catch (System.Exception)
            {
                return BadRequest(ex.Message);
                
            }




        }



  }
}