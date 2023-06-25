using Microsoft.EntityFrameworkCore;
using SiHuria.Api.Entities;

namespace SiHuria.Api.Context
{
    public class SIHuriaContext : DbContext
    {
        public DbSet<RuasReg> RuasRegs { get; set; }
        public DbSet<RuasRegDetail> RuasRegDetails { get; set; }
        public DbSet<Sintua> Sintuas { get; set; }
        public DbSet<Wijk> Wijks { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Cst> Csts { get; set; }
    }
}
