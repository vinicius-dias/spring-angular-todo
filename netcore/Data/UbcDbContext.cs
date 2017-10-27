using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace poc_webapi.data
{
    public partial class UbcDbContext : DbContext
    {
        public virtual DbSet<PocTask> PocTask { get; set; }
        public virtual DbSet<PocUser> PocUser { get; set; }

        public UbcDbContext(DbContextOptions<UbcDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PocTask>(entity =>
            {                
                entity.ToTable("poc_task");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Done)
                    .HasColumnName("done")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PocTask)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_poc_user_task");
            });

            modelBuilder.Entity<PocUser>(entity =>
            {
                entity.ToTable("poc_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.HasSequence("poc_task_seq");
        }
    }
}
