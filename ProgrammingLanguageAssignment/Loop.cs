using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguageAssignment
{
    /// <summary>
    /// Declaration of required parameters needed for the running of our loop
    /// </summary>
    public class Loop
    {
        public bool loop, loopLogic = false;
        public string loopOperator;
        public int loopValue, loopVariable;

        /// <summary>
        /// This method set the parameter called "loop"
        /// </summary>
        /// <param name="loop"></param>
        public void setLoop(bool loop)
        {
            this.loop = loop;
        }


        /// <summary>
        /// This method set the parameter called "variable"
        /// </summary>
        /// <param name="variable"></param>
        public void setVariable(int variable)
        {
            this.loopVariable = variable;
        }

        /// <summary>
        /// This method set the parameter called "value"
        /// </summary>
        /// <param name="value"></param>
        public void setValue(int value)
        {
            this.loopValue = value;
        }

        /// <summary>
        /// This method set the parameter called "Operator"
        /// </summary>
        /// <param name="Operator"></param>
        public void setOperator(string Operator)
        {
            this.loopOperator = Operator;
        }

        /// <summary>
        /// Checks loop logic
        /// </summary>
 

        public bool checkLoopLogic()
        {
            switch (this.loopOperator)
            {
                case ">":
                    this.loopLogic = (this.loopVariable > this.loopValue);
                    break;
                case "<":
                    this.loopLogic = (this.loopVariable < this.loopValue);
                    break;
                case ">=":
                    this.loopLogic = (this.loopVariable >= this.loopValue);
                    break;
                case "<=":
                    this.loopLogic = (this.loopVariable <= this.loopValue);
                    break;
                case "==":
                    this.loopLogic = (this.loopVariable == this.loopValue);
                    break;
                case "!=":
                    this.loopLogic = (this.loopVariable != this.loopValue);
                    break;
                default:
                    this.loopLogic = false;
                    break;
            }
            return this.loopLogic;

        }
    }
}
