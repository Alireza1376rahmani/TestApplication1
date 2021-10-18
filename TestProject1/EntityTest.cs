using System;
using Xunit;
using ConsoleApplication;

namespace TestProject1
{
    public abstract class EntityTest<TEntity> : IDisposable where TEntity : Entity
    {
        public TEntity sut;
        protected EntityBuilder<TEntity> Builder = null;
        private const int SOME_ID = 10;

        public EntityTest()
        {
            Builder = GetBuilderInstance();
            Builder.WithId(SOME_ID);
            sut = Builder.Build();
        }

        protected abstract EntityBuilder<TEntity> GetBuilderInstance();

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

        protected virtual void AssertInvariants()
        {
            Assert.Equal(SOME_ID, sut.Id);
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

    public class TestEntityTest : EntityTest<TestEntity>
    {
        protected override EntityBuilder<TestEntity> GetBuilderInstance()
        {
            return new TestEntityBuilder();
        }
    }
}
