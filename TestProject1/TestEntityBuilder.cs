using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestEntityBuilder : EntityBuilder<TestEntity>
    {
        public override TestEntity Build()
        {
            return new TestEntity(id);
        }
    }
}
