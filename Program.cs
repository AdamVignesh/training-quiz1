namespace quiz2
{
    internal class Program
    {
        List <string>myList = new List<string>();

        public void addChocolates(string clr, int qnty)     //adding chocolates on top of the dispenser
        {
            for (int i =0;i<qnty;i++)
            {
                myList.Insert(0, clr);
            }
        }

        public string[] removeChocolates(int qnty)              //removing from top
        {
            string[] arr = new string[qnty];
            for(int i=0;i<qnty;i++)
            {

                arr[i] = myList[0];
                myList.RemoveAt(0);

            }
            return arr;
        }

        public string[] dispenseChocolates(int qnty)
        {
            string[] arr = new string[qnty];
            for (int i = 0; i < qnty; i++)
            {
                int len = myList.Count();
                arr[i] = myList[len-1];
                myList.RemoveAt(len-1);

            }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}