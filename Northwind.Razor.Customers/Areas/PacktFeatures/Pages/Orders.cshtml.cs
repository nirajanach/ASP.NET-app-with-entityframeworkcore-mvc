using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace PacktFeatures.Pages;

public class OrdersPageModel : PageModel
{
    private NorthwindContext db;

    public OrdersPageModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }
    public IEnumerable<Order> Orders { get; set; } = null!;

    public void OnGet()
    {
        ViewData["Title"] = "Norhtwind B2B - Orders";

        Orders = db.Orders.AsEnumerable();
    }
}
