using Microsoft.AspNetCore.Mvc;
using GerenciadorDeTarefas.data;
using GerenciadorDeTarefas.models;

[ApiController]
[Route("api/[controller]")]
public class TarefasController : ControllerBase
{
    private readonly AppDbContext _context;

    public TarefasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetTarefas()
    {
        return Ok(_context.Tarefas.ToList());
    }

    [HttpPost]
    public IActionResult CriarTarefa([FromBody] Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetTarefas), new { id = tarefa.Id }, tarefa);
    }
}
