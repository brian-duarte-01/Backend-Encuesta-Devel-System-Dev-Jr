using System;
using System.Collections.Generic;
using Backend_Encuesta_Devel_System.Config;
using Microsoft.EntityFrameworkCore;

namespace Backend_Encuesta_Devel_System.Models;

public partial class EncuestaDevelContext : DbContext
{
    public EncuestaDevelContext()
    {
    }

    public EncuestaDevelContext(DbContextOptions<EncuestaDevelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Encuestador> Encuestadors { get; set; }

    public virtual DbSet<Encuestum> Encuesta { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(Conexion.Instance.cadenaConexion);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Encuestador>(entity =>
        {
            entity.HasKey(e => e.IdEncuestador).HasName("PK__encuesta__8AC5535DB1F1D127");

            entity.ToTable("encuestador");

            entity.Property(e => e.IdEncuestador).HasColumnName("id_encuestador");
            entity.Property(e => e.Correo)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.EPrimerApellido)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_primer_apellido");
            entity.Property(e => e.EPrimerNombre)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_primer_nombre");
            entity.Property(e => e.ESegundoApellido)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_segundo_apellido");
            entity.Property(e => e.ESegundoNombre)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_segundo_nombre");
            entity.Property(e => e.ETelefono).HasColumnName("e_telefono");
        });

        modelBuilder.Entity<Encuestum>(entity =>
        {
            entity.HasKey(e => e.IdEncuesta).HasName("PK__encuesta__013535C3F280A74C");

            entity.ToTable("encuesta");

            entity.Property(e => e.IdEncuesta).HasColumnName("id_encuesta");
            entity.Property(e => e.EDescripPregunta1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_descrip_pregunta_1");
            entity.Property(e => e.EDescripPregunta2)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_descrip_pregunta_2");
            entity.Property(e => e.EDescripPregunta3)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_descrip_pregunta_3");
            entity.Property(e => e.EDescripPregunta4)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_descrip_pregunta_4");
            entity.Property(e => e.EDescripPregunta5)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_descrip_pregunta_5");
            entity.Property(e => e.EDescripcion)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_descripcion");
            entity.Property(e => e.EEncuestador)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_encuestador");
            entity.Property(e => e.EFecha)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_fecha");
            entity.Property(e => e.ENombreEncuesta)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_nombre_encuesta");
            entity.Property(e => e.ERespuesta1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_respuesta_1");
            entity.Property(e => e.ERespuesta2)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_respuesta_2");
            entity.Property(e => e.ERespuesta3)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_respuesta_3");
            entity.Property(e => e.ERespuesta4)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_respuesta_4");
            entity.Property(e => e.ERespuesta5)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_respuesta_5");
            entity.Property(e => e.ETituloPregunta1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_titulo_pregunta_1");
            entity.Property(e => e.ETituloPregunta2)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_titulo_pregunta_2");
            entity.Property(e => e.ETituloPregunta3)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_titulo_pregunta_3");
            entity.Property(e => e.ETituloPregunta4)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_titulo_pregunta_4");
            entity.Property(e => e.ETituloPregunta5)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_titulo_pregunta_5");
            entity.Property(e => e.EUsuario)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("e_usuario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuario__4E3E04AD4FB51436");

            entity.ToTable("usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UNick)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("u_nick");
            entity.Property(e => e.UPassword)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("u_password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
