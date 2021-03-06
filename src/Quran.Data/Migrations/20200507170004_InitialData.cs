﻿using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quran.Data.Migrations
{
    public partial class InitialData : Migration
    {
        public string GetRoot()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var sql = File.ReadAllText(GetRoot() + "/data/SeedData1.sql");
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
