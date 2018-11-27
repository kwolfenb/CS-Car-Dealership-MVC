using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    // [HttpGet("/cars")]
    // public ActionResult Cars()
    // {
    // //  List<Item> allItems = Item.GetAll();
    //   return View();
    // }

    [HttpGet("/newcar")]
    public ActionResult NewCar()
    {
      return View();
    }

    [HttpGet("/cars")]
    public ActionResult Cars()
    {
      List<Car> _instances = Car.GetAll();
      return View(_instances);
    }

    [HttpPost("/cars/new")]
    public ActionResult createNewCar(string makeModel, int price, int miles)
    {
      Car newCar = new Car(makeModel, price, miles);
      return RedirectToAction("Cars");
    }

  }
}