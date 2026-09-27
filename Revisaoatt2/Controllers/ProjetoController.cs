using Revisaoatt2.Models;
using Revisaoatt2.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Revisaoatt2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpPost("CadastrarProjeto")]
        public IActionResult CadastrarProjeto(Projeto projeto)
        {
            var resultado = _projetoRepository.ObterPorNumero(projeto.NumeroDoProjeto);

            if (resultado is null)
            {
                _projetoRepository.CadastrarProjeto(projeto);
                return Ok("Projeto cadastrado com sucesso!");
            }

            return BadRequest("Projeto já cadastrado!");
        }

        [HttpPost("RegistrarVisita")]
        public IActionResult RegistrarVisita(Visita visita)
        {
            var projeto = _projetoRepository.ObterPorNumero(visita.Projeto);

            if (projeto is null)
            {
                return NotFound("Projeto não encontrado!");
            }

            _projetoRepository.RegistrarVisita(visita);
            return Ok("Visita registrada com sucesso!");
        }

        [HttpGet("ObterProjetos")]
        public IActionResult ObterProjetos()
        {
            return Ok(_projetoRepository.ObterTodos());
        }

        [HttpGet("ObterVisitasPorProjeto")]
        public IActionResult ObterVisitasPorProjeto(int numero)
        {
            var resultado = _projetoRepository.ObterVisitasPorProjeto(numero);

            if (resultado.Count == 0)
            {
                return NotFound("Nenhuma visita encontrada!");
            }

            return Ok(resultado);
        }
    }
}
