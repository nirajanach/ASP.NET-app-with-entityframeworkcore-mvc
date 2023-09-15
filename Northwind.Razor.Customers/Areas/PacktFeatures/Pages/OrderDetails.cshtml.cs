using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace PacktFeatures.Pages;

public class OrderDetailsPageModel : PageModel
{
    private NorthwindContext db;

    public OrderDetailsPageModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }
    public IEnumerable<OrderDetail> OrderDetails { get; set; } = null!;

    public void OnGet()
    {
        ViewData["Title"] = "Norhtwind B2B - OrderDetails";

        OrderDetails = db.OrderDetails.AsEnumerable();
    }
}
