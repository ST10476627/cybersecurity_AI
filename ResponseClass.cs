using System;

namespace ai_chats
{
    public class ResponseClass
    {
        public static void Respond(string input)
        {
            input = input.ToLower();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("LUMI: ");

            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm doing great and you");

            }
            else if (input.Contains("How do i avoid phishing"))
            {
                Console.WriteLine("Use strong passwords with symbols and numbers and don't tell your password to anyone.");
            }
            else if (input.Contains("what is phishing"))
            {
                Console.WriteLine("Phishing is a cyberattack where scammers impersonate reputable through" +
                    "emails,text or phones to trick individuals into revealing personal information.");
            }
            else if (input.Contains("what is ransomware"))
            {
                Console.WriteLine("Ransomware is a type of malicious software that encrypts a victim's files or locks them out of their system, demanding a ransom payment to restore access.");

            }
            else if (input.Contains("what is cybersecurity"))
            {
                Console.WriteLine("Cybersecurity is the practice of protecting computers, servers, mobile devices, electronic systems, networks, and data from digital attacks, theft, and damage.");

            }
            else if (input.Contains("what is malware"))
            {
                Console.WriteLine("Malware is a type of software designed to harm, exploit, or otherwise compromise the security of a computer system or network. It includes viruses, worms, trojans, ransomware, spyware, adware, and other malicious programs.");
            }
            else if (input.Contains("Safe browsing")) 
            {
                Console.WriteLine("Safe browsing is the practice of using the internet in a way that minimizes the risk of encountering harmful content, such as malware, phishing scams, and other online threats. It involves being cautious about the websites you visit, avoiding clicking on suspicious links, and keeping your software and security measures up to date.");
            }
            

            else
        
               Console.WriteLine("I don’t understand, try again.");
                    Console.ResetColor();
                }


            }
        }

    

