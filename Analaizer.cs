using System;
using System.Collections;
using CalcClass;
using calculator;

namespace AnalaizerClass
{
    public class Analaizer
    {
        private static int MaxLength = 65536;
        private static int erposition = 0;
        public static string expression = "";

        public static bool ShowMessage = true;

        static bool IsOperator(string c)
        {
            return (c == "-" || c == "+" || c == "*" || c == "/" || c == "mod");
        }

        static bool IsOperand(string c)
        {
            if (c.Length > 1)
            {
                return false;
            }
            return (char.Parse(c) >= '0' && char.Parse(c) <= '9');
        }

        public static bool CheckCurrency() // перевіряє дужки, довжину виразу і перший символ 
        {
            if (expression.Length > MaxLength)
            {
                Global.lastError = "Error 07: A very long expression. Maximum length is 65536 characters";
                return false;
            }

            string firstElement = "0123456789-(";
            if (!firstElement.Contains(expression[0].ToString())) // перевіряє перший символ
            {
                erposition = 1;
                Global.lastError = String.Format("Error 02 at {0}: Wrong parameter on the {0} character", erposition);
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
                    Global.lastError = String.Format("Error 01 at {0}: Wrong structure in parentheses, error on the {0} character", erposition);
                    return false;
                }
            }
            if (parenthesesCount != 0)
            {
                erposition = expression.Length;
                Global.lastError = String.Format("Error 01 at {0}: Wrong structure in parentheses, error on the {0} character", erposition);
                return false;
            }
            return true;
        }

        public static bool CheckOperators() // перевіряє оператори (не може бути 2 поряд, перед закриваючою дужкою і останній)
        {
            bool isLastOperator = false;
            for (int i = 0; i < expression.Length; i++)
            {
                string ch = expression[i].ToString();
                if(ch == "m" && i < expression.Length - 2 && expression[i+1]=='o' && expression[i+2]=='d')
                {
                    ch = "mod";
                }
                else if (ch == "m")
                {
                    erposition = i;
                    Global.lastError = String.Format("Error 02 at {0}: Wrong parameter on the {0} character", erposition);
                    return false;
                }
                if ((isLastOperator && IsOperator(ch)) || (isLastOperator && ch == ")"))
                {
                    erposition = i;
                    Global.lastError = String.Format("Error 04 at {0}: Two operators on the {0} character", erposition);
                    return false;
                }
                if (IsOperator(ch) && (i == expression.Length - 1 || i == expression.Length - 3)) // помилка, якщо в кінці рядка оператор
                {
                    erposition = expression.Length;
                    Global.lastError = String.Format("Error 05: Incomplete expression", erposition);
                    return false;
                }
                isLastOperator = IsOperator(ch);
            }
            return true;
        }

        public static string Format() // має шукати нерозпізнані оператори і видаляти пробіли
        {
            expression = expression.Replace(" ", string.Empty); // видаляє пробіли

            for (int i = 0; i < expression.Length; i++)
            {
                string ch = expression[i].ToString();
                if (ch == "m" && i < expression.Length - 2 && expression[i + 1] == 'o' && expression[i + 2] == 'd')
                {
                    ch = "mod";
                }
                if (!(IsOperator(ch) || IsOperand(ch) || ch == ")" || ch == "("))
                {
                    erposition = i;
                    Global.lastError = String.Format("Error 02 at {0}: Wrong parameter on the {0} character", erposition);
                    return expression;
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
                string x = expression[i].ToString();
                if (x == "m" && i < expression.Length - 2 && expression[i + 1] == 'o' && expression[i + 2] == 'd')
                {
                    x = "mod";
                }
                else if (x == "(")
                {
                    stack.Push(x);
                    isLastNum = false;
                }
                else if (IsOperand(x))
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
                else if (IsOperator(x.ToString()))
                {
                    if (stack.Count > 0)
                    {
                        while (Priority(x) <= Priority(stack.Peek().ToString()))
                        {
                            string y = stack.Pop().ToString();
                            output.Add(y.ToString());
                        }
                        stack.Push(x);
                        isLastNum = false;
                    }
                    else
                    {
                        stack.Push(x);
                        isLastNum = false;
                    }
                }
                else if(x == ")")
                {
                    while (stack.Peek().ToString() != "(")
                    {
                        string y = stack.Pop().ToString();
                        output.Add(y.ToString());
                    }
                    stack.Pop();
                    if (stack.Count != 0)
                    {
                        string next = stack.Peek().ToString();
                        if (IsOperator(next))
                        {
                            string y = stack.Pop().ToString();
                            output.Add(y.ToString());
                            i++;
                        }
                    }
                    isLastNum = false;
                }
                if ((stack.Count + output.Count) > 30) // Максимальне сумарне число операторів і чисел – 30
                {
                    Global.lastError = "Error 08: The total number of numbers and operators exceeds 30";
                    return output;
                }
            }
            while (stack.Count > 0)
            {
                string c = stack.Pop().ToString();
                output.Add(c.ToString());
            }
            return output;

            byte Priority(string c)
            {
                switch (c)
                {
                    case "(":
                        return 1;
                    case "+":
                    case "-":
                        return 2;
                    case "*":
                    case "/":
                    case "mod":
                        return 3;
                    case "^":
                        return 4;
                    default:
                        throw new ArgumentException("Wrong parameter");
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
                if (IsOperand(list[i].ToString()))
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
                    if (!String.IsNullOrEmpty(Global.lastError))
                    {
                        return Global.lastError;
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
            if (CheckCurrency() && CheckOperators())
            {
                string result = Format();
                if (!String.IsNullOrEmpty(Global.lastError))
                {
                    return Global.lastError;
                }
                result = RunEstimate();
                if (!String.IsNullOrEmpty(Global.lastError))
                {
                    return Global.lastError;
                }
                return result;
            }
            else return Global.lastError;
        }

    }
}
