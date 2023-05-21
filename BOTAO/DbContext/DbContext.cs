using BOTAO.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BOTAO.DbContext {
    

        /// <summary>
        /// esta classe representa a BD do projeto
        /// </summary>
        public class DbContext : IdentityDbContext {

            public DbContext(
                DbContextOptions<DbContext> options)
                : base(options) {
            }

            /*
             * criação das tabelas da base de dados
             */

            public DbSet<Jogador> Jogador { get; set; }
            public DbSet<Itens> Itens { get; set; }
            public DbSet<Grupo> Grupo { get; set; }
            public DbSet<Mensagem> Mensagem { get; set; }





        }
}
