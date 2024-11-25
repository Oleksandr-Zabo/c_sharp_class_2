using System;
using System.Text.RegularExpressions;

namespace c_sharp_class_2.Classes
{
    internal class LogicalExpression
    {
        public static bool Evaluate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
            {
                throw new ArgumentException("Expression cannot be empty.");
            }
            if(expression.Contains(' '))
            {
                string[] parts = expression.Split("==");
                throw new ArgumentException("Invalid expression format.");
            }

            // Validate the expression using a regular expression
            if (!Regex.IsMatch(expression, @"^\d+\s*(==|!=|<=|>=|<|>)\s*\d+$"))
            {
                throw new ArgumentException("Invalid expression format.");
            }

            // Parse and evaluate the expression
            return EvaluateParsedExpression(expression);
        }

        private static bool EvaluateParsedExpression(string expression)
        {
            string[] operators = { "==", "!=", "<=", ">=", "<", ">" };
            foreach (var op in operators)
            {
                int index = expression.IndexOf(op);
                if (index != -1)
                {
                    int leftOperand = ConvertToInt(expression.Substring(0, index).Trim());
                    int rightOperand = ConvertToInt(expression.Substring(index + op.Length).Trim());
                    return EvaluateOperation(leftOperand, rightOperand, op);
                }
            }
            throw new ArgumentException("Invalid expression format.");
        }

        private static int ConvertToInt(string number)
        {
            int result = 0;
            foreach (char c in number)
            {
                if (c < '0' || c > '9')
                {
                    throw new ArgumentException("Invalid number format.");
                }
                result = result * 10 + (c - '0');
            }
            return result;
        }

        private static bool EvaluateOperation(int leftOperand, int rightOperand, string op)
        {
            return op switch
            {
                "==" => leftOperand == rightOperand,
                "!=" => leftOperand != rightOperand,
                "<=" => leftOperand <= rightOperand,
                ">=" => leftOperand >= rightOperand,
                "<" => leftOperand < rightOperand,
                ">" => leftOperand > rightOperand,
                _ => throw new ArgumentException("Invalid operator."),
            };
        }

    }
}
