using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MecProj.Data;
using MecProj.Models;

namespace MecProj.Controllers
{
    public class OrdemServicosController : Controller
    {
        private readonly MDRContext _context;

        public OrdemServicosController(MDRContext context)
        {
            _context = context;
        }

        // GET: OrdemServicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Servico.ToListAsync());
        }

        public static List<Cliente> GetClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            return lista;
        }


        // GET: OrdemServicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.Servico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // GET: OrdemServicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdemServicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cliente,Service,Descricao,Pecas,Entrada,Situacao")] OrdemServico ordemServico)
        {
            if (ModelState.IsValid)
            {
                //var Cliente = await _context.Cliente.Select(x => x.Nome).ToListAsync();
                _context.Add(ordemServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordemServico);
        }

        // GET: OrdemServicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.Servico.FindAsync(id);
            if (ordemServico == null)
            {
                return NotFound();
            }
            return View(ordemServico);
        }

        // POST: OrdemServicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cliente,Service,Descricao,Pecas,Entrada,Situacao")] OrdemServico ordemServico)
        {
            if (id != ordemServico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordemServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdemServicoExists(ordemServico.Id))
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
            return View(ordemServico);
        }

        // GET: OrdemServicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.Servico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // POST: OrdemServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordemServico = await _context.Servico.FindAsync(id);
            _context.Servico.Remove(ordemServico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdemServicoExists(int id)
        {
            return _context.Servico.Any(e => e.Id == id);
        }
    }
}
