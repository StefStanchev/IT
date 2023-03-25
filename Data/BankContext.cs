﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data

{
    public class BankContext : DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserBankInfo> UserBankInfos { get; set; }

        public DbSet<UserIBANInfo> UserIBANInfos { get; set; }
        public DbSet<CreditBooleanInfo> CreditBooleanInfos { get; set; }
        public DbSet<CreditDateInfo> CreditDateInfos { get; set; }
        public DbSet<CreditMoneyInfo> CreditMoneyInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=bank;Uid=root;Pwd=ytrewq050713;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}