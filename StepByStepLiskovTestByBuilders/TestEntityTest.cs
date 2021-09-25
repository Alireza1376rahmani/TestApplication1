using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApplication;

namespace StepByStepLiskovTestByBuilders
{
    public class TestEntityTest : EntityTest<TestEntity, TestEntityBuilder>
    {
        protected override TestEntityBuilder getBuilderInstance()
        {
            return new TestEntityBuilder();
        }
    }
}
