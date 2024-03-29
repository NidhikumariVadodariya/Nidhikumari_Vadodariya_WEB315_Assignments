﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using EnvironmentalChanges.Data;

namespace EnvironmentalChanges.Migrations
{
    [DbContext(typeof(EnvironmentalChangesContext))]
    [Migration("20220220050231_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("EnvironmentalChanges.Models.EChange", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FoodInWeather")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypesOfWeather")
                        .HasColumnType("TEXT");

                    b.Property<string>("WeatherGarments")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WeatherTiming")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("EChange");
                });
#pragma warning restore 612, 618
        }
    }
}
