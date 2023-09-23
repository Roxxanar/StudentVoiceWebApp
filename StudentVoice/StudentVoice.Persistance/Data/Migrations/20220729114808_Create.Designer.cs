﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentVoice.Persistance.Data;

#nullable disable

namespace StudentVoice.Persistance.Data.Migrations
{
    [DbContext(typeof(StudentVoiceDbContext))]
    [Migration("20220729114808_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentVoice.Domain.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("NotificationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("NotificationDate");

                    b.Property<string>("NotificationName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Notification");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isSeen")
                        .HasColumnType("bit")
                        .HasColumnName("isSeen");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NotificationDate = new DateTime(2022, 7, 29, 14, 48, 7, 788, DateTimeKind.Local).AddTicks(9503),
                            NotificationName = "Question needs to be approved",
                            isSeen = false
                        },
                        new
                        {
                            Id = 2,
                            NotificationDate = new DateTime(2022, 7, 29, 14, 48, 7, 788, DateTimeKind.Local).AddTicks(9510),
                            NotificationName = "A student answered a question",
                            isSeen = true
                        },
                        new
                        {
                            Id = 3,
                            NotificationDate = new DateTime(2022, 7, 29, 14, 48, 7, 788, DateTimeKind.Local).AddTicks(9513),
                            NotificationName = "Your qustion was aproved",
                            isSeen = true
                        });
                });

            modelBuilder.Entity("StudentVoice.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SurveyId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "5",
                            QuestionName = "Please rate this class.",
                            Type = "Rating"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "I really liked the fact that this class focused more on the quality of code than the quantity",
                            QuestionName = "What is something you liked about this class?",
                            Type = "Text"
                        },
                        new
                        {
                            Id = 3,
                            Answer = "I really liked the fact that this class focused more on the quality of code than the quantity.",
                            QuestionName = "What is something you liked about this class?",
                            Type = "Text"
                        },
                        new
                        {
                            Id = 4,
                            Answer = "I don't feel like there are improvements needed.",
                            QuestionName = "What is something that we can improve about this class?",
                            Type = "Text"
                        });
                });

            modelBuilder.Entity("StudentVoice.Domain.Entities.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Class")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Class");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpirationDate");

                    b.Property<int>("Likes")
                        .HasColumnType("int")
                        .HasColumnName("Likes");

                    b.Property<string>("Professor")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Professor");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("Rating");

                    b.Property<string>("Subject")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Subject");

                    b.HasKey("Id");

                    b.ToTable("Surveys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = "I",
                            Date = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            ExpirationDate = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Likes = 34,
                            Professor = "Alex",
                            Rating = 5,
                            Subject = "Mate"
                        },
                        new
                        {
                            Id = 2,
                            Class = "II",
                            Date = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            ExpirationDate = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Likes = 23,
                            Professor = "Cosmin",
                            Rating = 4,
                            Subject = "Mate"
                        },
                        new
                        {
                            Id = 3,
                            Class = "II",
                            Date = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            ExpirationDate = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Likes = 23,
                            Professor = "Cosmin",
                            Rating = 4,
                            Subject = "Info"
                        });
                });

            modelBuilder.Entity("StudentVoice.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("LastName");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Password");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("isAdmin");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SurveyUser", b =>
                {
                    b.Property<int>("SurveysId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("SurveysId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("SurveyUser");
                });

            modelBuilder.Entity("StudentVoice.Domain.Entities.Notification", b =>
                {
                    b.HasOne("StudentVoice.Domain.Entities.User", null)
                        .WithMany("Notifications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("StudentVoice.Domain.Entities.Question", b =>
                {
                    b.HasOne("StudentVoice.Domain.Entities.Survey", null)
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId");
                });

            modelBuilder.Entity("SurveyUser", b =>
                {
                    b.HasOne("StudentVoice.Domain.Entities.Survey", null)
                        .WithMany()
                        .HasForeignKey("SurveysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentVoice.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentVoice.Domain.Entities.Survey", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("StudentVoice.Domain.Entities.User", b =>
                {
                    b.Navigation("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
