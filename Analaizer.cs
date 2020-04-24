using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcClass;

namespace AnalaizerClass
{
    public class Analaizer
    {
        private static int erposition = 0;
        //public static string expression = "";
        public static string expression = "(31+10)*5/(100-95)";

        public static bool ShowMessage = true;

        static bool IsOperator(string c)
        {
            return (c == "-" || c == "+" || c == "*" || c == "/");
        }

        static bool IsOperand(char c)
        {
            return (c >= '0' && c <= '9');
        }

        static bool AllowedСhar(char c)
        {
            return (c >= '(' && c <= '9' && c != ',' && c != '.');
        }

        public static bool CheckCurrency() // рахує дужки і перевіряє перший символ 
        {
            string firstElement = "0123456789-(";
            if (!firstElement.Contains(expression[0].ToString())) // перевіряє перший символ
            {
                erposition = 1; //???????????? or 0
                return false;
            }

            int parenthesesCount = 0;

            for (int i = 0; i < expression.Length; i++) // рахує дужки
            {
                char ch = expression[i];
                switch (ch)
                {
                    case '(':
                        parenthesesCount++;
                        break;
                    case ')':
                        parenthesesCount--;
                        break;
                    default:
                        break;
                }
                if (parenthesesCount < 0)
                {
                    erposition = i;
                    return false;
                }
            }
            if (parenthesesCount != 0)
            {
                return false;
            }
            return true;
        }

        public static bool CheckOperators() // перевіряє оператори(не може бути 2 поряд і перед закриваючою дужкою і останній)
        {
            bool isLastOperator = false;
            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];
                if ((isLastOperator && IsOperator(ch.ToString())) || (isLastOperator && ch == ')'))
                {
                    erposition = i;
                    return false;
                }
                isLastOperator = IsOperator(ch.ToString());
            }
            if (IsOperator(expression[expression.Length].ToString())) // помилка, якщо в кінці рядка оператор
            {
                erposition = expression.Length;
                return false;
            }
            return true;
        }

        public static string Format() // має шукати нерозпізнані оператори і видаляти пробіли
        {
            expression = expression.Replace(" ", string.Empty); // видаляє пробіли
            //string allowedСharacters = "";
            for (int i = 0; i <= expression.Length; i++)
            {
                char ch = expression[i];
                if (!AllowedСhar(ch))
                {
                    erposition = i;
                    //return; (повідомлення про помилку, нерозпізнаний оператор)
                }
            }
            return expression;
        }

        public static ArrayList CreateStack()
        {
            ArrayList output = new ArrayList();
            Stack stack = new Stack();
            bool isLastNum = false;

            for (int i = 0; i < expression.Length; i++)
            {
                char x = expression[i];
                if (x == '(')
                {
                    stack.Push(x);
                    isLastNum = false;
                }
                else if (IsOperand(x)) // is it operand
                {
                    if(isLastNum == true)
                    {
                        string s = x.ToString();
                        output[output.Count - 1] = String.Concat(output[output.Count - 1].ToString(), s);
                        isLastNum = true;
                    }
                    else
                    {
                        output.Add(x.ToString());
                        isLastNum = true;
                    }
                }
                else if (IsOperator(x.ToString()))  // is it operator
                {
                    if (stack.Count > 0 && (char)stack.Peek() != '(' && Priority(x) <= Priority((char)stack.Peek()))
                    {
                        char y = (char)stack.Pop();
                        output.Add(y.ToString());
                    }
                    if (stack.Count > 0 && (char)stack.Peek() != '(' && Priority(x) < Priority((char)stack.Peek()))
                    {
                        char y = (char)stack.Pop();
                        output.Add(y.ToString());
                    }
                    stack.Push(x);
                    isLastNum = false;
                }
                else if(x == ')')
                {
                    while ((char)stack.Peek() != '(')
                    {
                        char y = (char)stack.Pop();
                        output.Add(y.ToString());
                    }
                    stack.Pop();
                    if (stack.Count != 0)
                    {
                        string next = stack.Peek().ToString();
                        if (IsOperator(next))
                        {
                            char y = (char)stack.Pop();
                            output.Add(y.ToString());
                            i++;
                        }
                    }
                    isLastNum = false;
                }
            }
            while (stack.Count > 0)
            {
                char c = (char)stack.Pop();
                output.Add(c.ToString());
            }
            return output;

            byte Priority(char c)
            {
                switch (c)
                {
                    case '+':
                    case '-':
                        return 1;
                    case '*':
                    case '/':
                        return 2;
                    case '^':
                        return 3;
                    default:
                        throw new ArgumentException("Rossz parameter");
                }
            }
        }

        public static string RunEstimate() // Обчислення зворотнього польського запису
        {
            string result = "";
            Stack stack = new Stack();
            ArrayList list = new ArrayList();
            list = CreateStack();
            for (int i = 0; i < list.Count; i++)
            {
                if (!IsOperator(list[i].ToString()))
                {
                    stack.Push(list[i]);
                }
                else if (IsOperator(list[i].ToString()))
                {
                    string oper = (list[i].ToString());
                    long b = Convert.ToInt64(stack.Pop());
                    long a = Convert.ToInt64(stack.Pop());
                    switch (oper)
                    {
                        case "+":
                            stack.Push(Calc.Add(a, b));
                            break;
                        case "-":
                            stack.Push(Calc.Sub(a, b));
                            break;
                        case "*":
                            stack.Push(Calc.Mult(a, b));
                            break;
                        case "/":
                            stack.Push(Calc.Div(a, b));
                            break;
                        case "mod":
                            stack.Push(Calc.Mod(a, b));
                            break;
                    }
                }
            }
            while (stack.Count > 0)
            {
                result = stack.Pop().ToString();
            }
            return result;
        }

        public static string Estimate() // Метод, який організовує обчислення
        {
            string result = "";

            return result;
        }

    }
}
