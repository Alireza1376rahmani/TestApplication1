using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject3
{
    public class TestEntityTest : EntityTest<TestEntity>
    {
        protected override TestEntity GetInstance()
        {
            return new TestEntity(SOME_ID);
        }
    }
}
