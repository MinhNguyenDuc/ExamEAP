using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exam.Entity;

namespace Exam.Models
{
    public class ExamContext : DbContext
    {
        public ExamContext (DbContextOptions<ExamContext> options)
            : base(options)
        {
        }

        public DbSet<Exam.Entity.Currency> Currency { get; set; }
    }
}
