using System;
using System.Runtime.InteropServices;

namespace MediaPlayer
{
    public class Bottom
    {
        Album album1 = new Album();
        //string Answer = Console.ReadLine();
        int _next = 0;

        public void play()
        {
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(0).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(0).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(0).time);
            Console.WriteLine("<              [pause]              >");
        }

        public void next()
        {
            _next = _next + 1;
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(_next).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(_next).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(_next).time);
            Console.WriteLine("<              [pause]              >");
        }

        public void previous()
        {

        }

        public void Stop()
        {
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(0).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(0).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(0).time);
            Console.WriteLine("<               [play]               >");
        }

        public void add()
        {
            Console.Write("input name = ");
            string input = Console.ReadLine();
            Console.Write("input a = ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            album1.Addmusic(input, input1, input2);
        }

        public void ask()
        {
            album1._Album();
            //add();
         UP:
            //Bottom bottom = new Bottom() ;
            Console.WriteLine("     ");
            Console.Write(" Input for press bottom : ");
            string Answer = Console.ReadLine();
            Console.WriteLine("     " + Answer);

            switch (Answer)
             {
                 case "1":
                    play();
                    goto UP;
                     break;
                case "2":
                    next();
                    goto UP;
                    break;
                case "3":
                    previous();
                    break;
                case "4":
                    Stop();
                    break;
                case "0":
                    add();
                    break;
                default:
                    goto UP;
                    break;
            }
        }
    }
}
