using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApplication;

namespace StepByStepLiskovTestByBuilders
{
    public class UserTest: EntityTest<User> 
    {

        private const string SOME_NAME = "some name";

        public UserTest()
        {
            UserBuilder builder = new UserBuilder();
            sut = builder.WithName(SOME_NAME).WithId(SOME_ID).Build();
        }

        protected override User getInstance()
        {
            return new User(SOME_ID, SOME_NAME);
        }

        protected override void AssertInvariants()
        {
            base.AssertInvariants();
            Assert.Equal(SOME_NAME, sut.Username);
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

        public override void SayHelloShouldThrowInputParameterIsOutOfRangeWITHStringShorterThan10Characters() {}

        
    }
}
