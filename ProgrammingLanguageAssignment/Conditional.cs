using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguageAssignment
{
    public class Conditional
    {
        public bool If, IfLogic = false;
        public string IfOperator;
        public int IfValue, IfVariable;

        /// <summary>
        /// This Method set parameters needed for the execution of our if program
        /// </summary>
        /// <param name="If"></param>
        /// <param name="Variable"></param>
        /// <param name="Value"></param>
        /// <param name="Operator"></param>
        public void set(bool If, int Variable, int Value, string Operator)
        {
            this.If = If;
            this.IfVariable = Variable;
            this.IfValue = Value;
            this.IfOperator = Operator;
        }

        /// <summary>
        /// Checks the if logic
        /// </summary>
        /// <returns><parameter> IfLogic </parameter> </returns>
        public bool checkIfLogic()
        {
            switch (this.IfOperator)
            {
                case ">":
                    this.IfLogic = (this.IfVariable > this.IfValue);
                    break;
                case "<":
                    this.IfLogic = (this.IfVariable < this.IfValue);
                    break;
                case ">=":
                    this.IfLogic = (this.IfVariable >= this.IfValue);
                    break;
                case "<=":
                    this.IfLogic = (this.IfVariable <= this.IfValue);
                    break;
                case "==":
                    this.IfLogic = (this.IfVariable == this.IfValue);
                    break;
                case "!=":
                    this.IfLogic = (this.IfVariable != this.IfValue);
                    break;
                default:
                    this.IfLogic = false;
                    break;
            }
            return this.IfLogic;

        }

    }
}
