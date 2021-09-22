﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApplication;

namespace StepByStepLiskovTestByBuilders
{
    public class UserTest: EntityTest
    {

        User sut;

        public UserTest()
        {
            sut = new User(1, "name");
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

    }
}