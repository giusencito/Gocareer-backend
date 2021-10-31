﻿// <auto-generated />
using System;
using Gocareer.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gocareer.Infrastructure.Migrations
{
    [DbContext(typeof(DbContextGocareer))]
    partial class DbContextGocareerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gocareer.Domain.Article", b =>
                {
                    b.Property<int>("Articleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Articleid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("ArticleDescription");

                    b.Property<string>("ArticleName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ArticleName");

                    b.Property<int>("Careerid")
                        .HasColumnType("int")
                        .HasColumnName("Careerid");

                    b.HasKey("Articleid");

                    b.HasIndex("Careerid");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Gocareer.Domain.Career", b =>
                {
                    b.Property<int>("Careerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Careerid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CareerDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("CareerDescription");

                    b.Property<string>("CareerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("CareerName");

                    b.HasKey("Careerid");

                    b.ToTable("Career");
                });

            modelBuilder.Entity("Gocareer.Domain.Especialist", b =>
                {
                    b.Property<int>("EspecialistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EspecialistId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EspecialistEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EspecialistEmail");

                    b.Property<string>("EspecialistInformation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("EspecialistInformation");

                    b.Property<string>("EspecialistLastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("EspecialistLastName");

                    b.Property<string>("EspecialistName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("EspecialistName");

                    b.Property<string>("EspecialistPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EspecialistPassword");

                    b.HasKey("EspecialistId");

                    b.ToTable("Especialist");
                });

            modelBuilder.Entity("Gocareer.Domain.Estudiante", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserLastname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("UserLastname");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("UserName");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("UserPassword");

                    b.Property<string>("Useremail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Useremail");

                    b.HasKey("UserId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("Gocareer.Domain.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MeetingId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<int>("EspecialistId")
                        .HasColumnType("int")
                        .HasColumnName("EspecialistId");

                    b.Property<DateTime>("Hour")
                        .HasColumnType("datetime2")
                        .HasColumnName("Hour");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("MeetingId");

                    b.HasIndex("EspecialistId");

                    b.HasIndex("UserId");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("Gocareer.Domain.Message", b =>
                {
                    b.Property<int>("Messageid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Messageid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EspecialistId")
                        .HasColumnType("int")
                        .HasColumnName("EspecialistId");

                    b.Property<string>("MessageDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("MessageDescription");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<string>("answer")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("answer");

                    b.HasKey("Messageid");

                    b.HasIndex("EspecialistId");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Gocareer.Domain.Option", b =>
                {
                    b.Property<int>("Optionid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Optionid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("OptionName");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("Points");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionId");

                    b.HasKey("Optionid");

                    b.HasIndex("QuestionId");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("Gocareer.Domain.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("QuestionId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("QuestionName");

                    b.Property<int>("Score")
                        .HasColumnType("int")
                        .HasColumnName("Score");

                    b.Property<int>("Testid")
                        .HasColumnType("int")
                        .HasColumnName("Testid");

                    b.HasKey("QuestionId");

                    b.HasIndex("Testid");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Gocareer.Domain.Test", b =>
                {
                    b.Property<int>("Testid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Testid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EspecialistId")
                        .HasColumnType("int")
                        .HasColumnName("EspecialistId");

                    b.Property<bool>("Personalized")
                        .HasColumnType("bit")
                        .HasColumnName("Personalized");

                    b.Property<string>("Testname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Testname");

                    b.HasKey("Testid");

                    b.HasIndex("EspecialistId");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Gocareer.Domain.User_Test", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<int>("Testid")
                        .HasColumnType("int")
                        .HasColumnName("Testid");

                    b.Property<int>("Careerid")
                        .HasColumnType("int")
                        .HasColumnName("Careerid");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("Points");

                    b.Property<DateTime>("releasedate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Releasedate");

                    b.HasKey("UserId", "Testid", "Careerid");

                    b.HasIndex("Careerid");

                    b.HasIndex("Testid");

                    b.ToTable("User_Test");
                });

            modelBuilder.Entity("Gocareer.Domain.Work", b =>
                {
                    b.Property<int>("Workid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Workid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Careerid")
                        .HasColumnType("int")
                        .HasColumnName("Careerid");

                    b.Property<string>("WorkDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("WorkDescription");

                    b.Property<string>("WorkName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("WorkName");

                    b.HasKey("Workid");

                    b.HasIndex("Careerid");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("Gocareer.Domain.Article", b =>
                {
                    b.HasOne("Gocareer.Domain.Career", "Career")
                        .WithMany("Articles")
                        .HasForeignKey("Careerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Career");
                });

            modelBuilder.Entity("Gocareer.Domain.Meeting", b =>
                {
                    b.HasOne("Gocareer.Domain.Especialist", "especialist")
                        .WithMany("Meetings")
                        .HasForeignKey("EspecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gocareer.Domain.Estudiante", "estudiante")
                        .WithMany("Meetings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("especialist");

                    b.Navigation("estudiante");
                });

            modelBuilder.Entity("Gocareer.Domain.Message", b =>
                {
                    b.HasOne("Gocareer.Domain.Especialist", "Especialist")
                        .WithMany("Messages")
                        .HasForeignKey("EspecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gocareer.Domain.Estudiante", "Estudiante")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialist");

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("Gocareer.Domain.Option", b =>
                {
                    b.HasOne("Gocareer.Domain.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Gocareer.Domain.Question", b =>
                {
                    b.HasOne("Gocareer.Domain.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("Testid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Gocareer.Domain.Test", b =>
                {
                    b.HasOne("Gocareer.Domain.Especialist", "Especialist")
                        .WithMany("Tests")
                        .HasForeignKey("EspecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialist");
                });

            modelBuilder.Entity("Gocareer.Domain.User_Test", b =>
                {
                    b.HasOne("Gocareer.Domain.Career", "Career")
                        .WithMany("User_Tests")
                        .HasForeignKey("Careerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gocareer.Domain.Test", "Test")
                        .WithMany("User_Tests")
                        .HasForeignKey("Testid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gocareer.Domain.Estudiante", "Estudiante")
                        .WithMany("User_Tests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Career");

                    b.Navigation("Estudiante");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Gocareer.Domain.Work", b =>
                {
                    b.HasOne("Gocareer.Domain.Career", "Career")
                        .WithMany("Works")
                        .HasForeignKey("Careerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Career");
                });

            modelBuilder.Entity("Gocareer.Domain.Career", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("User_Tests");

                    b.Navigation("Works");
                });

            modelBuilder.Entity("Gocareer.Domain.Especialist", b =>
                {
                    b.Navigation("Meetings");

                    b.Navigation("Messages");

                    b.Navigation("Tests");
                });

            modelBuilder.Entity("Gocareer.Domain.Estudiante", b =>
                {
                    b.Navigation("Meetings");

                    b.Navigation("Messages");

                    b.Navigation("User_Tests");
                });

            modelBuilder.Entity("Gocareer.Domain.Question", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("Gocareer.Domain.Test", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("User_Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
