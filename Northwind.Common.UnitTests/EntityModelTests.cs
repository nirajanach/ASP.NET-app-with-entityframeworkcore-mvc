using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Packt.Shared; //NorthwindContext
using Xunit;

namespace Northwind.Common.UnitTests
{
    public class EntityModelTests
    {
        [Fact]
        public void DatabaseConnectTest()
        {
            using (NorthwindContext db = new())
            {
                Assert.True(db.Database.CanConnect());
            }
        }

        [Fact]
        public void CategoryCountTest()
        {
            using (NorthwindContext db = new())
            {
                int expected = 8;
                int actual = db.Categories.Count();

                Assert.Equal(expected, actual);
            }
        }

    }
}
