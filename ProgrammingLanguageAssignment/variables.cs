using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingLanguageAssignment
{
    public class Variable
    {
        private string[] variableName = new string[100];
        private int[] variableValue = new int[100];

        /// <summary>
        /// This method sets the parameters needed by other classes
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public void set(int value, string name, int index)
        {
            this.variableName[index] = name;
            this.variableValue[index] = value;
        }

        /// <summary>
        /// This method gets variable name
        /// </summary>
        /// <returns>VariableName</returns>
        public string[] getVariableName()
        {
            return this.variableName;
        }

        public int[] getVariableValue()
        {
            return this.variableValue;
        }

        /// <summary>
        /// This method checks for the values of the parameters below
        /// </summary>
        /// <param name="variableIndex"></param>
        /// <param name="variableName"></param>
        /// <param name="SingleCommands"></param>
        public void checkVariableValue(int variableIndex, string variableName, string[] SingleCommands)
        {
            int variableValue;

            if (Regex.Match(SingleCommands[2], @"([+])", RegexOptions.IgnoreCase).Success)
            {
                string[] values = SingleCommands[2].Split('+');
                int valueOne;
                int valueTwo;
                if (this.getVariableName().Contains(values[0].Trim()))
                {
                    int index = Array.IndexOf(this.getVariableName(), values[0]);
                    valueOne = this.getVariableValue()[index];
                }
                else
                {

                    //Console.WriteLine(variableInstance.getVariableName());
                    valueOne = Int32.Parse(values[0]);
                }

                if (this.getVariableName().Contains(values[1].Trim()))
                {
                    int index = Array.IndexOf(this.getVariableName(), values[1]);
                    valueTwo = this.getVariableValue()[index];
                }
                else
                {
                    valueTwo = Int32.Parse(values[1]);
                }
                variableValue = valueOne + valueTwo;
            }

            else
            {
                variableValue = Int32.Parse(SingleCommands[2]);
            }
            //Console.WriteLine(variableValue);
            this.set(variableValue, variableName, variableIndex);
        }
    }
}
