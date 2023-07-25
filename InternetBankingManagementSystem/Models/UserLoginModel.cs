using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetBankingManagementSystem.Models
{
    public class UserLoginModel
    {
        [Key]
        public string UserID { get; set; }


        public string LoginPassword { get; set; } 
    }
}