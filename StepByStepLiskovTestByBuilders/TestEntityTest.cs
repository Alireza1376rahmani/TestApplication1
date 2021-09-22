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
            sut = getInstance();
        } 

        protected override TestEntity getInstance()
        {
            return new TestEntity(SOME_ID);
        }

        

    }
}
