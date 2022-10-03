using LinkedListLibrary;
using System;
using System.Collections.Generic;

namespace ListTest
{
    class ListTest
    {
        static void Main(string[] args)
        {
            var list = new List();  // Create List container

            // Create data to store in List
            bool aBoolean = true;
            char aCharacter = '$';
            int anInteger = 34567;
            string aString = "hello";

            // Use List insert methods
            list.InsertAtFront(aBoolean);
            list.Display();
            list.InsertAtFront(aCharacter);
            list.Display();
            list.InsertAtBack(anInteger);
            list.Display();
            list.InsertAtBack(aString);
            list.Display();

            // Remove data from list and display after each removal
            try
            {
                object removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();
            }
            catch (EmptyListException emptyListException)
            {
                Console.WriteLine($"\n{emptyListException}");
            }
        }
    }
}