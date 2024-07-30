using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IEnumerable<string> myEnumerable= new List<string>{"BSCS","BSIS","BSIT"};


            Console.WriteLine("**********IENUMERABLE**************");
            int index= 0;
            foreach(var items in myEnumerable){
                 
                 index++;
                Console.WriteLine($"{index}: {items}");

            }

            Console.WriteLine("\n**********ICOLLECTION**************");

            ICollection<string> myCollection= new List<string>{"Test"};

            foreach(var items in myCollection){

                Console.WriteLine($"These are the list of collections: {items}");
            }


            Console.WriteLine("\n**********ICOLLECTION DEMONSTRATION 2**************");

            var listOfNumbers = new int [] {1,2,3,4,5,6};

            ICollection<int> list= listOfNumbers;

            //Default value
            foreach(var items in list){

                Console.WriteLine($"{items}");

            }

            
            Console.WriteLine("\n**********ICOLLECTION DEMONSTRATION 3**************");


            ICollection<int> col2= new List<int>{1,34,56,4,11,16};

            col2.Add(1);
            col2.Remove(4);
            
            foreach(var items in col2){

                Console.WriteLine($"This is the new list of ICollection: {items}");

            }


            col2.Clear();
            foreach(var items in col2){

                Console.WriteLine($"Clear list: {items}");

            }


            var myList= new List<string>(){"List1","List2","List3"};
            myList.Add("List5");
            myList.Add("List4");
            myList.Add("List6");
            myList.Remove("List1");



            foreach(var items in myList){

                Console.WriteLine($"These are the list: {items}");
                
            }

            var s= myList[2];
            Console.WriteLine($"{s}");


            var myList2= new List<string>();
            myList2.Add("List5");
            myList2.Add("List4");
            myList2.Add("List6");
            myList2.Remove("List1");
            myList2.AddRange(new[]{"List9","List10"});



            foreach(var items in myList2){

                Console.WriteLine($"These are the list: {items}");
                
            }


            //simple array declarion with initial value
            var myArray = new int [] {1,2,3};


            int [] number = new int[]{1,2,3};

            //same as 
            string [] myArray2= new string[] {"Montemor","Jerald"};

            string [][] multi= new string[3][]{
                new string[3]{"Hello","Hello","Hello"},
                new string[3]{"Hello","Hello","Hello"},
                new string[3]{"Hello","Hello","Hello"}
            };


            for(int row=0;row <multi.Length;row++){

                   foreach(var items in multi[row]){

                            Console.WriteLine($"{row} == {items}");
                   }
            }



            


        }
    }
}


