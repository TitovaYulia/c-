using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BullsAndCows.Controllers
{
    public class BullsAndCowsController : Controller
    {

        [HttpGet]
        public ActionResult Game()
        {
            BullsAndCows.Generator.Generator generator = new Generator.Generator();
            BullsAndCows.Models.Give give = new Models.Give();

            int[] a = new int[5];
            a = generator.GeneratorRand();
            give.GenNumber = a;


            if (Session["Const"] == null)
            {
                Session["Const"] = 0;
            }
            Session["Const"] = a;

            if (Session["BullAndCow"] == null)
            {
                Session["BullAndCow"] = 0;
            }

            int[,] massBullAndCow = new int[3, 30];

            Session["BullAndCow"] = massBullAndCow;

            give.InNumber = 0;
            return View(give);
        }
        [HttpPost]
        public ActionResult Game(int InNumber)
        {
            BullsAndCows.Generator.Generator generator = new Generator.Generator();
            BullsAndCows.Models.Give give = new Models.Give();






            //генерируемое число
            int[] b = (int[])Session["Const"];
            give.GenNumber = b;

            //введенное число
            give.InNumber = InNumber;


            int bull = 0, cow = 0;


            int n = InNumber;

            //разбор введеного числа на массив
            int[] nIn = new int[5];
            int del = 10000;
            Boolean flag = false;

            for (int i = 0; i < 5; i++)
            {
                nIn[i] = n / del;
                for (int j = 0; j < i; j++)
                //проверка на повторение цифр
                {
                    if (nIn[i] == nIn[j])
                        flag = true;
                }

                n = n - del * nIn[i];
                del = del / 10;
            }

            //Подсет коров и быков
            if (flag == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (nIn[i] == b[j])
                        {
                            if (i == j)
                            {
                                bull++;
                            }
                            else
                            {
                                cow++;
                            }
                        }
                    }

                }
            }
            else
            {
                cow = 0;
                bull = 0;
                
            }

            give.InNumber = InNumber;
            give.CoincidenceBulls = bull;
            give.CoincidenceCows = cow;
            give.Flag = flag;

            //массив для записи результатов

            int[,] massBullAndCow = (int[,])Session["BullAndCow"];


            int freeMass = 0;

            if (InNumber != 0 && flag==false)
            {
                //ищем свободное место в массиве
                while (massBullAndCow[0, freeMass] != 0)
                {
                    freeMass++;
                }


                massBullAndCow[0, freeMass] = InNumber;
                massBullAndCow[1, freeMass] = bull;
                massBullAndCow[2, freeMass] = cow;
            }
            else
            {
                while (massBullAndCow[0, freeMass] != 0)
                {
                    freeMass++;
                }
            }

            Session["BullAndCow"] = massBullAndCow;

            give.BullAndCow = massBullAndCow;
            give.FreeMass = freeMass;
            return View(give);

        }
        public ActionResult Rule()
        {

            return View();
        }

    }
}