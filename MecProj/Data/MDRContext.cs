using MecProj.Configuration;
using MecProj.Models;
using Microsoft.EntityFrameworkCore;

namespace MecProj.Data
{
    public class MDRContext : DbContext
    {
        public MDRContext(DbContextOptions<MDRContext> options) : base(options)
        {
        }

        //public override Cliente Entry(Cliente Nome)
        //{
        //    return base.Entry(Nome);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MDRContext;Data Source=DESKTOP-QC5LNR4\SQLEXPRESS"); /*PcCasa*/
            /*optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;User ID=luiz;Initial Catalog=MDRContext;Data Source=LUIZ\SQLLUIZ");*/ /*notebbok*/
        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.ApplyConfiguration(new ClienteConfiguration());
            mb.ApplyConfiguration(new OrdemConfiguration());
            mb.ApplyConfiguration(new FornecedorConfiguration());
        }

        public DbSet<MecProj.Models.Cliente> Cliente { get; set; }
        public DbSet<MecProj.Models.OrdemServico> Servico { get; set; }
        public DbSet<MecProj.Models.Fornecedor> Fornecedor { get; set; }
        public DbSet<MecProj.Models.Empresa> Empresa { get; set; }




    }

}
