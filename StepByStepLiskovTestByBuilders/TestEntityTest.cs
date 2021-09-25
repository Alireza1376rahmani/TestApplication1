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



        public TestEntityTest()
        {
            builder = getBuilderInstance();
            sut = builder.WithId(SOME_ID).Build();
        }

        protected override TestEntityBuilder getBuilderInstance()
        {
            return new TestEntityBuilder();
        }

        protected override TestEntity getInstance()
        {
            return new TestEntity(SOME_ID);
        }
    }
}
