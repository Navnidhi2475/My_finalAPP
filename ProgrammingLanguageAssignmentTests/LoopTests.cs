using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingLanguageAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguageAssignment.Tests
{

    [TestClass()]
    public class LoopTests
    {
        /// <summary>
        /// This method checks if the "loopValue" has been set
        /// </summary>
        [TestMethod()]
        public void LoopTest()
        {
            bool loopValue = true;
            Loop loopInstance = new Loop();
            loopInstance.setLoop(loopValue);
            Assert.IsTrue(loopInstance.loop == loopValue);

        }

        /// <summary>
        /// This method checks if the parameter "variable" has been set
        /// </summary>
        [TestMethod()]
        public void LoopTestVariable()
        {
            int variable = 5;
            Loop loop = new Loop();
            loop.setVariable(variable);
            Assert.IsTrue(loop.loopVariable == variable);
        }


        /// <summary>
        /// This method checks if the parameter "operatorValue" has been set
        /// </summary>
        [TestMethod()]
        public void LoopTestOperator() 
        {
            string operatorValue = ">";
            Loop loop = new Loop();
            loop.setOperator(operatorValue);
            Assert.IsTrue(loop.loopOperator == operatorValue);
        }

        [TestMethod()]
        public void LoopTestValue()
        {
            int value = 10;
            Loop loop = new Loop();
            loop.setValue(value);
            Assert.IsTrue(loop.loopValue == value);
        }
    }
}