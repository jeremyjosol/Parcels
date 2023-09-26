using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
    return View();
    }
    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/parcels")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel newParcel = new Parcel(length, width, height, weight);
      return RedirectToAction("Index");
    }
  }
}