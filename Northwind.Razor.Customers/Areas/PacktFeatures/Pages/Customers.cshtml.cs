using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; //PageModel
using Packt.Shared; //NorthiwndContext, Customer

namespace PacktFeatures.Pages;

public class CustomersPageModel : PageModel
{
    private NorthwindContext db;
    public CustomersPageModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }

    public Customer[] Customers { get; set; } = null!;

    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Customers";

        Customers = (Customer[])db.Customers.GroupBy( c => c.Country).ToArray();        
    }
}