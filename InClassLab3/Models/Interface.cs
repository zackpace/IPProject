using InClassLab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab3.Data
{
    public interface IDb
    {
        IEnumerable<Person> GetPersons();
        IEnumerable<Email> GetEmails();
        IEnumerable<Phone> GetPhones();
        IEnumerable<Address> GetAddresses();

        Person GetPerson(int Id);
        IEnumerable<Phone> GetPhonesForPerson(int PersonId);
        IEnumerable<Address> GetAddressesForPerson(int PersonId);
        IEnumerable<Email> GetEmailsForPerson(int PersonId);
    }

    public class TestDB : IDb
    {
        private List<Person> people = new List<Person>()
        {
            new Person
            {
                DOB = DateTime.Parse("2000-02-03"),
                fName = "James",
                Gender = 'M',
                Id = 0,
                lName = "Donovan",
                mName = "Grippe"
            },
            new Person
            {
                DOB = DateTime.Parse("1990-03-04"),
                fName = "Jimmy",
                Gender = 'M',
                Id = 1,
                lName = "Donn",
                mName = "Hulh"
            },
            new Person
            {
                DOB = DateTime.Parse("1900-04-04"),
                fName = "Gertrude",
                Gender = 'F',
                Id = 2,
                lName = "Jeny",
                mName = "Boofla"
            },
            new Person
            {
                DOB = DateTime.Parse("1950-03-04"),
                fName = "Timothy",
                Gender = 'M',
                Id = 3,
                lName = "Rongin",
                mName = "Lindj"
            }
        };

        private List<Address> addresses = new List<Address>()
        {
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "244 Main St",
                Line2 = "Suite 2",
                PersonId = 0,
                State = "AL",
                Type = 1,
                Zip = "34092"
            },
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "45 2nd St",
                Line2 = "",
                PersonId = 0,
                State = "AL",
                Type = 0,
                Zip = "34092"
            },
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "244 Main St",
                Line2 = "Suite 2",
                PersonId = 1,
                State = "AL",
                Type = 1,
                Zip = "34092"
            },
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "435 3rd St",
                Line2 = "",
                PersonId = 1,
                State = "AL",
                Type = 0,
                Zip = "34092"
            },
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "244 Main St",
                Line2 = "Suite 3",
                PersonId = 2,
                State = "AL",
                Type = 1,
                Zip = "34092"
            },
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "5 5th St",
                Line2 = "",
                PersonId = 2,
                State = "AL",
                Type = 0,
                Zip = "34092"
            },
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "24 South St",
                Line2 = "",
                PersonId = 3,
                State = "NC",
                Type = 1,
                Zip = "27576"
            },
            new Address
            {
                City = "Selma",
                Id = 0,
                Line1 = "5 Court St",
                Line2 = "",
                PersonId = 3,
                State = "NC",
                Type = 0,
                Zip = "27576"
            }
        };

        private List<Phone> phones = new List<Phone>()
        {
            new Phone
            {
                Id = 0,
                Number = "334-445-6678",
                PersonId = 0,
                Type = 1
            },
            new Phone
            {
                Id = 1,
                Number = "334-435-6678",
                PersonId = 0,
                Type = 0
            },
            new Phone
            {
                Id = 2,
                Number = "334-905-6678",
                PersonId = 1,
                Type = 1
            },
            new Phone
            {
                Id = 3,
                Number = "334-675-6678",
                PersonId = 1,
                Type = 0
            },
            new Phone
            {
                Id = 4,
                Number = "334-615-6678",
                PersonId = 2,
                Type = 0
            },
            new Phone
            {
                Id = 5,
                Number = "334-675-6653",
                PersonId = 3,
                Type = 0
            }
        };

        private List<Email> emails = new List<Email>() {
            new Email
            {
                Address = "james@selma.al",
                Id = 0,
                PersonId = 0,
                Type = 1
            },
            new Email
            {
                Address = "james@gmail.com",
                Id = 1,
                PersonId = 0,
                Type = 0
            },
            new Email
            {
                Address = "Jimmy@selma.al",
                Id = 2,
                PersonId = 1,
                Type = 1
            },
            new Email
            {
                Address = "Jimmy@gmail.com",
                Id = 3,
                PersonId = 1,
                Type = 0
            },
            new Email
            {
                Address = "Timothy@gmail.com",
                Id = 4,
                PersonId = 3,
                Type = 0
            }
        };

        public IEnumerable<Address> GetAddresses()
        {
            return addresses;
        }

        public IEnumerable<Address> GetAddressesForPerson(int PersonId)
        {
            return addresses.Where(x => x.PersonId == PersonId);
        }

        public IEnumerable<Email> GetEmails()
        {
            return emails;
        }

        public IEnumerable<Email> GetEmailsForPerson(int PersonId)
        {
            return emails.Where(x => x.PersonId == PersonId);
        }

        public Person GetPerson(int Id)
        {
            return people.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Person> GetPersons()
        {
            return people;
        }

        public IEnumerable<Phone> GetPhones()
        {
            return phones;
        }

        public IEnumerable<Phone> GetPhonesForPerson(int PersonId)
        {
            return phones.Where(x => x.PersonId == PersonId);
        }
    }
}
