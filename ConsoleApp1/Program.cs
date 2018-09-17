using System;

namespace CodeHéro
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            //-VARIABLES-//
            string choix1 = " ";
            string choix2 = " ";
            string choixDiv = " ";
            string choix3 = " ";
            string choix4 = " ";
            string choix5 = " ";
            string passWord = "";
            Random rand = new Random();
            int chance = rand.Next(1, 101);

            //-Couleur de texte-//
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //-Début de l'histoire-//
            
            Console.WriteLine("Greetings and welcome to this Stanley Parable Simulator.");
             Console.WriteLine();
            Console.WriteLine("Press Enter to Continue.");
                Console.ReadKey();
                Console.Clear();

            Console.WriteLine("And so, it begins.");
             Console.WriteLine();
            Console.WriteLine("Press Enter to keep going.");
                Console.ReadKey();
                Console.Clear();

            Console.WriteLine("I mean, yeah, it'll probaly begin soon...");
             Console.WriteLine();
            Console.WriteLine("I think you already know which key to press...");
                Console.ReadKey();
                Console.Clear();

            //-Premier Choix-//
            Console.WriteLine("To be honest, you still can wait, I won't mind... By the way, you can call me Narrator, that'll be nice of you. You want a cookie? I got plenty of those and I never know what to do with them.");
             Console.WriteLine();
            Console.WriteLine("If you want a cookie, press (Y), if you don't want a cookie and simply wanna play the Game, press (N). (Capitalizations are important)");
                choix1 = Convert.ToString(Console.ReadLine());
                Console.Clear();

            if (choix1 == "Y" )
                {
                    //-Histoire de l'arbre Mojo, conté par le Narrateur- -Première Fin-//
                    Console.WriteLine("Oh? Really? Well, since you seem to be enjoying, perhaps would you like to hear my story?");
                     Console.WriteLine();
                    Console.WriteLine("You must press on Enter... I mean, you can't really go back, now... I hope you're prepared for that.");
                        Console.ReadKey();
                        Console.Clear();

                    Console.WriteLine("So here's my story:");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("In the vast, deep forest of Hyrule... Long have I served as the guardian spirit...I am known as the Deku Tree...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Listen carefully to what I, the Deku Tree, am about to tell thee...Thy slumber these past moons must have been restless, and full of nightmares...As the servants of evil gain strength, a vile climate pervades the land and causes nightmares to those sensitive to it...Verily, thou hast felt it...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("The time has come to test thy courage... I have been cursed... I need you to break the curse with your wisdom and courage. Dost thou have courage enough to undertake this task?");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Thou hast verily demonstrated thy courage... I knew that thou wouldst be able to carry out my wishes... Now, I have yet more to tell ye, listen carefully...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine(" A wicked man of the desert cast this dreadful curse upon me...This evil man ceaselessly uses his vile, sorcerous powers in his search for the Sacred Realm that is connected to Hyrule...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("For it is in that Sacred Realm that one will find the divine relic, the Triforce, which contains the essence of the gods...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Before time began, before spirits and life existed... Three golden goddesses descended upon the chaos that was Hyrule...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Din, the goddess of power... Nayru, the goddess of wisdom... Farore, the goddess of courage...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Din... With her strong flaming arms, she cultivated the land and created the red earth.");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Nayru... Poured her wisdom onto the earth and gave the spirit of law to the world.");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Farore... With her rich soul, produced all life forms who would uphold the law.");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("The three great goddesses, their labors completed, departed for the heavens. And golden sacred triangles remained at the point where the goddesses left the world.");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Since then, the sacred triangles have become the basis of our world's providence. And, the resting place of the triangles has become the Sacred Realm.");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Thou must never allow the desert man in black armor to lay his hands on the sacred Triforce...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Thou must never suffer that man, with his evil heart, to enter the Sacred Realm of legend...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("That evil man who cast the death curse upon me and sapped my power... Because of that curse, my end is near...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Though your valiant efforts to break the curse were successful, I was doomed before you started...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Yes, I will pass away soon... But do not grieve for me... I have been able to tell you of these important matters...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("This is Hyrule's final hope... Go now to Hyrule Castle... There, thou will surely meet the Princess of Destiny...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Take this stone with you. The stone that man wanted so much, that he cast the curse on me...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("The future depends on thee... Thou art courageous... Shouldst thou ever lose thy way, seek a vision of the path from the Sheikah Stone that stands beside thy home.");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Navi the fairy... Help him to carry out my will... I entreat ye... Navi... Good...bye...");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("THE END!");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("BEDTIME STORY ENDING");
                        Console.ReadKey();
                        Console.Clear();
                    Console.WriteLine("Congratulation in getting the first ending! Thus this one is the easiest, you'll also get a crucial information. In this game, you must do every endings in order of unlocking the computer's content. There will be 7 words, forming a sentence. Your first Word : (Vincent)");
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                }

            else if (choix1== "N")
                {

                    //-Vrai Histoire et deuxième choix-//
                    Console.WriteLine("Oh, sure... Well, then. *The Narator cleared his throat, coughing clearly*");
                        Console.ReadKey();
                        Console.Clear();

                    Console.WriteLine("This is the story of a man named Stanley. Stanley worked for a company in a big building where he was Employee #427. Employee #427's job was simple: he sat at his desk in room 427 and he pushed buttons on a keyboard. Orders came to him through a monitor on his desk, telling him what buttons to push, how long to push them, and in what order.");
                     Console.WriteLine();
                    Console.WriteLine("This is what Employee #427 did every day of every month of every year, and although others might have considered it soul rending, Stanley relished every moment the orders came in, as though he had been made exactly for this job and Stanley was happy.");
                     Console.WriteLine();
                    Console.WriteLine("Then one day, something very peculiar happened, something that would forever change Stanley; something he would never quite forget. He had been at his desk for nearly an hour when he realized that not one single order had arrived on the monitor for him to follow.");
                     Console.WriteLine();
                    Console.WriteLine("No one had shown up to give him instructions, call a meeting, or even say 'hi.' Never in all his years at the company had this happened, this complete isolation. Something was very clearly wrong. Shocked, frozen solid, Stanley found himself unable to move for the longest time. But as he came to his wits and regained his senses, he got up from his desk and stepped out of his office.");
                     Console.WriteLine();
                    Console.WriteLine("(What should Stanley do?)");
                     Console.WriteLine();
                    Console.WriteLine("(A) Simply closes the door?;");
                    Console.WriteLine("(B) Waits for something to happen?;");
                    Console.WriteLine("(C) Walks out from his office and heads toward the hall?;");
                        choix2 = Convert.ToString(Console.ReadLine());
                        Console.Clear();

                    if (choix2 == "A")
                        {
                            //-Deuxième Fin-//
                            Console.WriteLine("(Scared, Stanley simply closed the door of his office, trembling in fear.)");
                             Console.WriteLine();
                                Console.ReadKey();
                            Console.WriteLine("But Stanley simply couldn't handle the pressure. What if he had to make a decision? What if a crucial outcome fell under his responsibility? He had never been trained for that! No, this couldn't go any way except badly.");
                             Console.WriteLine();
                            Console.WriteLine("The right thing to do now, Stanley thought to himself, is to wait. Nothing will hurt me. Nothing will break me. In here, I can be happy, forever. I will be happy. Stanley waited. Hours passed. Then days. Had years gone by? He no longer had the ability to tell.");
                             Console.WriteLine();
                            Console.WriteLine("But the one thing he knew, for sure, beyond any doubt, was that if he waited long enough, the answers would come. Eventually, some day, they would arrive. Soon, very soon now, this will end. He will be spoken too. He will be told what to do. Now it's just a little bit closer. Now it's even closer. Here it comes...");
                             Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            Console.WriteLine("Yet, nobody came... Never...");
                                Console.ReadKey();
                                Console.Clear();
                            Console.WriteLine("THE COWARD ENDING");
                                Console.ReadKey();
                                Console.Clear();

                            Console.WriteLine("Congratulation in getting the COWARD ending!In this game, you must do every endings in order of unlocking the computer's content. There will be 8 words, yet many endings, forming a sentence.");
                             Console.WriteLine();
                            Console.WriteLine("Oh! Before I forgot, here's the second word. Good job! (is)");
                                Console.ReadKey();
                                Console.Clear();
                                goto Start;
                        }

                    else if (choix2 == "B")
                        {
                            //-Choix Divergent-//
                            Console.WriteLine("... As I already said... Shocked, frozen solid, Stanley found himself unable to move for the LONGEST time. But as he came to his wits, I hope so, and regained his senses, he got up from his desk and STEPPED out of his office. Understood?");
                             Console.WriteLine();
                            Console.WriteLine("(What will Stanley do?)");
                             Console.WriteLine();
                            Console.WriteLine("(A) Goes toward the computer and search?;");
                            Console.WriteLine("(B) Simply Close the door?;");
                                choix3 = Convert.ToString(Console.ReadLine());
                                Console.Clear();

                                if (choix3 == "A")
                                    {
                                        //-Secret de l'Ordinateur-//
                                        Console.WriteLine("[Greetings, Employee #427. Please enter your password.]");
                                        Console.WriteLine();
                                        Console.WriteLine("(What will Stanley do?)");
                                        Console.WriteLine();
                                        Console.WriteLine("(A) Bash a bunch of random characters?;");
                                        Console.WriteLine("(B) He remembered the password;");
                                            choixDiv = Convert.ToString(Console.ReadLine());
                                            Console.Clear();
                        
                                    if (choixDiv== "A" && chance <= 1) //-Probabilitée de 1%-//
                                        {
                                                Console.Clear();
                                            Console.WriteLine("... YOU LUCKY MORON? How come you've been able to guess the Mother Fucking Password by simply bashing the fucking keyboard?!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            Console.WriteLine("THE END");
                                                Console.ReadKey();
                                                Console.Clear();
                                            Console.WriteLine("THE LUCKY ENDING");
                                                Console.ReadKey();
                                                Console.Clear();
                                            Console.WriteLine("Wow! You're extremely lucky! I mean... You only had a chance out of 100 to got that ending and I'm really serious. Anyway. As an Easter Egg lover, I'll give ya the final and most secret extra word. You deserved it. (yeah!)");
                                                Console.ReadKey();
                                                Console.Clear();
                                                    goto Start;
                                        }
                                    else if (choixDiv == "A" && chance > 1)
                                        {
                                                Console.Clear();
                                            Console.WriteLine("[Wrong Password!!!]");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.BackgroundColor = ConsoleColor.Blue;
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.White;
                                             Console.WriteLine();
                                            Console.WriteLine("A problem has been detected ad Windows has been shut down to prevent damage to your computer.");
                                             Console.WriteLine();
                                             Console.WriteLine();
                                            Console.WriteLine("A process or thread crucial to system operayion has unexpectedly excited or been terminated.");
                                             Console.WriteLine();
                                            Console.WriteLine("If this is the first time you've seen this Stop error screen, restart your computer. If this screen appears again, follow these steps:");
                                             Console.WriteLine();
                                            Console.WriteLine("Check to make sure any new hardware or software is properly installed. If this is a new installation, ask your hardware or software manufacturer for any Windows updates you might need.");
                                             Console.WriteLine();
                                            Console.WriteLine("If problems continue, disable or remove any newly installed hardware or software. Disable BIOS memory options such as caching or shadowing. If you need to use Safe Mode to remove or disable components, restart your computer, press F8 to select Advanced Startup Options, and then select Safe Mode.");
                                             Console.WriteLine();
                                            Console.WriteLine("Technical information:");
                                             Console.WriteLine();
                                            Console.WriteLine("*** STOP: 0x000000F4 (0x00000003, 0x86522B68, 0x86522CD4, 0x82C647E0)");
                                             Console.WriteLine();
                                             Console.WriteLine();
                                             Console.WriteLine();
                                            Console.WriteLine("Collecting data for crash dump ...");
                                            Console.WriteLine("Initializing disk for crash dump ...");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("THE END!");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("ERROR 404 ENDING");
                                                Console.ReadLine();
                                                Console.Clear();
                                            Console.WriteLine("Wow... You've destroyed my computer, you moron! Ugh... Anyway, you got an ending... Here's your third word anyway... Bitch. (the)");
                                                Console.ReadKey();
                                                Console.Clear();
                                                    goto Start;
                        
                                        }

                                    if (choixDiv== "B")
                                        {
                                            Console.WriteLine("[Please, Employee #427, enter the Correct Password.]");
                                            passWord = Convert.ToString(Console.ReadLine());
                                                if (passWord == "Vincent is the greatest teacher among all")
                                                    {
                                                        Console.WriteLine("[Correct Password. But...]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.WriteLine("[Sorry, servers are closed due to everyone being on a day off accorded by the day off given by your work's convention. Good Bye.]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.WriteLine("It... Appears that Stanley didn't got the notice, poor Stanley... And so, he headed back to his house, laughing softly as it seems he was extremely surprised and scared for nothing.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.WriteLine("THE END");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.WriteLine("THE GOOD ENDING");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.WriteLine("Congratulation, you managed to finish every ending in order of completing this game, thus, I'm quite sad to said that there's still one more ending. Accorded to what I know, you've been such of a nice game partner, I hope that you'll try to find the last ending.");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto Start;
                                                    }
                                                else if (passWord == "Vincent is the greatest teacher among all yeah!")
                                                    {
                                                            Console.Clear();
                                                        Console.WriteLine("[Secret Password typed.]");
                                                            Console.ReadLine();
                                                            Console.Clear();
                                                        Console.WriteLine("Oh... Uh..? Does it work? Okay, anyway... GREETINGS!!! I'm Chrys, developper of that massive 'Game where you're the Hero' Code. I must and have no other choice than saying thank you! Thank you for playing, but mostly, for being there. It took me more than 10 hours to complete that. I hope that it was on your liking. With that being said, have a good time!");
                                                            Console.ReadLine();
                                                            Console.Clear();
                                                        Environment.Exit(1);
                                                    }
                                                
                                                else
                                                    {
                                                            Console.Clear();
                                                        Console.WriteLine("[Wrong Password!!!]");
                                                            Console.ReadLine();
                                                            Console.Clear();
                                                                Console.BackgroundColor = ConsoleColor.Blue;
                                                            Console.Clear();
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                         Console.WriteLine();
                                                        Console.WriteLine("A problem has been detected and Windows has been shut down to prevent damage to your computer.");
                                                         Console.WriteLine();
                                                         Console.WriteLine();
                                                        Console.WriteLine("A process or thread crucial to system operation has unexpectedly excited or been terminated.");
                                                         Console.WriteLine();
                                                        Console.WriteLine("If this is the first time you've seen this Stop error screen, restart your computer. If this screen appears again, follow these steps:");
                                                         Console.WriteLine();
                                                        Console.WriteLine("Check to make sure any new hardware or software is properly installed. If this is a new installation, ask your hardware or software manufacturer for any Windows updates you might need.");
                                                         Console.WriteLine();
                                                        Console.WriteLine("If problems continue, disable or remove any newly installed hardware or software. Disable BIOS memory options such as caching or shadowing. If you need to use Safe Mode to remove or disable components, restart your computer, press F8 to select Advanced Startup Options, and then select Safe Mode.");
                                                         Console.WriteLine();
                                                        Console.WriteLine("Technical information:");
                                                         Console.WriteLine();
                                                        Console.WriteLine("*** STOP: 0x000000F4 (0x00000003, 0x86522B68, 0x86522CD4, 0x82C647E0)");
                                                         Console.WriteLine();
                                                         Console.WriteLine();
                                                         Console.WriteLine();
                                                        Console.WriteLine("Collecting data for crash dump ...");
                                                        Console.WriteLine("Initializing disk for crash dump ...");
                                                         Console.ReadLine();
                                                            Console.Clear();
                                                        Console.WriteLine("THE END!");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("ERROR 404 ENDING");
                                                            Console.ReadLine();
                                                            Console.Clear();
                                                        Console.WriteLine("Wow... You've destroyed my computer, you moron! Ugh... Anyway, you got an ending... Here's your third word anyway... Bitch. (the)");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                                goto Start;
                                                    }
                        
                                        }
                                        }

                                else if (choix3== "B")
                                    {
                                        Console.WriteLine("(Scared, Stanley simply closed the door of his office, trembling in fear.)");
                                        Console.WriteLine();
                                            Console.ReadKey();
                                        Console.WriteLine("But Stanley simply couldn't handle the pressure. What if he had to make a decision? What if a crucial outcome fell under his responsibility? He had never been trained for that! No, this couldn't go any way except badly.");
                                        Console.WriteLine();
                                        Console.WriteLine("The right thing to do now, Stanley thought to himself, is to wait. Nothing will hurt me. Nothing will break me. In here, I can be happy, forever. I will be happy. Stanley waited. Hours passed. Then days. Had years gone by? He no longer had the ability to tell.");
                                        Console.WriteLine();
                                        Console.WriteLine("But the one thing he knew, for sure, beyond any doubt, was that if he waited long enough, the answers would come. Eventually, some day, they would arrive. Soon, very soon now, this will end. He will be spoken too. He will be told what to do. Now it's just a little bit closer. Now it's even closer. Here it comes...");
                                        Console.WriteLine();
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Yet, nobody came... Never...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("THE COWARD ENDING");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Congratulation in getting the COWARD ending!In this game, you must do every endings in order of unlocking the computer's content. There will be 8 words, yet many endings, forming a sentence.");
                                        Console.WriteLine();
                                        Console.WriteLine("Oh! Before I forgot, here's the second word. Good job! (is)");
                                            Console.ReadKey();
                                            Console.Clear();
                                                goto Start;
                                    
                                    }
                                                
                        }
                    else if (choix2== "C")
                        {
                            //-Troisième Choix-//
                            Console.WriteLine("All of his co-workers were gone. What could it mean? Stanley decided to go to the meeting room; perhaps he had simply missed a memo.");
                            Console.WriteLine("All of his co-workers were gone. What.. *ahem* ..ah, excuse me.");
                            Console.WriteLine("How wonderful. Stanley was alone. Finally. This is great, he thought to himself. This is what I've wanted all along. I got what I wanted.");
                            Console.WriteLine("Stanley decided to go to the meeting room to check on his co-workers. He never functioned well by himself, and constantly needed support and guidance from others, so the thought of total solitude was terrifying to him.");
                             Console.WriteLine();
                            Console.WriteLine("All of his co-workers were... wait, no. This isn't the right office is it? Is this Stanley's office?");
                            Console.WriteLine("'How long was I sitting there', Stanley wondered to himself. Minutes? Days? Centuries? Did something crucial happen while my senses were turned? He made a note to be more careful with time from now on.");
                            Console.WriteLine("A soft wind blew outside and perhaps rain started, and if it did it stopped shortly after. Stanley hoped that he would one day see weather.");
                            Console.WriteLine("Stanley this, Stanley that, Stanley this, Stanley that, Stanley this, Stanley that, Stanley this, Stanley that.");
                            Console.WriteLine("Someone was following Stanley. He was sure of it. If he checked over his shoulder now, he would shortly catch them. It was only a matter of time.");
                            Console.WriteLine("Even now, Stanley's office was a distant memory. What did it look like? There was a computer perhaps.. and a painting. Was it a painting, or a photo? He could no longer recall.");
                             Console.WriteLine();
                            Console.WriteLine("The meeting room, yes, that's where everyone would be. Stanley just needed to get to the meeting room and from then on he would never be alone ever again.");
                            Console.WriteLine("Just a step through this door, Stanley thought to himself, that's all I need. If I can make it through this door, I can make it through them all.");
                            Console.WriteLine("Already this was uncomfortable, and Stanley decided that as soon as he found a new space he felt safe in, that he would never leave it again in his life.");
                            Console.WriteLine("Stanley had never seen the office this brightly lit. Was it a sign or something? He hoped it was. He hoped very much that it was.");
                            Console.WriteLine("Wait, Stanley thought to himself. Am I sure that the orders stopped coming in? How is that possible? They never stopped. Surely I was mistaken. [Stanley returns to his office] No. No, the orders were still missing... for now.");
                            Console.WriteLine("I can't wait to tell this story to my co-workers, Stanley thought. How amusing they'll find it. Oh, won't we all just laugh and laugh at the time I thought everyone had gone missing.");
                            Console.WriteLine("Stanley knew the office layout like the back of his hand. It was only a matter of time before he found the others, wherever they were. Just a matter of time...");
                             Console.WriteLine();
                            Console.WriteLine("(What should Stanley do?)");
                             Console.WriteLine();
                            Console.WriteLine("(A) Go to the meeting room?;");
                            Console.WriteLine("(B) Standing in one spot?;");
                            Console.WriteLine("(C) Touch door 430 5 times?;");
                                choix4 = Convert.ToString(Console.ReadLine());
                                Console.Clear();

                                if (choix4== "A")
                                    {
                                        Console.WriteLine("Yet there was not a single person here either. Feeling a wave of disbelief, Stanley decided to go up to his boss's office, hoping he might find an answer there.");
                                         Console.WriteLine();
                                        Console.WriteLine("(What should Stanley do?)");
                                         Console.WriteLine();
                                        Console.WriteLine("(A) Go to his boss's office?;");
                                        Console.WriteLine("(B) Stop by and go in the broom closet?;");
                                            choix5 = Convert.ToString(Console.ReadLine());
                                            Console.Clear();
                                                
                                                if (choix5 == "A")
                                                    {
                                                           
                                                        Console.WriteLine("Stepping into his manager's office, Stanley was once again stunned to discover not an indication of any human life. What could it mean, Stanley wondered aloud to nobody. He began wildly tearing through papers on the boss's desk, pulling books off the shelf, looking behind paintings, desperate for clues to his situation. But his attention was caught by a keypad behind the boss's desk. What could its purpose be? In fact, this keypad guarded the terrible secret that lay buried below his feet. And so the boss had assigned it an extra secret PIN #. 2845. But of course, Stanley couldn't possibly have known this.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("Stanley began entering random codes into the keypad, knowing full well that the sheer statistical unlikelihood that this would result in a correct combination. If he knew that the combo was 2-8-4-5, it would be another story entirely. But no. No, this is what he was going to do instead.");
                                                        Console.WriteLine("Stanley just sat around twiddling his thumbs. Trying to input anything on the device was useless, since he could never possibly know that the combination was 2-8-4-5.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("(Stanley types : 2-8-4-5.)");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("For god's- but it turns out that the panel's emergency override kicked in, and the door just opened all by itself, and Stanley just got the hell along with the story. Well woop-de-doo.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("No one could have possibly knows that it was leading to a room filled with Employee's, everyone was there. #430, #417... Everyone. They all gathered for a reason. It was for Stanley. It was his birthday!");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.Write("T H E  E N D !");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("THE BIRTHDAY ENDING");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("YOU FINALLY MADE IT!!! Congratulation! This is the seventh ending, the most enjoyable one! As I said already, if you complete the seven possible endings, it'll give you a secret password that'll be able to use with the computer. Now, finally... You've done it! Here's the word you wre craving for... (all)");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                                goto Start;
                                                    }
                                                else if (choix5== "B")
                                                    {
                                                        Console.WriteLine("Stanley stepped into the broom closet, but there was nothing here, so he turned around and got back on track. There was nothing here. No choice to make, No path to follow, Just an empty broom closet. No reason to still be here.");
                                                        Console.WriteLine("It was baffling that Stanley was still just sitting in the broom closet. He wasn't even doing anything, At least if there were something to interact with, he'd be justified in some way. As it is, he's literally just standing there, doing sweet FA.");
                                                        Console.WriteLine("Are you... Are you really still in the broom closet? Standing around doing nothing? Why? Please offer me some explanation here; I'm- I'm genuinely confused. You do realize there's no choice or anything in here right? If I said, (Stanley walked past the broom closet) at least you would have had a reason for exploring it to find out.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("But it didn't even occur to me because literally this closet is of absolutely no significance to the story whatsoever. I never would've thought to mention it. Maybe to you, this is somehow it's own branching path. Maybe, when you go talk about this with your friends, you'll say:");
                                                        Console.WriteLine("(OH!DID U GET THE BROOM CLOSET ENDING ? THE BROOM CLOSET ENDING WAS MY FAVORITE!XD) ... I hope your friends find this concerning.");
                                                        Console.WriteLine("Stanley was fat and ugly and really, really stupid. He probably only got the job because of a family connection; that's how stupid he is. That, or with drug money. Also, Stanley is addicted to drugs and hookers. Well, I've come to a very definite conclusion about what's going on right now. You're dead.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("You got to this broom closet, explored it a bit, and were just about to leave because there's nothing here, when a physical malady of some sort shut down your central nervous system and you collapsed on the keyboard. Well, in a situation like this, the responsible thing is to alert someone nearby so as to ensure that your body is taken care of, before it begins to decompose. HELLO!? ANYONE WHO HAPPENS TO BE NEARBY!! THE PERSON AT THIS COMPUTER IS DEAD!! HE OR SHE HAS FALLEN PREY TO ANY NUMBER OF YOUR COUNTLESS HUMAN PHYSIOLOGICAL VULNERABILITIES. IT'S INDICATIVE OF THE LONG-TERM SUSTAINABILITY OF YOUR SPECIES. PLEASE REMOVE THEIR CORPSE FROM THE AREA AND INSTRUCT ANOTHER HUMAN TO TAKE THEIR PLACE AT THE COMPUTER, MAKING SURE THEY UNDERSTAND BASIC FIRST-PERSON VIDEO GAME MECHANICS, AND FILLING THEM IN ON THE HISTORY OF NARRATIVE TROPES IN VIDEO GAMING, SO THAT THE IRONY AND INSIGHTFUL COMMENTARY OF THIS GAME IS NOT LOST ON THEM.");
                                                        Console.WriteLine("Alright, when you've done that, just step out into the hallway.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("(Stanley steps out into the hallway)");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("Ah, second player! It's good to have you on board. I guarantee you can't do any worse than the person who came before you.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("(Stanley steps back into the broom closet)");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("You too?! Unbelievable. I'm at the mercy of an entire species of invalids. Perhaps there's a monkey nearby you can hand the controls to? A fish? A fungus? Look, you can hammer out the details; I'm not particularly picky.");
                                                        Console.WriteLine("I'll just be waiting for when you're ready to pick up the story again.");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("THE END");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("THE BROOM CLOSET ENDING");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        Console.WriteLine("Wow!I mean, that ending is pretty funny xD... Anyway, you've succeed in getting the sixth ending! Almost done, here's your magic word! (among)");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                                goto Start;
                                                    }
                                    }

                                else if (choix4== "B")
                                    {
                                        Console.WriteLine("(Stanley stood there, not doing anything.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Stanley just stood there doing nothing at all. He seems to think I have nothing better to do wiy time than to sit around and describe every facinating little detail of his inability to do anything. This is why Stanley and I are on such good terms.");
                                        Console.WriteLine("Stanley stood for a long time in one spot. It's part of a game. He likes to see how long he can go without dying. So far he's doing excellent, and if he just stays right where he is, I'm sure he'll keep up that good momentum. Let's observe the genius at work...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("THE END");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("THE WAITING NARRATOR ENDING");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Great! you've managed to make it to the half of this small game! Here's your fourth word! (greatest)");
                                            Console.ReadKey();
                                            Console.Clear();
                                                goto Start;
                                    }
                                else if (choix4== "C")
                                    {
                                        Console.WriteLine("Oh, please. Are you really just doing this for the achievement? Click a door five times? Is that all that you think an achievement is worth? No, no, no, no, no. I can't just give these merits away for such little effort. A measly five clicks? Now suppose you were to click the door 20 times. I would say that's the kind of effort that warrants recognition.");
                                            Console.ReadKey();
                                        Console.WriteLine("(Stanley went doing so.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Hmm, I have to say I'm still not feeling the satisfaction of witnessing true effort for a noble cause. Perhaps 50 clicks will do it. Yes, almost certainly 50 clicks.");
                                            Console.ReadKey();
                                        Console.WriteLine("(This time, again, Stanley followed the lead.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("No, no. I'm-I'm still not feeling it. I- I want this achievement to have meant something. It has to be a true reward for valiant effort. I want to some hustle, Stanley! I want to see commitment, a willingness to go all the way no matter what the cost! Why don't you go put 20 clicks into door number 417?");
                                            Console.ReadKey();
                                        Console.WriteLine("(Stanley went doing so as well, quite devoted to the task.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Oh, great. Now go click a few times on door 437.");
                                            Console.ReadKey();
                                        Console.WriteLine("(Stanley, indeed, went clicking.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Excellent! I think we're getting somewhere. Now door 415, let's give it 10 clicks or so.");
                                            Console.ReadKey();
                                        Console.WriteLine("(Stanley was surprised when door 415 squeaked, like a dog toy, as he pressed on it.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Now back to door number 437!");
                                            Console.ReadKey();
                                        Console.WriteLine("(Walking sure is easy for Stanley.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Let's see. How about you click on... well, I don't know... the copy machine!");
                                            Console.ReadKey();
                                        Console.WriteLine("(Stanley always loved playing with copy machine. Pressing buttons is an art for him.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Alright, back to room 417! I'm really feeling it now, I think we're getting somewhere!");
                                            Console.ReadKey();
                                        Console.WriteLine("(Stanley was obviously enjoying the game.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Okay, now go climb on Employee #419's desk!");
                                            Console.ReadKey();
                                        Console.WriteLine("(Surprised, Stanley did so anyway.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Yes! This is great! You're putting it all on the line, Stanley, I like that! Alright, let's keep it up! Go give me a few clicks on door 416!");
                                            Console.ReadKey();
                                        Console.WriteLine("(Stanley went clicking on the door 416.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("We've almost got it! Now the copy machine, do that one again!");
                                            Console.ReadKey();
                                        Console.WriteLine("(Excited, Stanley came back to the copy machine.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Finish it off, Stanley! 5 CLICKS ON DOOR 430!");
                                            Console.ReadKey();
                                        Console.WriteLine("(With all his forces and determination, Stanley went clicking on door 430, suprised by the Narrator's excitement.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("YES!!! WE DID IT! Oh, wow, that felt amazing. Oh, you really earned it, Stanley. Nothing could hold you back. Yes, I'm very proud of how far we've come today. Just think, only a few minutes ago, you believed an achievement was worth five little clicks. Really now, what were you thinking?");
                                            Console.ReadKey();
                                        Console.WriteLine("(Exhausted, Stanley lifted his thumb up.)");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("THE END");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("THE EXHAUSTED ENDING");
                                            Console.ReadKey();
                                            Console.Clear();
                                        Console.WriteLine("Perfect! You seems to be enjoying this game quite well, reaching the fifth ending and, obviously, it's special word! (teacher)");
                                            Console.ReadKey();
                                            Console.Clear();
                                                goto Start;
                                    }

            }
            }
        
        Console.WriteLine("Oops... It appears that you've accidentally misunderstood that game's guidance... Capitalization are important, yet you've broke the game by forgetting them or simply tried to play as the smartass... Anyway, I'm kind, so this program won't stop, instead, you'll just reastart from the stop. I know, I know, I am an angel, but shh, just keep going and restart properly, now.");
            Console.ReadKey();
            Console.Clear();
            goto Start;
        }
    }
}
