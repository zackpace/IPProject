
using InClassLab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace InClassLab3.Controllers
{
    public class HomeController : Controller
    {
      

        public ActionResult Index()
        {

            BankDB.DataRepository db = new BankDB.DataRepository();

            var branches = db.GetBranches();

            var people = db.GetPeople();
            var viewModel = new MainViewModel
            {
                Person = people,
                Branches = branches

            };
            return View(viewModel);
        }


        public ActionResult People(int id)
        {

            BankDB.DataRepository db = new BankDB.DataRepository();

            var accounts = db.GetAccountsForPerson(id);

            var person = db.GetPerson(id);
            var viewModel = new PersonViewModel
            {
                Person = person,
                Accounts = accounts

            };
            return View(viewModel);


        }
        public ActionResult Branch(int id)
        {

            BankDB.DataRepository db = new BankDB.DataRepository();

            var accounts = db.GetAccountsForBranch(id);

            var branch = db.FindBranch(id);
            var viewModel = new BranchViewModel
            {
                Branch = branch,
                Accounts = accounts

            };
            return View(viewModel);


        }

        public ActionResult AccountDetails(int id)
        {

            BankDB.DataRepository db = new BankDB.DataRepository();

            var account = db.GetAccount(id);

    
            var viewModel = new AccountViewModel
            {
               
                Account = account

            };
            return PartialView(viewModel);


        }


    }
}