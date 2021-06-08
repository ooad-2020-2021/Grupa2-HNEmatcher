using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoveAlgorithm.Models;

namespace LoveAlgorithm.Data
{
    public class LoveAlgorithmContext : DbContext
    {
        public LoveAlgorithmContext(DbContextOptions<LoveAlgorithmContext> options)
            : base(options)
        {
        }

        public DbSet<LoveAlgorithm.Models.Chat> Chat { get; set; }
        public DbSet<LoveAlgorithm.Models.Pitanja> Pitanja
        {
            get; set;
        }
        public DbSet<LoveAlgorithm.Models.Poruka> Poruka { get; set; }
        public DbSet<LoveAlgorithm.Models.RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }
        public DbSet<LoveAlgorithm.Models.Recenzije> Recenzije { get; set; }

    }
}
