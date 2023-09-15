using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; //PageModel
using Microsoft.EntityFrameworkCore;
using Packt.Shared; //NorthiwndContext, Customer

namespace PacktFeatures.Pages;

public class CustomerModel : PageModel
{
    private readonly NorthwindContext _context;

    public CustomerModel(NorthwindContext context)
    {
        _context = context;
    }

    public Customer Customer { get; set; }

    public IList<Order> Orders { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        Customer = await _context.Customers.FindAsync(id);

        if (Customer == null)
        {
            return NotFound();
        }

        Orders = await _context.Orders
            .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
            .Where(o => o.CustomerId == id)
            .ToListAsync();

        return Page();
    }
}

