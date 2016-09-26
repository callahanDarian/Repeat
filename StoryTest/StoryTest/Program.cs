using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tutorial :");
            Console.WriteLine("Press Enter to progress through the story");
            Console.WriteLine("Your progress will not be saved");
            Console.ReadLine();
            Console.WriteLine("You will be given choices,");
            Console.WriteLine("Each choice will have a number next to it");
            Console.WriteLine("Type in the number, and only the number, then hit enter to choose a choice");
            Console.ReadLine();
            Console.WriteLine("Do you understand?");
            Console.WriteLine(" 1) Yes");
            Console.WriteLine(" 2) No");
            string choiceTutorial = Console.ReadLine();
            if (choiceTutorial == "1")
            {
                Console.WriteLine("End of Tutorial");
            }
            else
            {
                if (choiceTutorial == "2")
                {
                    Console.WriteLine("Yes you do.");
                }
                else
                {
                    Console.WriteLine("If you fail to make an available choice again, you will be asked to make one of the available choices.");
                }

            }
            Console.ReadLine();
            Console.WriteLine("   -   Repetition   -   ");
            Console.ReadLine();
            Console.WriteLine(" 'So, we made it back here again,'");
            Console.ReadLine();
            Console.WriteLine(" 'It seems like we're in a cycle of Repetition.'");
            Console.ReadLine();
            Console.WriteLine(" 'I can let you go again, if you would like.'");
            Console.ReadLine();
            Console.WriteLine(" 'Maybe you can finish before the tragities catch up to you.'");
            Console.ReadLine();
            Console.WriteLine(" 'I know I've said this alot, but I'm sorry,");
            Console.ReadLine();
            Console.WriteLine("  again...'");
            Console.ReadLine();
            Console.WriteLine(" 'I'll send you back, lets hope that not everything repeats itself.'");
            Console.ReadLine();
            Console.WriteLine(" '...'");
            Console.ReadLine();
            Console.WriteLine(" 'I'm sorry.'");
            Console.ReadLine();
            Console.WriteLine("Please enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("You have chosen '" + name + "' as your name.");
            Console.ReadLine();
            Console.WriteLine("- - Day 1 - -");
            Console.ReadLine();
            Console.WriteLine(" " + name + " : So, first day of school, it shouldn't be too bad. I got accepted into a fancy school, so it should have");
            Console.WriteLine(" better people, both students and staff.");
            Console.ReadLine();
            Console.WriteLine(" ... Oh... the door is locked. I guess I can go find a side door or the back door.");
            Console.ReadLine();
            Console.WriteLine(" Warmth washed over me, and I thought that I saw someone out of the corner of my eye, but as I looked around, I");
            Console.WriteLine(" couldn't see anyone.");
            Console.ReadLine();
            Console.WriteLine(" As I was walking around the school, it started to rain, and I saw someone walking towards me.");
            Console.ReadLine();
            Console.WriteLine(" ? : 'Hey, is the frount door locked, too?'");
            Console.ReadLine();
            Console.WriteLine(" " + name + " : 'Yeah, it is, actually'");
            Console.ReadLine();
            Console.WriteLine(" ? : 'Oh, I was running late and thought that no one would notice if I went in through the side door, but that");
            Console.WriteLine(" one is locked.'");
            Console.ReadLine();
            Console.WriteLine(" " + name + " : 'Did you already try the back door?'");
            Console.ReadLine();
            Console.WriteLine(" ? : 'No, I just assumed that it would be locked, too, but it might be the only option we have right now.'");
            Console.ReadLine();
            Console.WriteLine(" We both started to make our way to the back door,");
            Console.ReadLine();
            Console.WriteLine(" this boy is short, the top of his head only reaches the center of my chest, everything about him seems");
            Console.WriteLine("small and petit.");
            Console.ReadLine();
            Console.WriteLine(" We walked in in awkward silence, and it looked like he was struggling to say something.");
            Console.ReadLine();
            Console.WriteLine(" I think he might be one of those shy kids.");
            Console.ReadLine();
            Console.WriteLine("  - Try to start a conversation? -");
            Console.WriteLine(" 1) Yes");
            Console.WriteLine(" 2) No");
            int a = 0;
            while (a < 1)
            {
                string choiceConversationPhilip = Console.ReadLine();
                if (choiceConversationPhilip == "1")
                {
                    Console.WriteLine(" " + name + " : 'I never got your name, mine's " + name + ".'");
                    Console.ReadLine();
                    Console.WriteLine(" Philip : 'My name is Philip.'");
                    Console.ReadLine();
                    Console.WriteLine(" His face grew a light shade of pink as he said that, but it quickly faded.");
                    a++;
                }
                else
                {
                    if (choiceConversationPhilip == "2")
                    {
                        Console.WriteLine(" I decided against starting a conversation, I might just make things more awkward than they already are.");
                        Console.ReadLine();
                        Console.WriteLine(" We walked for a while before he suddenly spoke up, and it sounded like he was forcing himself.");
                        Console.ReadLine();
                        Console.WriteLine(" Philip : 'My name is Philip, by the way.'");
                        Console.ReadLine();
                        Console.WriteLine(" His voice cracked durring his sentence, causing him to briefly flush a light shade of pink.");
                        Console.ReadLine();
                        Console.WriteLine(" " + name + " : 'My name's " + name + ", it's nice to meet you.");
                        a++;
                    }
                    else
                    {
                        Console.WriteLine(" You have not chosen an available answer");
                        Console.WriteLine(" Please imput choice 1 or 2");
                    }
                }
            }
            Console.ReadLine();
            Console.WriteLine(" Philip : 'I hope you dont take this the wrong way, but I'm glad that you got stuck out here with me, being stuck in the");
            Console.WriteLine(" rain with someone else is better than being stuck out alone.'");
            Console.ReadLine();


        }
    }
}
