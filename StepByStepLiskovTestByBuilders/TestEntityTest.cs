using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApplication;

namespace StepByStepLiskovTestByBuilders
{
    public class TestEntityTest : EntityTest<TestEntity>
    {

        public TestEntityTest()
        {
            builder = new TestEntityBuilder();
            sut = builder.WithId(SOME_ID).Build();
        } 


    }
}
