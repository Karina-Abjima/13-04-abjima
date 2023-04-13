  namespace Test
{
    class A
    { public static int a, b, sum;

       
      public static void ll()
        {
            LinkedList<int> L = new LinkedList<int>();
            L.AddFirst(1);
            L.AddFirst(2);
            L.AddFirst(4);
            L.AddLast(3);
            //L.AddAfter(L<int>, 6);
            foreach (int i in L)
            {
                Console.WriteLine(i);
            }
        }
        public void M1()//for extension method
        {
            Console.WriteLine("Method Name: M1");
        }

        public void M2()//for extension method example
        {
            Console.WriteLine("Method Name: M2");
        }
        public static void SomeMethod()
        {
            // Locking the Shared Resource for thread
            lock (lockObject)
            {
                Console.Write("[Welcome");
                Thread.Sleep(1000);
                Console.WriteLine("home");
            }
        }


        public static void Main(String[] args)
        {

            ll();//linked list
            //lambda function example
            var resultsum = (int a, int b) =>
            {
                int Totalsum = a + b;
                return Totalsum;
            };


            Console.WriteLine("Total sum: " + resultsum(5, 6));//lambda function resultsum
            A g = new A();//m4 and m5 extended
            g.M1();
            g.M2();
            g.M4();
            g.M5("method Name: M5");//extension method used here
            object lockObject = new object();

            Thread thread1 = new Thread(SomeMethod)
            {
                Name = "Thread 1"
            };
            Thread thread2 = new Thread(SomeMethod)
            {
                Name = "Thread 2"
            };
            Thread thread3 = new Thread(SomeMethod)
            {
                Name = "Thread 2"
            };
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadKey();


        }
            
    }
    static class AExtender
    {
        public static void M4(this A g)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5
        public static void M5(this A g, string str)
        {
            Console.WriteLine(str);
        }
    }
}