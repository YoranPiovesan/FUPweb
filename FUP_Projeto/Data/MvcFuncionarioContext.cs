using FUP_Projeto.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FUP_Projeto.Data
{
    public class MvcFuncionarioContext : IdentityDbContext
    {
       public MvcFuncionarioContext(DbContextOptions<MvcFuncionarioContext> options)
            : base(options)
        {
        }
        public DbSet<Funcionario> Movie { get; set; }
    }
}
