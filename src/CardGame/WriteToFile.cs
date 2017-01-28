namespace CardGame
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    public static class WriteToFile
    {
        public static void Write(List<Player> players)
        {
            var lines = GetLines(players);
            using (StreamWriter w = File.AppendText("output.txt"))
            {
                w.WriteLine("****New Game*****");
                foreach (var line in lines)
                {
                    w.WriteLine(line);
                }
            }
                
        }

        static List<string> GetLines(List<Player> players)
        {
            var lines = new List<string>();

            foreach (var player in players)
            {
                var text = new StringBuilder();
                text.Append("Players #:");
                text.Append(player.PlayerId + ":");
                foreach (var hand in player.Hand)
                {
                    text.Append(GetHandValue(hand.Value));
                    text.Append(hand.Suit);
                    text.Append("-");
                }
                lines.Add(text.ToString().Remove(text.Length - 1));
            }

            return lines;
        }

        static string GetHandValue( int value)
        {
            if (value == 10)
            {
                return "J";
            }
            if (value == 11)
            {
                return "Q";
            }
            if (value == 12)
            {
                return "K";
            }
            if (value == 12)
            {
                return "A";
            }
            return value.ToString();
        }
    }
}
