using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CitaM.Models;

namespace CitaM.Datos
{
    public class contexto : DbContext
    {
        public contexto(DbContextOptions<contexto> options) : base(options)
        {

        }
        public DbSet<cita> citas { get; set; }
    }
}
