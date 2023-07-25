using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InternetBankingManagementSystem.Models
{
    public class UserRegistrationModel
    {
        [Key]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "Login Password is required.")]
        public string LoginPassword { get; set; }

        [Compare("LoginPassword", ErrorMessage = "Confirm Login Password does not match.")]
        public string ConfirmLoginPassword { get; set; }

        [Required(ErrorMessage = "Transaction Password is required.")]
        public string TransactionPassword { get; set; }

        [Compare("TransactionPassword", ErrorMessage = "Confirm Transaction Password does not match.")]
        public string ConfirmTransactionPassword { get; set; }

        public string OTP { get; set; }
    }
}