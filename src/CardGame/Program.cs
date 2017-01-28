using System;

/*
The output will be appended to text file output.txt in the bin folder
This code can be further improved my creating interfaces and injecting them
For instance an interface can be written for writing an output and then there cab be multiple implementations 
like writing to file or writting to a log file etc
*/
namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the deck and give it to the dealer
            var deck = new Deck();
            // dealer accepts the deck and the no of players and card to given to each player
            var dealer = new Dealer(5, deck, 5);
            dealer.Deal();
            WriteToFile.Write(dealer.Players);
            Console.WriteLine("Written to output.txt in the bin folder. Press a key to exit.");
            Console.ReadLine();
        }
    }
}
