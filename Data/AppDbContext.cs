using Microsoft.EntityFrameworkCore;
using undisclosed_back.Models;

namespace undisclosed_back.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) 
        {

        }

        // protected override void OnModelCreating (ModelBuilder builder)
        // {
        //     builder.Entity<Endereco>()
        //     .HasOne(endereco => endereco.Cinema)
        //     .WithOne(Cinema => Cinema.Endereco)
        //     .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);

        //     builder.Entity<Cinema>()
        //     .HasOne(cinema => cinema.Gerente)
        //     .WithMany(gerente => gerente.Cinemas)
        //     .HasForeignKey(cinema => cinema.GerenteId);

        //     builder.Entity<Sessao>()
        //     .HasOne(sessao => sessao.Filme)
        //     .WithMany(filme => filme.Sessoes)
        //     .HasForeignKey(sessao => sessao.FilmeId);

        //     builder.Entity<Sessao>()
        //     .HasOne(sessao => sessao.Cinema)
        //     .WithMany(cinema => cinema.Sessoes)
        //     .HasForeignKey(sessao => sessao.CinemaId);
        // }

        public DbSet<Professions> Professions { get; set; }
        // public DbSet<Cinema> Cinemas { get; set; }
        // public DbSet<Endereco> Enderecos {get; set;}
        // public DbSet<Gerente> Gerentes {get; set;}
        // public DbSet<Sessao> Sessoes {get; set;}
        // public DbSet<Usuario> Usuarios {get; set;}


    }
}