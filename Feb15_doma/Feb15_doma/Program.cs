using System;

namespace Feb15_doma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Proverka Console.ReadLine

            
            //Console.WriteLine("Eded daxil edin.");

            //string input = Console.ReadLine();
            //int newinput = int.Parse(input);

            //if (newinput > 100)
            //{
            //    Console.WriteLine("ok");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region Proverka checked unchecked

            //int b = 0;

            //try
            //{
            //    checked
            //    {
            //        int a = 2147483647;
            //        b = a + 100;
            //        Console.WriteLine(b);   // on ne stanet vozvrashatsa k otricatelnomu znacheniyu dla int,
            //                                // on vozmet i slojit i skajet shto ya neprav
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("nese cox oldu e ele bil");
            //    throw;
            //}

            Console.WriteLine("-------------");

            //unchecked
            //{
            //    int a = 214748847;
            //    b = a + 100;
            //    Console.WriteLine(b);   // emu pofiq on schitayet tupo 
            //}

            #endregion

            #region Method probuyu tot kotoriy s komentami

            //Console.WriteLine("Deyer daxil et."); // standartniy sms dla nashego usera
            //string selected = Console.ReadLine(); // mi vzali u nego cislo 

            //SumEvenNumberProbovalBezReturn(selected); // eto mi pozvali nash metod i zasunuli v nego cislo kotoroe vvel user, i otpravili obratno v metod

            #endregion

            #region Method prodoljenie vnizu noviy metod INT

            Console.WriteLine("Salam, eded daxil edin");   // ---prosim usera vvesti cislo
            string input = Console.ReadLine(); // ---prevrashayem ego vvedennoe cislo v string i dayem variable input

            Console.WriteLine(SumEvenNumber(input)); // ---eto mi uje pozvali nash metod, i napisali na cmd

            int aaa = SumEvenNumber(input); // ---sdes ya pridal emu noviy variable potomushto xochu ispolzovat ego v divide by five metode

            DivideByFive(aaa);  // ---sdes ya napisal aaa - eto tot variable, kotoriy prinal znachenie rezultata returna iz metoda sumevennumber

            #endregion
        }
        static void SumEvenNumberProbovalBezReturn(string str) // tut u nas uje svoy variable, eto string str, i vse sdes proisxodit vmeste s etim str
        {
            //int number = int.Parse(str); // str bil stringom, perevodim ego v int. znachit znachala user vvel selected, potom mi ego suda 
            //int EvenSum = 0;             //  suda poslali, on stal str, potom etot str stanovitsa int number-om.
            //for (int i = 0; i < number; i++)     // delayem loop shto bi vse cetnie cisla do moeqo vvedennogo cisla slojilis i obrazovali summu
            //{
            //    if (i % 2 == 0) // eto mi stavim uslovie shto bi nashi cisla do vvedennogo bili chetnimi
            //    {
            //        EvenSum += i;  // eto nash evensum kotoriy bil 0, i stanet kajdiy raz uvelicivatsa na posleduyusheye cetnoe cislo i 
            //    }                  // otkladivatsa v pamati kak Evensum, i potom mi delayem cw evensum i on otvet otpravlayem obratno nam.
            //}
            //Console.WriteLine(EvenSum);
        }

        static int SumEvenNumber(string stra)
        {                                             // --- eto otnositsa k regionu s tire
            int number1 = int.Parse(stra);   // mi poslali suda input iz Main, i on prevratilsa sdes v stra< i mi zanovo prevrashayem ego v int s variablom number1

            int EvenSum1 = 0; // dayem dla nasheqo even sum nachalniy value 0 ptm shto her dongede onu artiracag  ve atacag yaddasha

            for (int i = 0; i < number1; i++)   // mi budem krutitsa stolko raz poka ne doydem do nasheqo cisla,
            {
                if (i % 2 == 0)   // mi krutimsa i kajdiy raz zaxodim suda, esli nash i chetniy skladivayem ego v pamat even suma, esli necetniy vozvrashaemsa v loop
                {
                    EvenSum1 += i; // v pamat idet nash evensum
                }
            }
            return EvenSum1;  // v konce mi prosto vernem evensum i on poydet izza RETURN v MAIN i pridast svoe znacnie int aaa !!!! kotoriy otpravit ego v divide by five
        }

        static void DivideByFive(int pro)   // u nas int aaa bil raven rezultatu evensuma, i mi otpravili ego suda i on stal teper int pro
        {
            if (pro % 5 == 0)  // proverayem nash pro kotoriy yavlayetsa cislom a imenno summoy cetnix cisel delitsa li na 5
            {
                Console.WriteLine("Bolunur"); // esli da, to pishet bolunur
            }
            else // else if ne nujno ved u nas vseqo dva varianta vixoda libo bolunur libo bolunmur poetomu dostatocno prosto else
            {
                Console.WriteLine("Bolunmur"); // esli uslovie bolunur ne vipolnitsa algoritm pereydet suda i napishet bolunmur, i viydet i zavershit algoritm.
            }
        }
    }
}
