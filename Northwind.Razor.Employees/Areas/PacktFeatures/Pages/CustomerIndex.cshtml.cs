using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Packt.Shared; //NorthiwndContext, Customer

namespace PacktFeatures.Pages;

public class CustomerIndexModel : PageModel
{


    private readonly NorthwindContext _context;

    public CustomerIndexModel(NorthwindContext context)
    {
        _context = context;
    }

    public ILookup<string, Customer> CustomersGroupedByCountry { get; set; } = null!;

    public void OnGetAsync()
    {
        CustomersGroupedByCountry = _context.Customers
            .AsNoTracking()
            .ToListAsync()
            .Result
            .ToLookup(c => c.Country);
    }
}

