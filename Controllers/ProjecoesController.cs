using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMidasAPI.Data;
using ProjetoMidasAPI.Models;

namespace ProjetoMidasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjecoesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProjecoesController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Projecao>>> Get() =>
            await _context.Projecoes.ToListAsync();

        [HttpPost]
        public async Task<ActionResult<Projecao>> Post(Projecao projecao)
        {
            _context.Projecoes.Add(projecao);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = projecao.IdProjecao }, projecao);
        }
    }
}
