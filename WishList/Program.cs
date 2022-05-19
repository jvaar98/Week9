using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);


            myWishList.Add("coffe machine");
            myWishList.Add("kohvi kruus");
            myWishList.Add("jahu");
            myWishList.Add("puurkaev");

            Console.WriteLine(myWishList.Count);

            foreach (string wish in myWishList)
            {
                Console.WriteLine(wish);
            }



        }
    }
}