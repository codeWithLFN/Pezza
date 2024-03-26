using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestBase: DatabaseContextTest
    {
        public TestBase()
        : base(
        new DbContextOptionsBuilder<DbContext>()
            .UseInMemoryDatabase("PezzaDb")
            .Options)
        {
        }
    }
}
