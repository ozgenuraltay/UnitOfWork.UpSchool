using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWork.BusisnessLayer.UpSchool.Abstract;
using UnitOfWork.EntityLayer.UpSchool.Concrete;
using UnitOfWork.PresentationLayer.UpSchool.Models;

namespace UnitOfWork.PresentationLayer.UpSchool.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountVM accountVM)
        {
            var value1 = _accountService.TGetByID(accountVM.SenderID);
            var value2 = _accountService.TGetByID(accountVM.ReceiverID);

            value1.AccountBalance -= accountVM.Amount;
            value2.AccountBalance += accountVM.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2
            };
            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }

    //Yapılacaklar:
    //Eğer kullanıcının bakiyesi eksiye düşecekse bu işlem gerçekleştirilmesin
    //Yapılan değişiklikleri ProcessDetail'e loglama gibi kaydet
}
