using Microsoft.EntityFrameworkCore; //Usesqlserver
using Microsoft.Extensions.DependencyInjection; //IServiceCollection


namespace Packt.Shared;

public static class NorthwindContextExtension
{
    ///<summary>
    ///Adds NorthwindContext to the specified IServiceCollection, Uses the 
    ///SqlServer database provider.
    /// </summary>
    /// <param name="services" ></param>
    /// <param name="connectionString"> Set to override the default.</param>
    /// <return>An IServiceCollection that can be used to add more services </return>
    /// 
    public static IServiceCollection AddNorthwindContext(
    this IServiceCollection services,
        string connectionString = "Data Source= JARVIS\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = true; TrustServerCertificate=true;MultipleActiveResultSets=true; Encrypt=false")
    {
        services.AddDbContext<NorthwindContext>(options =>
        {
            options.UseSqlServer(connectionString);

            options.LogTo(WriteLine, //Console
            new[] { Microsoft.EntityFrameworkCore
            .Diagnostics.RelationalEventId.CommandExecuting });
        });
        return services;
    }

}
