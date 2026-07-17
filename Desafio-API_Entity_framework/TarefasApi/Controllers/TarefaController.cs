using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarefasApi.Context;
using TarefasApi.Entities;

namespace TarefasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        // GET: /Tarefa/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);

            if (tarefa == null)
                return NotFound(new { Mensagem = $"Tarefa com Id {id} não encontrada." });

            return Ok(tarefa);
        }

        // GET: /Tarefa/ObterTodos
        [HttpGet("ObterTodos")]
        public async Task<IActionResult> ObterTodos()
        {
            var tarefas = await _context.Tarefas.ToListAsync();
            return Ok(tarefas);
        }

        // GET: /Tarefa/ObterPorTitulo?titulo=xxx
        [HttpGet("ObterPorTitulo")]
        public async Task<IActionResult> ObterPorTitulo(string titulo)
        {
            var tarefas = await _context.Tarefas
                .Where(x => x.Titulo != null && x.Titulo.Contains(titulo))
                .ToListAsync();

            return Ok(tarefas);
        }

        // GET: /Tarefa/ObterPorData?data=2024-01-01
        [HttpGet("ObterPorData")]
        public async Task<IActionResult> ObterPorData(DateTime data)
        {
            var tarefas = await _context.Tarefas
                .Where(x => x.Data.Date == data.Date)
                .ToListAsync();

            return Ok(tarefas);
        }

        // GET: /Tarefa/ObterPorStatus?status=0
        [HttpGet("ObterPorStatus")]
        public async Task<IActionResult> ObterPorStatus(EnumStatusTarefa status)
        {
            var tarefas = await _context.Tarefas
                .Where(x => x.Status == status)
                .ToListAsync();

            return Ok(tarefas);
        }

        // POST: /Tarefa
        [HttpPost]
        public async Task<IActionResult> Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Mensagem = "A data da tarefa não pode ser vazia." });

            await _context.Tarefas.AddAsync(tarefa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        // PUT: /Tarefa/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = await _context.Tarefas.FindAsync(id);

            if (tarefaBanco == null)
                return NotFound(new { Mensagem = $"Tarefa com Id {id} não encontrada." });

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Mensagem = "A data da tarefa não pode ser vazia." });

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            await _context.SaveChangesAsync();

            return Ok(tarefaBanco);
        }

        // DELETE: /Tarefa/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var tarefaBanco = await _context.Tarefas.FindAsync(id);

            if (tarefaBanco == null)
                return NotFound(new { Mensagem = $"Tarefa com Id {id} não encontrada." });

            _context.Tarefas.Remove(tarefaBanco);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
