using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InClassLab3.Models
{
    public class PersonViewModel
    {
        public BankDB.Person Person { get; set; }
        public List<BankDB.Account> Accounts { get; set; }

    }
    public class MainViewModel
    {
        public List<BankDB.Person> Person { get; set; }
        public List<BankDB.Branch> Branches { get; set; }
     
    }
    public class BranchViewModel
    {
        public List<BankDB.Account> Accounts { get; set; }
        public BankDB.Branch Branch { get; set; }

    }

}