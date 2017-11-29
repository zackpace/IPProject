using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab3.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
    public class Account
    {
        public int AccountNumber { get; set; }
        public string Balance { get; set; }
        public string DateOpened { get; set; }
        public int BranchId { get; set; }
        public int PersonID { get; set; }
        public char Type { get; set; }
        public float InterestRate { get; set; }
    }
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public Decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

    }


    //old ones
    public class Address
    {
        public int Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Type { get; set; }
        public int PersonId { get; set; }
    }
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Type { get; set; }
        public int PersonId { get; set; }
    }
    public class Email
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Type { get; set; }
        public int PersonId { get; set; }
    }
}
