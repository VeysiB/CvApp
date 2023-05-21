using Medas.AdversimentApp.UI.Extensions;
using Medas.AdversimentApp.UI.Models;
using Medas.AdvertisementApp.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Medas.AdversimentApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServiceService;
        private readonly IAdvertisementService _advertisingService;

        public HomeController(IProvidedServiceService providedServiceService, IAdvertisementService advertisingService)
        {
            _providedServiceService = providedServiceService;
            _advertisingService = advertisingService;
        }

        public async Task<IActionResult> Index()
        {
            var response=await _providedServiceService.GetAllAsync();
            return this.ResponseView(response);
        }
        public async Task<IActionResult> HumanResource()
        {
            var response=await _advertisingService.GetActivesAsync();
            return this.ResponseView(response);
        }
    }
}