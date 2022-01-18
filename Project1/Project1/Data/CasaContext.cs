using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.Models;

namespace Project1.Data
{
    public class CasaContext: DbContext
    {
        public DbSet<Rol> Roles { get; set; }
        public DbSet<UserRol> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Casa> Casa { get; set; }
        public DbSet<Adresa> Adresa { get; set; }

        public CasaContext(DbContextOptions<CasaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(x => x.Casa)
                .WithMany(y => y.Useri)
                .HasForeignKey(z => z.CasaId);

            builder.Entity<Adresa>()
            .HasOne(x => x.Casa)
            .WithOne(y => y.Adresa)
            .HasForeignKey<Casa>(z => z.CasaId);

            builder.Entity<UserRol>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.UserId);

            builder.Entity<UserRol>()
                .HasOne(x => x.Rol)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.RoleId);

            builder.Entity<UserRol>()
                .HasAlternateKey(x => new { x.UserId, x.RoleId });
        }
    }
}
