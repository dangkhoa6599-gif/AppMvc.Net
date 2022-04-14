using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppMvc.Net.Models;
namespace AppMvc.Net.Controllers
{
    public class FirstController : Controller{
        private readonly ILogger<FirstController>__logger;
        public FirstController(ILogger<FirstController>logger)
        {
            __logger = logger;
        }
        public string Index(){
            // this.HttpContext;
            // this.Request;
            // this.Response;
            // this.RouteData;

            // this.User;
            // this.Url;
            // this.ModelState;
            // this.ViewBag;
            // this.ViewData;
            // this.TempData;
            __logger.LogInformation("log information");
            __logger.Log(LogLevel.Error, "Toang");
            // __logger.LogWarning("Toang that r");
            __logger.LogDebug("Oke r");
            __logger.LogInformation("wassup");2
            Console.WriteLine("the best");
            return "I am a Khoafia";
        }
    }
}