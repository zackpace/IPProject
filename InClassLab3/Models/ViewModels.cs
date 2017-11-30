using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankDB;

namespace InClassLab3.Models
{
    public class PersonViewModel
    {
        

        public Person Person { get; set; }
        public List<Account> Accounts { get; set; }

    }
    public class MainViewModel
    {
        public List<Person> Person { get; set; }
        public List<Branch> Branches { get; set; }
     
    }
    public class BranchViewModel
    {
        public List<Account> Accounts { get; set; }
        public Branch Branch { get; set; }

    }
    public class TransactionViewModel
    {
        public Account Account { get; set; }
        public List<Transaction> Transaction { get; set; }
    }

}