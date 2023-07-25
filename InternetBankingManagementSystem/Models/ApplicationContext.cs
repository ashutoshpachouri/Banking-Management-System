using InternetBankingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InternetBankingManagementSystem.Data
{
    public class ApplicationContext:DbContext
    {
     
        public ApplicationContext() : base("DefaultConnection") { }
        public DbSet<UserRegistrationModel> Registrations { get; set; }
        public DbSet<UserLoginModel> userLogins { get; set; }
    }
}