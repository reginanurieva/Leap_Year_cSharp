using Microsoft.AspNetCore.Mvc;
using LeapYear.Models;
using System;

namespace LeapYear.Controllers
{
  public class HomeController : Controller

  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/leap-year")]
    public ActionResult LeapYear()
    {
      LeapYearVariable myLeapYearVariable = new LeapYearVariable();
      myLeapYearVariable.SetYear(int.Parse(Request.Query["year"]));
      return View("Output", myLeapYearVariable);
    }
  }
}
