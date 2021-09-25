using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepByStepLiskovTestByBuilders
{
    public class TestEntityBuilder : EntityBuilder<TestEntity, TestEntityBuilder>
    {
        public override TestEntity Build()
        {
            return new TestEntity(id);
        }
    }
}
