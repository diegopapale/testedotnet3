using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Luby.Business.Shared.Models.Entities;
using Luby.Data.Repositories;
using Luby.Service.Configurations;
using System.Linq;

namespace Luby.Service.Controllers
{
    [Route("api/luby")]
    public class Luby_Controller : ControllerBase
    {
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Programador([FromBody] Programador obj)
        {
            try
            {
                var Configuration = InjectionConfiguration.configurationRoot();
                var _connectionString = Configuration["ConnectionStrings:BaseLuby"];

                if (await new Luby_Repository(_connectionString).InserirProgramador(obj))
                {
                    return Ok("Programador cadastrado com sucesso.");
                }
                else
                {
                    return BadRequest("Programador não foi cadastrado.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> Horas([FromBody] Horas obj)
        {
            try
            {
                var Configuration = InjectionConfiguration.configurationRoot();
                var _connectionString = Configuration["ConnectionStrings:BaseLuby"];

                if (await new Luby_Repository(_connectionString).InserirHoras(obj))
                {
                    return Ok("Horas cadastradas com sucesso.");
                }
                else
                {
                    return BadRequest("Horas não foram cadastradas.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
        }

        [HttpGet]
        [Consumes("application/json")]
        public async Task<IActionResult> Lista()
        {
            try
            {
                var Configuration = InjectionConfiguration.configurationRoot();
                var _connectionString = Configuration["ConnectionStrings:BaseLuby"];

                var _lista = await new Luby_Repository(_connectionString).RetornarProgramadorPorMediaDeHoras();

                if (_lista.Count() > 0)
                {
                    return Ok(_lista.ToList());
                }
                else
                {
                    return BadRequest("Nenhum registro encontrado.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }
        }
    }
}
