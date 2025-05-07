using Microsoft.AspNetCore.Mvc;
using GerenciadorDeTarefas.data;
using GerenciadorDeTarefas.models;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsuariosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetUsuarios()
    {
        return Ok(_context.Usuarios.ToList());
    }

    [HttpPost]
    public IActionResult CriarUsuario([FromBody] Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.Id }, usuario);
    }
}
