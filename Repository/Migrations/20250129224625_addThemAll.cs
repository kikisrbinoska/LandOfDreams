﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class addThemAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    DestinationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "Description", "ImageUrl", "Location", "Map", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A modern, stylish hotel with apartment-style accommodations, located in Milan's city center. It features contemporary design, comfortable rooms, and a central location close to major attractions like the Duomo Cathedral.", "/images/milano1.jpg", "Via Tiziano 22, 20145 Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2798.229472262956!2d9.186881676274089!3d45.46518117107389!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c6add329ca21%3A0xbc8a5a4db5159804!2sRoom%20Mate%20Giulia!5e0!3m2!1sen!2smk!4v1723673612683!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Residence De La Gare", 100 },
                    { 2, "A well-maintained residence offering apartment-style stays. It is situated near Milan's central train station, making it convenient for travel and close to shopping and dining options.", "/images/milano2.jpg", " Via Giulia, 9, 20123 Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2797.215077324155!2d9.2083113!3d45.4856135!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c6dca9253d2d%3A0xbf4ce19fe2a6ccb7!2sResidence%20De%20La%20Gare!5e0!3m2!1sen!2smk!4v1723676821191!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Room Mate Giulia Hotel", 200 },
                    { 3, "These loft-style apartments are known for their spacious interiors and modern design. Located in the northern part of Milan, they offer easy access to public transportation and local amenities.", "/images/milano3.jpg", "Via G. Arimondi 2, 20155 Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2797.0326530064854!2d9.154093400000008!3d45.48928720000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c10f8042e0e7%3A0x79b177f5bfddef0a!2sVia%20Giuseppe%20Arimondi%2C%202%2C%2020155%20Milano%20MI%2C%20Italy!5e0!3m2!1sen!2smk!4v1723677098697!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Milano Loft", 120 },
                    { 4, "Located near the iconic Duomo Cathedral, this residence provides luxurious, modern apartments with excellent city views. It's ideal for those wanting to stay close to Milan's main attractions.", "/images/milano4.jpg", "Via San Giovanni sul Muro 3, 20121 Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2798.1477111556983!2d9.1923139!3d45.466828299999996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c7ca97d13061%3A0xde7495e4f7dcc920!2sThe%20Corner%20Duomo%20Hotel%20%26%20SPA!5e0!3m2!1sen!2smk!4v1723677251490!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "The Corner Duomo Residence", 180 },
                    { 5, "dwedw", "/images/milano5.jpg", "Via dei Mercanti 8, 20123 Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2798.1231396168214!2d9.184554100000003!3d45.46732330000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c152b2ca3677%3A0x576d80bb10daa252!2sAntica%20Locanda%20dei%20Mercanti!5e0!3m2!1sen!2smk!4v1723677386448!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Antica Locanda dei Mercanti", 130 },
                    { 6, "edwdwde", "/images/milano6.jpg", "Via Giovanni Boccaccio 4, 20123 Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2799.2943937864425!2d9.207052899999999!3d45.443723399999996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c43b9d0207f3%3A0x9e5fbb1d1ce5970c!2sZambala%20Luxury%20Residence!5e0!3m2!1sen!2smk!4v1723677483885!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Zambala Luxury Residence", 200 },
                    { 7, "A boutique hotel with modern amenities and classic architecture, featuring a rooftop terrace with city views.", "/images/barca1.jpg", "Carrer de Pau Claris, 9, 08010 Barcelona", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2992.98307143915!2d2.1621006!3d41.396173999999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a2947df82f27%3A0xcae8ef447300ba23!2sH10%20Casa%20Mimosa!5e0!3m2!1sen!2smk!4v1723677642072!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "H10 Casa Mimosa", 250 },
                    { 8, "Stylish, well-equipped apartments providing a home-like atmosphere in various central locations.", "/images/barca2.jpg", "Various locations throughout Barcelona (e.g., Eixample, Gracia)", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.9471198177685!2d2.1672919!3d41.375233599999994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a25c2d066cbb%3A0x35fd5ec2b4268cf6!2sStay%20Together%20Barcelona%20Apartments!5e0!3m2!1sen!2smk!4v1723677768751!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Stay Together Barcelona Apartments", 100 },
                    { 9, "Modern apartments with spacious layouts and a small kitchen, located in the Eixample district.", "/images/barca3.jpg", "Carrer de Diputació, 196, 08011 Barcelona", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2992.7084845584122!2d2.1511219!3d41.4021368!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a2a21345506d%3A0x9bcce30640503e7c!2sAparthotel%20Silver%20Barcelona!5e0!3m2!1sen!2smk!4v1723677863310!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Aparthotel Silver", 150 },
                    { 10, "Contemporary apartments with sleek furnishings, centrally located for easy access to major attractions.", "/images/barca4.jpg", "Carrer de Pau Claris, 98, 08009 Barcelona", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d45302896.18287459!2d-37.08223029999999!3d46.129448499999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x48761b0726c46b99%3A0xce4e32c23010ae8d!2sSonder%20The%20Voyage!5e0!3m2!1sen!2smk!4v1723677982726!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Sonder — The Cadet", 200 },
                    { 11, "Comfortable apartments close to shops and restaurants, offering easy access to the heart of Barcelona.", "/images/barca5.jpg", "Rambla de Catalunya, 50, 08007 Barcelona", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.1146708188335!2d2.1601369999999993!3d41.393316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a2f480a2cf7b%3A0xa70f62907353263a!2sBCN%20Rambla%20Catalunya%20Apartments!5e0!3m2!1sen!2smk!4v1723678084077!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "BCN Rambla Catalunya Apartments", 130 },
                    { 12, "Luxury apartments on the iconic Passeig de Gràcia, featuring high-end amenities and stylish interiors.", "/images/barca6.jpg", "Passeig de Gràcia, 114, 08008 Barcelona", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.1810202362276!2d2.1660281000000094!3d41.391875000000006!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a3ce7e33ffdd%3A0xdf7066a67aa15636!2sYou%20Stylish%20Paseo%20de%20Gracia%20Apartments!5e0!3m2!1sen!2smk!4v1723678182110!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "You Stylish The Paseo de Gracia Apartments", 300 },
                    { 13, "Luxury accommodations with stunning sea views, elegant design, and exclusive services.", "/images/dubrovnik1.jpg", "Ul. Vatroslava Lisinskog 2, 20000 Dubrovnik", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2935.0173660889136!2d18.120425296789534!3d42.63979179999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134c0bb425e02fa9%3A0xe8cfd0650ead9423!2sVilla%20Dubrovnik%20Palace!5e0!3m2!1sen!2smk!4v1723678258524!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Villa Dubrovnik", 500 },
                    { 14, "Well-equipped apartments offering modern comforts in a convenient location.", "/images/dubrovnik2.jpg", "Šipanska 10, 20000 Dubrovnik", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2934.939370365117!2d18.10659067503395!3d42.641445271168024!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134c0b32ee1b14df%3A0x71b17e45ea9bbc57!2sApartments%20More%20Dubrovnik!5e0!3m2!1sen!2smk!4v1723678286254!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Apartments More Dubrovnik", 150 },
                    { 15, "Charming apartments with easy access to historic sites and local attractions.", "/images/dubrovnik3.jpg", "Various locations within the Old Town, Dubrovnik", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2935.003158395785!2d18.103660296789553!3d42.64009300000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134c0bde421ef1f5%3A0xda417a58631cecad!2sHistorical%20old%20town%20apartments!5e0!3m2!1sen!2smk!4v1723678326229!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Dubrovnik Old Town Apartments", 150 },
                    { 16, "A boutique hotel offering apartment-style accommodations with historic charm and modern amenities.", "/images/dubrovnik4.jpg", "Od Sigurate 4, 20000 Dubrovnik", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2934.985782108515!2d18.10717257503394!3d42.64046137116822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134c0b325692b4ad%3A0x6f3c768a3aff5463!2sThe%20Pucic%20Palace!5e0!3m2!1sen!2smk!4v1723678348395!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "The Pucic Palace", 250 },
                    { 17, " Comfortable and modern apartments with a relaxed atmosphere.", "/images/dubrovnik5.jpg", "Put od Bosanke 12, 20000 Dubrovnik", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2934.7365051797387!2d18.09619737503431!3d42.64574567116781!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134c74d4d8b27ff9%3A0x1831a770a7ac65ea!2sVilla%20Elly!5e0!3m2!1sen!2smk!4v1723678378469!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Apartments Villa Elly", 120 },
                    { 18, "Simple and well-maintained apartments with a convenient location.", "/images/dubrovnik6.jpg", "Iva Vojnovića 3, 20000 Dubrovnik", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2934.9259216943437!2d18.102601975034048!3d42.64173037116812!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134c0b2d0f2d2829%3A0xba1bb3b99fdef3da!2sMir%C3%93%20Studio%20Apartments!5e0!3m2!1sen!2smk!4v1723678401062!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Apartments and Rooms Miro", 100 },
                    { 19, "Elegant resort with luxurious amenities, including a spa and stunning views.", "/images/mykonos1.jpg", "Platis Gialos, 84600 Mykonos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3168.915802066544!2d25.340777074689928!3d37.41546497207814!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2be929e20fe91%3A0xcfef125ea790f219!2sMyconian%20Ambassador%20Relais%20%26%20Chateaux!5e0!3m2!1sen!2smk!4v1723678447052!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Myconian Ambassador Relais & Châteaux", 400 },
                    { 20, "Centrally located suites offering modern comforts and easy access to the town's attractions.", "/images/mykonos2.jpg", "Mykonos Town, 84600 Mykonos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3167.7981094259303!2d25.324871274691645!3d37.441873872071085!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2bfab107f1a27%3A0xa0b16e4dee356ce7!2sPoseidon%20Hotel%20Suites!5e0!3m2!1sen!2smk!4v1723678468024!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Poseidon Hotel Suites", 200 },
                    { 21, "High-end resort with beachfront access and luxury amenities.", "/images/mykonos3.jpg", "Psarou Beach, 84600 Mykonos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3168.8720828041205!2d25.336514374690132!3d37.41649827207789!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2be8c877fa06d%3A0x897a38c6e3212e1a!2sGrecotel%20Mykonos%20Blu!5e0!3m2!1sen!2smk!4v1723678494843!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Mykonos Blu Grecotel Exclusive Resort", 500 },
                    { 22, "Boutique resort featuring stylish suites and beautiful views of the Aegean Sea.", "/images/mykonos4.jpg", "Agios Ioannis, 84600 Mykonos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3168.5715796614454!2d25.305660074690543!3d37.42359997207598!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2be6ab8043f81%3A0x4a6a951f84a9aa82!2sKatikies%20Mykonos!5e0!3m2!1sen!2smk!4v1723678519246!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Katikies Mykonos", 350 },
                    { 23, "Boutique hotel offering luxurious accommodations with stunning views and modern amenities.", "/images/mykonos5.jpg", "Agios Ioannis, 84600 Mykonos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3168.9442002068404!2d25.338302774689932!3d37.41479377207828!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2be8d07f56f2f%3A0xc3751bfc6a119de8!2sNissaki%20Boutique%20Hotel!5e0!3m2!1sen!2smk!4v1723678545753!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n\r\n", "Nissaki Boutique Hotel", 250 },
                    { 24, "Upscale hotel with chic design, excellent service, and a central location.", "/images/mykonos6.jpg", "Mykonos Town, 84600 Mykonos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3167.736087149603!2d25.327555574691807!3d37.443338872070804!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2bf00b29dc8e3%3A0x99c09424d6e03ef!2sBelvedere%20Hotel%20Mykonos%20-%20The%20Leading%20Hotels%20of%20the%20World!5e0!3m2!1sen!2smk!4v1723678569632!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Belvedere Hotel Mykonos", 300 },
                    { 25, "Elegant hotel with modern amenities and a central location in Porto's historic area.", "/images/porto1.jpg", "Rua das Flores, 27, 4050-263 Porto", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3004.613606663221!2d-8.617497325068458!3d41.142960271332!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd2464e1ecc6bfcf%3A0x1cd70394ff384bb0!2sPorto%20A.S.%201829%20Hotel!5e0!3m2!1sen!2smk!4v1723678631792!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Porto A.S. 1829 Hotel", 150 },
                    { 26, "Stylish hotel with a spa, offering a blend of historic charm and modern comfort.", "/images/porto2.jpg", "Rua das Flores, 139, 4050-265 Porto", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3004.5459996298327!2d-8.615574825068304!3d41.14443587133177!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd2464e3d14e045d%3A0x2989540fa049f236!2sFlores%20Boutique%20Hotel%20%26%20SPA!5e0!3m2!1sen!2smk!4v1723678653221!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Flores Village Hotel & Spa", 180 },
                    { 27, "Comfortable and well-located apartments providing a home-like atmosphere.", "/images/porto3.jpg", "6 Rue de la Buffa, 06000 Nice", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3004.423288414823!2d-8.599143525068175!3d41.14711407133139!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd2464ecf75da221%3A0x38cb6705cf730457!2smyhomeinporto!5e0!3m2!1sen!2smk!4v1723678685115!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "My Home in Porto", 120 },
                    { 28, "Modern apartments with convenient access to local attractions and amenities.", "/images/porto4.jpg", "Avenida da Boavista, 1283, 4100-130 Porto", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12018.331835385821!2d-8.632301112841766!3d41.14362920000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd246539cfd0b033%3A0x4fc5ca921b9c8116!2sOporto%20Collection%20Mouzinho%20da%20Silveira%20Apartments!5e0!3m2!1sen!2smk!4v1723678720020!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Oporto Collection Boavista Apartments", 130 },
                    { 29, "Simple and well-maintained apartments in a central location.", "/images/porto5.jpg", "Rua do Heroísmo, 256, 4300-259 Porto", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d384559.49875812186!2d-8.915901043749985!3d41.148253400000016!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd24649104247dab%3A0xd8729ca13df40f9f!2sHotel%20Poveira!5e0!3m2!1sen!2smk!4v1723678758243!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Poveira Apartments", 100 },
                    { 30, "Spacious duplex apartments with modern decor and central access.", "/images/porto6.jpg", "Rua da Alegria, 430, 4000-037 Porto", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12017.782049079162!2d-8.61881765322764!3d41.146629041298276!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd2464e5624f5127%3A0x5b5c86b14a05f570!2sDuplex%20Downtown!5e0!3m2!1sen!2smk!4v1723678787666!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Porto Downtown Duplex", 150 },
                    { 31, "Affordable resort with a range of amenities and easy access to the beach.", "/images/hurghada1.jpg", "El Mamsha El Seyahi, Hurghada", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3544.7204000052693!2d33.69901617413745!3d27.321937776405605!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14526514f21f11cb%3A0x9b39a394cd34a95f!2sTiba%20Resort!5e0!3m2!1sen!2smk!4v1723678818759!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Tiba Resort", 60 },
                    { 32, "Resort offering beachfront access, multiple dining options, and a spa.", "/images/hurghada2.jpg", "Village Road, Hurghada", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3547.159476887567!2d33.8410272741339!3d27.245527276450332!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14528632ec2b1c13%3A0x8df201a628dbfe35!2sSunny%20Days%20Palma%20De%20Mirette%20Resort%20%26%20SPA!5e0!3m2!1sen!2smk!4v1723678838513!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Sunny Days Palma De Mirette Resort & Spa", 80 },
                    { 33, " Family-friendly resort with a private beach, swimming pools, and various activities.", "/images/hurghada3.jpg", "Sheraton Road, Hurghada", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3547.324648840161!2d33.84147607413366!3d27.240345676453423!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287ef8202025d%3A0x50c76277c8a88d29!2sArabia%20Azur%20Resort!5e0!3m2!1sen!2smk!4v1723678866874!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n\r\n", "Arabia Azur Resort", 70 },
                    { 34, "Well-located apartments with views of the marina and convenient access to local amenities.", "/images/hurghada4.jpg", "New Marina, Hurghada", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3613.6650121649977!2d55.141852874036076!3d25.079340677787027!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3e5f6bf7d26f1133%3A0xbc6b4935cf792945!2sMarina%20View%20Hotel%20Apartments!5e0!3m2!1sen!2smk!4v1723678892721!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Marina View Apartments", 90 },
                    { 35, "Resort featuring a water park, private beach, and numerous facilities for families", "/images/hurghada5.jpg", "Sahl Hasheesh Road, Hurghada", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3546.8702604958457!2d33.83250107413427!3d27.25459807644501!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287d11fb82099%3A0xb1ab3518f57befc5!2sSphinx%20Aqua%20Park%20Resort!5e0!3m2!1sen!2smk!4v1723678919805!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Sphinx Aqua Park Beach Resort", 100 },
                    { 36, "Basic but comfortable apartments with convenient access to local shops and restaurants.", "/images/hurghada6.jpg", "Al Ahyaa Area, Hurghada", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14189.074805902372!2d33.821563387158214!3d27.2421009!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287f3963a4737%3A0x3577a73e4cbf8b1e!2sApartments%20on%20the%20Red%20Sea%20in%20Hurghada!5e0!3m2!1sen!2smk!4v1723678942299!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Red Sea Apartments", 50 },
                    { 37, "Well-maintained apartments near the beach, offering modern amenities and great views.", "/images/skiathos1.jpg", "Vassilias Beach, 37002 Skiathos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d787070.756399611!2d22.81448540337543!3d39.593527211570276!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a6de04e1ce0e05%3A0x5ed2ebe91101bb28!2sKassandra%20Bay%20Resort%2C%20Suites%20%26%20Spa!5e0!3m2!1sen!2smk!4v1723679019378!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Kassandra Bay Apartments", 120 },
                    { 38, " Cozy apartments in the heart of Skiathos Town, ideal for exploring local attractions", "/images/skiathos2.jpg", "Skiathos Town, 37002 Skiathos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d787370.4024785722!2d22.414227570705425!3d39.56714628939426!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a6e7508ab788ff%3A0xc5bd1e861989382f!2sKALLISTI%20APARTMENTS!5e0!3m2!1sen!2smk!4v1723679040381!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Kallisti Apartments", 80 },
                    { 39, "Upscale apartments with luxurious furnishings and central location.", "/images/skiathos3.jpg", "Skiathos Town, 37002 Skiathos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d49494.224977305224!2d23.424155606693716!3d39.16587514661218!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a6e7dc23446357%3A0xb02d4cebd5648e03!2sSkiathos%20Ammos%20Luxury%20Apartments!5e0!3m2!1sen!2smk!4v1723679070125!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Skiathos Luxury Apartments", 150 },
                    { 40, "Simple and charming apartments offering a traditional Greek experience in a central location.", "/images/skiathos4.jpg", null, "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1619230.9776850075!2d20.355825156250003!3d37.56541720000005!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x149ffa963bc8a13d%3A0x5660abecb81bc644!2sPension%20Eleni!5e0!3m2!1sen!2smk!4v1723679101283!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Skiathos Town, 37002 Skiathos", 70 },
                    { 41, "Comfortable and well-equipped apartments with a relaxed atmosphere.", "/images/skiathos5.jpg", "Skiathos Town, 37002 Skiathos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1613255.9701453827!2d18.342221956250008!3d37.8394477!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1367414332a885b5%3A0x13c9e745aef94031!2sVilla%20Mantalena!5e0!3m2!1sen!2smk!4v1723679124354!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Villa Mantalena", 90 },
                    { 42, "raditional studios with a homey feel, located close to the town's amenities.", "/images/skiathos6.jpg", "Skopelos Town, 37003 Skopelos", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3214462.355552918!2d15.760206812500007!3d38.114063599999994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1367618d028bc265%3A0x775fee3ef1101734!2sAgnanti%20Studios%20Kefalonia!5e0!3m2!1sen!2smk!4v1723679154860!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Agnanti Studios", 85 },
                    { 43, "Modern aparthotel with fully equipped apartments and beachfront access.", "/images/nice1.jpg", "217 Promenade des Anglais, 06200 Nice", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2885.0904581440545!2d7.2366279751072895!3d43.68788277110044!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cdd04371fa42b7%3A0xbcfbc2f9dd7557be!2sAparthotel%20Adagio%20Nice%20Promenade%20des%20Anglais!5e0!3m2!1sen!2smk!4v1723679204086!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Aparthotel Adagio Nice Promenade des Anglais", 150 },
                    { 44, "Well-located apartments offering a comfortable stay near the city center.", "/images/nice2.jpg", "6 Rue de la Buffa, 06000 Nice", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2884.6582074274997!2d7.271957375107941!3d43.69686867110008!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cddaa314854c37%3A0x19a8729bf931290!2sMaster%20Home%20Nice!5e0!3m2!1sen!2smk!4v1723679268272!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Nice Home", 120 },
                    { 45, "Cozy and modern apartments in a central location, ideal for exploring Nice", "/images/nice3.jpg", "7 Rue Gounod, 06000 Nice", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11537.909286750506!2d7.241377387158191!3d43.70062860000003!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cdd00955a8352b%3A0x12f6d83f209491e6!2sH%C3%B4tel%20Gounod%20Nice!5e0!3m2!1sen!2smk!4v1723679326307!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Apartments Gounod", 100 },
                    { 46, "Charming apartments with a traditional feel, located near the main attractions", "/images/nice4.jpg", "5 Rue d'Italie, 06000 Nice", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2815.634556326793!2d3.7407747752093963!3d45.11347557107038!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47f60846457f136b%3A0x5afc1d2acf46ab7f!2sLa%20Maison%20de%20Lili!5e0!3m2!1sen!2smk!4v1723679372627!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "La Maison de Lili", 110 },
                    { 47, "Comfortable apartments with easy access to the beach and city center.", "/images/nice4.jpg", "6 Rue Sacha Guitry, 06000 Nice", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2884.5620250116654!2d7.267737975108038!3d43.69886797109996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cddaa6afbd6da1%3A0xc2c0c5e268a8c978!2sHostel%20Villa%20Saint%20Exupery%20Beach!5e0!3m2!1sen!2smk!4v1723679392553!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Villa Saint Exupery Beach", 130 },
                    { 48, " Elegant apartments with modern amenities in a central location.", "/images/nice6.jpg", "2 Rue du Maréchal Joffre, 06000 Nice", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d92314.13585531755!2d7.125042910775678!3d43.69357305358704!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cddaea01695675%3A0xdcd29dee6c333dfe!2sLe%20Saint%20Paul!5e0!3m2!1sen!2smk!4v1723679435002!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Le Saint Paul", 140 },
                    { 49, "Modern apartments with a pool and easy access to the beach and Budva's Old Town.", "/images/nice6.jpg", "Jadranski Put bb, 85310 Budva", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2951.45666664472!2d18.8468068!3d42.2901203!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd482531feb7d%3A0xeb4c2c2937644271!2sVilla%20NS%20Velji%20Vinogradi!5e0!3m2!1sen!2smk!4v1723716574425!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Aparthotel Villa Jovan", 100 },
                    { 50, "Centrally located hotel with well-furnished apartments, offering views of the Adriatic Sea and a short walk to local attractions.", "/images/nice6.jpg", "Slovenska Obala bb, 85310 Budva", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11807.141169781542!2d18.82962056977538!3d42.2831064!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd4851cbc650f%3A0xe9fd13311d68bca3!2sHotel%20Budva!5e0!3m2!1sen!2smk!4v1723716652849!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Budva", 120 },
                    { 51, "Comfortable and stylish apartments near the beach, with modern amenities and a convenient location.", "/images/nice6.jpg", "Slovenska Plaža, 85310 Budva", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2955.325749996519!2d18.9392267!3d42.207482!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd741c944d8ad%3A0x68307da75b8d00f9!2sApartments%20Lux!5e0!3m2!1sen!2smk!4v1723716703316!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Apartments Lux", 80 },
                    { 52, "Spacious apartments with modern decor and amenities, situated a short drive from the beach and Old Town.", "/images/nice6.jpg", "Vuka Karadžića 2, 85310 Budva", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2951.7151564608307!2d18.8340115!3d42.284603399999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd5bb6acdcc07%3A0x47d1dcadd658922b!2sHotel%20Pima!5e0!3m2!1sen!2smk!4v1723716799953!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Pima Apartments", 90 },
                    { 53, "Spacious apartments with modern decor and amenities, situated a short drive from the beach and Old Town.", "/images/nice6.jpg", "Cuca, 85310 Budva", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2951.9138557958363!2d18.835509199999997!3d42.28036220000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd4942893dcc1%3A0xb8e05f0254fbe74a!2s%22Alex%20Apartments%22%20Budva%2C%20center!5e0!3m2!1sen!2smk!4v1723716838127!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Apartments Alex", 90 },
                    { 54, "Simple and comfortable apartments offering a relaxed stay, with easy access to local beaches and the city center.", "/images/nice6.jpg", "Zavala bb, 85310 Budva", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3030629.522227602!2d16.837842962500005!3d42.1160552!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134e77770a58b239%3A0x6bc32509bfe7bda7!2sApartmani%20Sunce!5e0!3m2!1sen!2smk!4v1723716878244!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Apartments Sunce", 60 }
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "/images/milano.jpg", "Milan" },
                    { 2, "/images/barca.jpg", "Barcelona" },
                    { 3, "/images/dubrovnik.jpg", "Dubrovnik" },
                    { 4, "/images/mykonos.jpg", "Mykonos" },
                    { 5, "/images/hurghada.jpg", "Hurghada" },
                    { 6, "/images/skiathos.jpg", "Skiathos" },
                    { 7, "/images/scopelos.jpg", "Skopelos" },
                    { 8, "/images/nice.jpg", "Nice" },
                    { 9, "/images/budva.jpg", "Budva" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Description", "ImageUrl", "Location", "Map", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A modern boutique hotel located just steps from Milan's iconic Duomo Cathedral. It offers stylish rooms with contemporary decor, a rich breakfast buffet, and complimentary Wi-Fi. The hotel is well-known for its personalized service and proximity to major attractions.", "/images/milanoh1.jpg", "Via Spadari 11, Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2798.309000944234!2d9.184334275234898!3d45.463578971074!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c6ac7b52ab0f%3A0xd7d6941943804528!2sHotel%20Spadari%20Al%20Duomo!5e0!3m2!1sen!2smk!4v1723759614403!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Spadari al Duomo", 350 },
                    { 2, "A luxury hotel situated in a historic building with elegant interiors and luxurious amenities. It features a rooftop spa, gourmet dining options, and spacious rooms with classic decor. The hotel is centrally located, making it ideal for exploring Milan's shopping and cultural districts.", "/images/milanoh2.jpg", "Piazza della Repubblica 17, Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2797.503472130496!2d9.194088575236039!3d45.47980527107422!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c6c918d541a1%3A0x484a659b230ae38!2sPrincipe%20di%20Savoia!5e0!3m2!1sen!2smk!4v1723759705436!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Principe di Savoia", 500 },
                    { 3, "This upscale hotel is located in a central area close to Milan’s main shopping streets and cultural attractions. It offers modern rooms with sleek designs, a well-equipped fitness center, and a delicious breakfast buffet. The NH Collection Milano President is known for its excellent location and high-quality service.", "/images/milanoh3.jpg", "Largo Augusto 10, Milan, Italy", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2798.332181092971!2d9.195147075234836!3d45.46311197107388!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4786c6a5cb03ffdd%3A0x6e81cbc0fd9d0b6f!2sHotel%20NH%20Collection%20Milano%20President!5e0!3m2!1sen!2smk!4v1723759767058!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel NH Collection Milano President", 300 },
                    { 4, "A luxury hotel located near Barcelona's beach and marina. It offers stunning views of the city and Mediterranean Sea, an outdoor pool, a spa, and several dining options. Known for its high-end amenities and exceptional service.", "/images/barcah1.jpg", "Carrer de la Marina 19-21, Barcelona, Spain", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.4028616581077!2d2.1938457749480405!3d41.387056671299845!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a30f13665d1b%3A0xff3ebc6ba79f4055!2sHotel%20Arts%20Barcelona!5e0!3m2!1sen!2smk!4v1723761384604!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Arts Barcelona", 450 },
                    { 5, "An iconic hotel with a distinctive sail-like design, located right on the beachfront. It features stylish rooms with ocean views, a rooftop bar, a large outdoor pool, and a lively atmosphere. Ideal for both relaxation and nightlife.", "/images/barcah2.jpg", "Plaça Rosa dels Vents, 1, Barcelona, Spain", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2994.259935182437!2d2.187578474946793!3d41.36843697130227!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a3b185625025%3A0x59e80c780f7e2f0b!2sW%20Barcelona!5e0!3m2!1sen!2smk!4v1723761443381!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe", "W Barcelona", 400 },
                    { 6, "A luxury hotel situated in the heart of Barcelona's shopping and business district. It boasts elegant rooms, a beautiful garden, a wellness center, and fine dining options. Known for its sophisticated atmosphere and excellent location.", "/images/barcah3.jpg", "Avinguda de Diagonal 686, Barcelona, Spain", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.6617795491757!2d2.106302774947639!3d41.381432471300535!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a499c4f4fd0721%3A0x53824ac116e9950e!2sTorre%20Melina%2C%20a%20Gran%20Meli%C3%A1%20Hotel!5e0!3m2!1sen!2smk!4v1723761496556!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Gran Melia Barcelona", 350 },
                    { 7, "A luxury hotel with stunning views of the Adriatic Sea and Dubrovnik's Old Town. It features elegant rooms, a private beach, a spa, and gourmet dining options. Renowned for its prime location and exceptional service.", "/images/dubrovnikh1.jpg", "Frana Supila 12, Dubrovnik, Croatia", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.6617795491757!2d2.106302774947639!3d41.381432471300535!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a499c4f4fd0721%3A0x53824ac116e9950e!2sTorre%20Melina%2C%20a%20Gran%20Meli%C3%A1%20Hotel!5e0!3m2!1sen!2smk!4v1723761496556!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Excelsior Dubrovnik", 400 },
                    { 8, "A chic, cliffside hotel offering breathtaking views of the sea and Old Town. It has modern rooms, an indoor pool, a wellness center, and a restaurant with panoramic views. Ideal for a luxurious stay in Dubrovnik.", "/images/dubrovnikh2.jpg", "Pera Cingrije 7, Dubrovnik, Croatia", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.6617795491757!2d2.106302774947639!3d41.381432471300535!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a499c4f4fd0721%3A0x53824ac116e9950e!2sTorre%20Melina%2C%20a%20Gran%20Meli%C3%A1%20Hotel!5e0!3m2!1sen!2smk!4v1723761496556!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Bellevue Dubrovnik", 350 },
                    { 9, "Situated on a peninsula with panoramic sea views, this upscale hotel features stylish rooms, multiple outdoor pools, a private beach, and several dining options. Known for its tranquil setting and high-quality amenities.", "/images/dubrovnikh3.jpg", "Masarykov put 20, Dubrovnik, Croatia", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2934.4763942787586!2d18.05844797503473!3d42.65125907116725!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134c754d4a158ff5%3A0x7e813fe8ddd2a93e!2sHotel%20Dubrovnik%20Palace!5e0!3m2!1sen!2smk!4v1723759965901!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Hotel Dubrovnik Palace", 300 },
                    { 10, "A luxurious hotel offering stunning views of the Aegean Sea and Mykonos Town. It features chic, modern rooms, an infinity pool, a renowned spa, and upscale dining options. Known for its elegant design and exceptional service.", "/images/mykonosh1.jpg", "Tagoo, Mykonos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3167.1696623599787!2d25.32629927469259!3d37.456715872067306!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2bfa0b569a3c1%3A0x26b4d286167def83!2sCavo%20Tagoo%20Mykonos!5e0!3m2!1sen!2smk!4v1723760014920!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Cavo Tagoo Mykonos", 550 },
                    { 11, "An iconic hotel located in the picturesque village of Oia. It boasts traditional Cycladic architecture, private balconies with sea views, multiple infinity pools, and a fine dining restaurant. Famous for its romantic atmosphere and exclusive experience.", "/images/mykonosh2.jpg", "Oia, Mykonos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d50697.14525567625!2d25.23201734863281!3d37.4236!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2be6ab8043f81%3A0x4a6a951f84a9aa82!2sKatikies%20Mykonos!5e0!3m2!1sen!2smk!4v1723760101633!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Katikies Hotel", 600 },
                    { 12, "A luxurious resort set on Elia Beach, offering spacious villas with private pools, stunning sea views, and modern amenities. The hotel features a spa, gourmet dining options, and direct access to the beach. Known for its serene environment and high-end accommodations.", "/images/mykonosh3.jpg", "Elia Beach, Mykonos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3168.629714782288!2d25.392356274690385!3d37.422226172076265!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a2b9265cf62563%3A0x6994e60a816e350!2sMyconian%20Villa%20Collection!5e0!3m2!1sen!2smk!4v1723760158487!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Myconian Villa Collection", 400 },
                    { 13, "A luxury beachfront hotel offering spacious rooms with sea views, a private beach, multiple swimming pools, and a variety of dining options. Known for its elegant design and comprehensive amenities, including a spa and entertainment options.", "/images/hurghadah1.jpg", "Sheraton Road, Hurghada, Egypt", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3549.7461894859252!2d33.8219737741301!3d27.164274876498137!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287e44ac6b045%3A0xf91506287bc8354d!2sSteigenberger%20ALDAU%20Beach%20Hotel!5e0!3m2!1sen!2smk!4v1723760449143!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Steigenberger Aldau Beach Hotel", 250 },
                    { 14, "An all-inclusive resort with stunning Red Sea views, luxurious rooms, a private beach, and several restaurants and bars. Features include a large outdoor pool, a spa, and a range of recreational activities. Renowned for its opulent surroundings and high-quality service.", "/images/hurghadah2.jpg", "Sahl Hasheesh, Hurghada, Egypt", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3552.537234682686!2d33.8794867741259!3d27.07635147654994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d7e00ff65d44d%3A0xab9d3f015b933dc3!2sThe%20Oberoi%20Beach%20Resort%2C%20Sahl%20Hasheesh!5e0!3m2!1sen!2smk!4v1723760263879!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Baron Palace Sahl Hasheesh", 300 },
                    { 15, "A high-end resort offering a blend of modern luxury and traditional Egyptian design. It features private villas with pools, a pristine beach, an extensive spa, and gourmet dining. Known for its exceptional service, tranquility, and exclusive experience.", "/images/milanoh1.jpg", "Sahl Hasheesh, Hurghada, Egypt", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.6617795491757!2d2.106302774947639!3d41.381432471300535!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a499c4f4fd0721%3A0x53824ac116e9950e!2sTorre%20Melina%2C%20a%20Gran%20Meli%C3%A1%20Hotel!5e0!3m2!1sen!2smk!4v1723761496556!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "The Oberoi Beach Resort, Sahl Hasheesh", 350 },
                    { 16, "A luxury resort located near the famous Koukounaries Beach. It offers stylish rooms, beautiful sea views, several swimming pools, and a range of dining options. Known for its family-friendly atmosphere and high-quality amenities.", "/images/skiathosh1.jpg", "Koukounaries Beach, Skiathos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3549.7461894859252!2d33.8219737741301!3d27.164274876498137!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287e44ac6b045%3A0xf91506287bc8354d!2sSteigenberger%20ALDAU%20Beach%20Hotel!5e0!3m2!1sen!2smk!4v1723760201758!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Skiathos Princess Resort", 250 },
                    { 17, "An upscale resort set on a hillside overlooking Koukounaries Beach. It features modern rooms and suites, multiple outdoor pools, a spa, and fine dining restaurants. Renowned for its elegant design, exceptional service, and breathtaking views.", "/images/skiathosh3.jpg", "Koukounaries Beach, Skiathos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3554.0166952670857!2d33.88163567412378!3d27.02963837657763!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d7f28d9990089%3A0x6de07ae99577b926!2sBaron%20Palace%20Sahl%20Hasheesh!5e0!3m2!1sen!2smk!4v1723760240588!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Elivi Skiathos", 300 },
                    { 18, "A charming boutique hotel located near the picturesque Mandraki village. It offers comfortable rooms, a beautiful garden, a swimming pool, and a cozy restaurant. Known for its warm hospitality and tranquil setting, ideal for a relaxing stay.", "/images/skiathosh3.jpg", "Mandraki, Skiathos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3093.987955874065!2d23.404528774800198!3d39.152255571670786!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a6dfbfdb319cf3%3A0x3487fbb84e5c88e2!2sMandraki%20Village%20boutique%20hotel!5e0!3m2!1sen!2smk!4v1723760374185!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Mandraki Village Boutique Hotel", 200 },
                    { 19, "A charming hotel located in Skopelos Town, offering comfortable rooms with traditional decor. The hotel features a beautiful garden, a swimming pool, and a cozy breakfast area. Known for its friendly atmosphere and convenient location close to local shops and restaurants.", "/images/scopelosh1.jpg", "Skopelos Town, Skopelos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3095.410904849753!2d23.736491774798026!3d39.119880071677386!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a6ea959738da71%3A0xd0a987a127a40143!2sSkopelos%20Village%20Hotel!5e0!3m2!1sen!2smk!4v1723760750992!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Skopelos Village Hotel", 180 },
                    { 20, "An elegant hotel situated near the picturesque Panormos Beach. It offers modern rooms with sea or garden views, an outdoor pool, and a restaurant serving Greek cuisine. Renowned for its serene setting and high-quality service, perfect for a relaxing getaway.", "/images/skopelosh2.jpg", "Panormos Beach, Skopelos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6466372.1162703745!2d23.649951549029808!3d37.68661001355899!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14dfcfe7a8539419%3A0x2b3e1ff4c5f46ea5!2sAsterias%20Beach%20Hotel!5e0!3m2!1sen!2smk!4v1723760786200!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Asterias Hotel", 200 },
                    { 21, "A seaside hotel located on the tranquil Adrina Beach. It features spacious rooms with stunning sea views, a large outdoor pool, and a beachfront restaurant. Known for its beautiful location and excellent facilities, ideal for a peaceful vacation.", "/images/skopelosh3.jpg", "Adrina Beach, Skopelos, Greece", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3095.703371311484!2d23.651678374797594!3d39.113222971678724!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a6c20f9f4ca9b5%3A0x62be89779a7db031!2sADRINA%20BEACH%20HOTEL!5e0!3m2!1sen!2smk!4v1723760828120!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n", "Adrina Beach Hotel", 220 },
                    { 22, "An iconic luxury hotel located on the Promenade des Anglais. It offers opulent rooms and suites with sea views, a private beach, a gourmet restaurant, and a renowned art collection. Famous for its historic charm and exceptional service.", "/images/niceh1.jpg", "37 Promenade des Anglais, Nice, France", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2884.7696164598474!2d7.2557547751077704!3d43.69455277110015!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cdd183ed3530b7%3A0x108ac11e62bcbbe4!2sLe%20Negresco!5e0!3m2!1sen!2smk!4v1723760873872!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Negresco Hotel", 550 },
                    { 23, "A luxurious hotel situated on the Promenade des Anglais, featuring elegant rooms with sea or city views, an outdoor pool, a casino, and fine dining options. Known for its sophisticated atmosphere and prime location.", "/images/niceh2.jpg", "13 Promenade des Anglais, Nice, France", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2884.6019070078255!2d7.269629575108015!3d43.69803897110004!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cddaa3f181b645%3A0x6deb0a3f5809ae66!2sH%C3%B4tel%20Aston%20La%20Scala%20Nice!5e0!3m2!1sen!2smk!4v1723760973094!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe> ", "Hyatt Regency Nice Palais de la Méditerranée", 400 },
                    { 24, "A stylish hotel located in the heart of Nice, close to the Old Town and Place Masséna. It offers modern rooms, a rooftop terrace with panoramic views, a swimming pool, and a restaurant. Renowned for its central location and comfortable accommodations.", "/images/niceh3.jpg", "12 Avenue Felix Faure, Nice, France", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2884.7336528173932!2d7.260430975107789!3d43.695300371100075!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12cdd00ac353db21%3A0x68db894d7d179001!2sHyatt%20Regency%20Nice%20Palais%20de%20la%20M%C3%A9diterran%C3%A9e!5e0!3m2!1sen!2smk!4v1723760937947!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Aston La Scala", 250 },
                    { 25, "A luxury resort located on the Slovenska Plaža beachfront, offering elegant rooms with sea views, multiple swimming pools, a spa, and a variety of dining options. Known for its upscale amenities and prime location near Budva's Old Town.", "/images/budvah1.jpg", "Slovenska Plaža, Budva, Montenegro", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2951.9981678265217!2d18.832612575008877!3d42.27856247120056!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd4973aa086cb%3A0xa2a7d0fde2a1eac6!2sAvala%20Resort%20%26%20Villas!5e0!3m2!1sen!2smk!4v1723761027319!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Avala Resort & Villas", 250 },
                    { 26, "A beachfront hotel with direct access to a sandy beach, featuring spacious rooms, a large outdoor pool, a wellness center, and several restaurants. Renowned for its relaxed atmosphere and comprehensive facilities, ideal for a seaside vacation.", "/images/budvah2.jpg", "Ive Lole Ribara 36, Budva, Montenegro", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2951.8465217518574!2d18.85973637500913!3d42.28179947120031!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd47b6a4a2d09%3A0x2bdec91bd5b45050!2sHotel%20Montenegro%20Beach%20Resort!5e0!3m2!1sen!2smk!4v1723761075783!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Montenegro Beach Resort", 200 },
                    { 27, "A modern hotel located near the beach and Budva's Old Town, offering comfortable rooms, a large outdoor pool, and a restaurant with local cuisine. Known for its convenient location and friendly service, suitable for both relaxation and exploration.", "/images/budvah3.jpg", "Slovenska Plaža, Budva, Montenegro", "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11807.141169781542!2d18.819320887158206!3d42.2831064!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x134dd4851cbc650f%3A0xe9fd13311d68bca3!2sHotel%20Budva!5e0!3m2!1sen!2smk!4v1723761125404!5m2!1sen!2smk\" width=\"600\" height=\"450\" style=\"border:0;\" allowfullscreen=\"\" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>", "Hotel Budva", 180 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ApartmentId",
                table: "Bookings",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DestinationId",
                table: "Bookings",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_HotelId",
                table: "Bookings",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ApartmentId",
                table: "Reviews",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HotelId",
                table: "Reviews",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
