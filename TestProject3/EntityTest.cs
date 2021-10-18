using System;
using ConsoleApplication;
using Xunit;

namespace TestProject3
{
    public abstract class EntityTest<TEntity>
        where TEntity:Entity
    {
        protected TEntity sut;
        protected int SOME_ID;

        protected abstract TEntity GetInstance();

        protected EntityTest()
        {
            sut = GetInstance();
        }

        [Fact]
        public void SayHello_ShouldWorkCorrectly_WithCorrectInput()
        {
            #region Arrange
            string CorrectString = "Alireza Rahmani";
            string expected = "Hello Alireza Rahmani";
            #endregion

            #region Act
            string act = sut.SayHello(CorrectString);
            #endregion

            #region Assert
            Assert.Equal(expected, act);
            #endregion
        }

        [Fact] 
        public void SayHello_ShouldThrowInputParameterIsOutOfRange_ForStringsShorterThan10Character()
        {
            #region Arrange
            string ShortName = "Alireza";
            string expected = "Hello Alireza";
            #endregion

            #region Act
           Action act = ()=>sut.SayHello(ShortName);
            #endregion

            #region Assert
            Assert.Throws<InputParameterIsOutOfRange>(act);
            #endregion
        }


    }
}
