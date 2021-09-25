using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApplication;



namespace StepByStepLiskovTestByBuilders
{
    public abstract class EntityTest<TEntity, TEntityBuilder> : IDisposable
        where TEntity : Entity
        where TEntityBuilder : EntityBuilder<TEntity, TEntityBuilder>
    {

        protected const int SOME_ID = 5;
        protected TEntityBuilder builder;
        protected TEntity sut;

        protected abstract TEntity getInstance();
        protected abstract TEntityBuilder getBuilderInstance();


        protected virtual void AssertInvariants()
        {
            Assert.Equal(SOME_ID, sut.Id);
        }

        public EntityTest()
        {
            sut = getInstance();
        }

        [Fact]
        public void SayHelloShouldWorkProperlyWithCorrectInput()
        {
            #region Arrange
            var someone = "alireza rahmani";
            var expected = "Hello alireza rahmani";
            #endregion

            #region Act
            var actual = sut.SayHello(someone);
            #endregion

            #region Assert
            Assert.Equal(expected, actual);
            AssertInvariants();
            #endregion
        }

        [Fact]
        public virtual void SayHelloShouldThrowInputParameterIsOutOfRangeWITHStringShorterThan10Characters()
        {
            #region Arrange
            var invalid = "someone";
            #endregion

            #region Act
            Action act = () => { string output = sut.SayHello(invalid); };
            #endregion

            #region Assert
            Assert.Throws<InputParameterIsOutOfRange>(act);
            #endregion

        }

        [Fact]
        public void SayHelloShouldThrowOutputContainsInvalidWordWITHStringsContainByeWord()
        {
            #region Arrange
            var containsBye = "byethen :)";
            #endregion

            #region Act
            Action act = () => { sut.SayHello(containsBye); };
            #endregion

            #region Assert
            Assert.Throws<OutputContainsInvalidWord>(act);
            #endregion
        }

        public void Dispose()
        {
            AssertInvariants();
        }
    }
}
