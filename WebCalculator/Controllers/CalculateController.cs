using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class CalculateController : Controller
    {
     

        public IActionResult Index(String txt)

        {
            if (txt != null)
            {
                if (txt.Length - 1 == '+' || txt.Length - 1 == '-' || txt.Length - 1 == '*' || txt.Length - 1 == '/')
                {
                    
                    ViewBag.result = "txt";
                }
                else
                {
                    ViewBag.result = GetResult(txt);
                   
                }
            }
            return View();

        }

        public IActionResult Calculate()
        {
            return View();
        }

        public string GetResult(string str)
        {
            List<char> symbleList = new List<char>();
            char[] charSymble = { '+', '-', '*', '/' };
            string[] st = str.Split(charSymble);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    symbleList.Add(str[i]);
                }
            }
            double result = Convert.ToDouble(st[0]);
            for (int i = 1; i < st.Length; i++)
            {
                double num = Convert.ToDouble(st[i]);
                int j = i - 1;
                switch (symbleList[j])
                {
                    case '+':
                        result = result + num;
                        break;
                    case '-':
                        result = result - num;
                        break;
                    case '*':
                        result = result * num;
                        break;
                    case '/':
                        result = result / num;
                        break;
                    default:
                        result = 0.0;
                        break;
                }
            }
            return result.ToString();
        }

        //public JsonResult CalculateMethod(int valueOne, int valueTwo, string parsedOperator)
        //{
        //    valueOne = 0;
        //    valueTwo = 0;
        //    parsedOperator = "+";
           
        //    double answer = 0;              // to store result
        //    char operation = '+';
        //    double operand = 0;             // to store the number
        //    bool operationFlag = false;

        //    do
        //    {
        //        // input for number

              

        //        // check operation which previous input from user
        //        if (operation == '+')
        //        {
        //            answer += operand;
        //        }
        //        else if (operation == '-')
        //        {
        //            answer -= operand;
        //        }
        //        else if (operation == '*')
        //        {
        //            answer *= operand;
        //        }
        //        else if (operation == '/')
        //        {
        //            answer /= operand;
        //        }
        //        // input validation for operator
        //        operationFlag = false;
        //        do
        //        {
        //            // take input for operator
        //            //Console.Write("Enter a Operator: ");
        //            //operation = Console.ReadKey().KeyChar;
        //            //Console.WriteLine();
        //            // check if it is +, -, *, / or = , then set the operationFlag = true 
        //            if (operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '=')
        //            {
        //                operationFlag = true;
        //            }
        //            else
        //            {
        //                // otherwise display error message and take new input for operator
        //                Console.WriteLine("Invavlid Operation. Please only use +, -, *, / and = as operator.");
        //            }
        //        }
        //        while (operationFlag == false);



        //    }
        //    while (operation != '=');

        //    // show answer

        //    JsonResponse jsonResponse = new JsonResponse()
        //    {
        //        message = "success"
        //    };
        //    return Json(new JsonResponse());
        //}

        

    }
}
