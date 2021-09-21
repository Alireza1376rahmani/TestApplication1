using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication;
using Xunit;

namespace TestProject1
{
    public class UserTest : EntityTest<User>
    {
        private const string SOME_NAME = "some name";
        
        protected override void AssertInvariants()
        {
            base.AssertInvariants();
            Assert.Equal(SOME_NAME, sut.Username);
        }

        protected override EntityBuilder<User> GetBuilderInstance()
        {
            return new UserBuilder().WithName(SOME_NAME);
        }


        [Fact]
        public void SayHelloShouldThrowInputParameterIsOutOfRangeWITHStringShorterThan5Characters()
        {
            #region Arrange
            //builder.WithName("");
            var shortName = "lili";
            #endregion

            #region Act
            Action act = () => { string output = sut.SayHello(shortName); };
            #endregion

            #region Assert
            Assert.Throws<InputParameterIsOutOfRange>(act);
            #endregion

        }

        [Fact]
        public void SayHelloShouldThrowOutputContainsInvalidWordWITHStringsContainsInvalidCharacters() 
        {
            #region Arrange
            var stringWithInvalidCharacter = "alireza@rahmani";
            #endregion

            #region Act
            Action act = () => { sut.SayHello(stringWithInvalidCharacter); };
            #endregion

            #region Assert
            Assert.Throws<OutputContainsInvalidWord>(act);
            #endregion
        }

       
        public override void SayHelloShouldThrowInputParameterIsOutOfRangeWITHStringShorterThan10Characters()
        {}

    }
}
