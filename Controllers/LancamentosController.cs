using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMidasAPI.Data;
using ProjetoMidasAPI.Models;

namespace ProjetoMidasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LancamentosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LancamentosController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lancamento>>> Get() =>
            await _context.Lancamentos.ToListAsync();

        [HttpPost]
        public async Task<ActionResult<Lancamento>> Post(Lancamento lancamento)
        {
            _context.Lancamentos.Add(lancamento);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = lancamento.IdLancamento }, lancamento);
        }
    }
}
