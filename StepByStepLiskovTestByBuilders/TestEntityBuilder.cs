using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepByStepLiskovTestByBuilders
{
    class TestEntityBuilder : EntityBuilder<TestEntity>
    {
        public override TestEntity Build()
        {
            return new TestEntity(id);
        }
    }
}
