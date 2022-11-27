using System;

namespace HelloWorld
{
    class Program
    {
        /** 
        1.We have to write all the codes inside classes
        2.The 'nampespace' contains different classes
        3.'using' keyword is to import packages/namespaces to other cs file 
        */
        static void Main(string[] args)
        {
            /**
            1.Variable: int num = 1;
            2.Constant: const float Pi = 3.14;
             */

            int firstVar = 10;
            float secondVar = 5.5f;
            string thirdVar = "Hello World";
            bool isLearning = true;

            // or we can simply write variables only using 'var' keyword
            var firstName = "Habibur";
            var age = 26;
            var isActive = true;


            Console.WriteLine("Integer type=" + firstVar + "\n Float type = " + secondVar
            + "\n String type = " + thirdVar + "\n Boolean type = " + isLearning);

            Console.WriteLine("\n Using only var Keyowrd");
            Console.WriteLine("\nName:" + firstName);
            Console.WriteLine("\nAge:" + age);
            Console.WriteLine("\nIs Active:" + isActive);

            //Constants have to be constants, they cant be changed
            const float pi = 3.14f; //3.14f, here f stands for float.
            Console.WriteLine("Value of pi =" + pi);

            /**we cant now put other value on variable 'pi'
                for example:
                const float pi =3.14f;
                pi = 10; //not possible
            */



            //Converting types to another

            string number = "5";
            int num = int.Parse(number);

            Console.WriteLine("Converted Value=" + num);



        }
    }
}