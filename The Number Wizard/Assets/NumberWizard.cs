using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int Maximum = 1000;
    int Minimum = 1;
    int guess;
    int patience = 0;
    // Use this for initialization
    void Start() {
        guess = (Maximum + Minimum) / 2;
        print("Welcome to this little space of code that I materialize in.");
        print("As a helpful note, you may want to click that play button a couple of times to get it to work. Don't know why, it might be just me. I'll just annoy the programer until they fix this conundrum.");
        print("Anyway, since it's been a while since good old 2016, how about you to think of a number from 1 to 1000. And without telling me, I shall make a guess of what that number is.");
        print("If it's bigger than my guess, then I command you to press the up arrow." +
              " If it's smaller than my guess, then would you kindly please press the down arrow." + " Press the enter key if I am correct.");
        print(" So let us start. Is your number " + Random.Range(1,1000) + "?");
        Maximum++;
    }

    // Update is called once per frame
    void Update() {
        if (patience < 30)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Minimum = guess;
                guess = (Maximum + Minimum) / 2;
                MakeGuess();
                patience++;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Maximum = guess;
                guess = (Maximum + Minimum) / 2;
                MakeGuess();
                patience++;
            }

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown("enter"))
            {

                print("Ha, nothing like little one dimensional games to waste what little time you mortals have left.");
                if (patience == 1)
                {
                    print("And it only took you only one turn! Hey, that's pretty good. I can even say that I'm number one, since I am the one who guessed it first time.");
                   
                }
                else if (patience > 1 && patience < 10)
                {
                    print("And it only took you a feeble amount of " + patience + " turns! Took you long enough. ");
                    
                }
                else if (patience == 10) {
                    print("And it only took you 10 turns to get it right. A bit too much but I'll let it slide.");
                    
                }
                else if (patience >10 && patience < 15) {
                    print("And it took you a long period of " + patience + "  turns. Either you enjoy your suffering or you are just some unlucky one dimensional mortal.");
                    
                }else if (patience == 15)
                {
                    print("And oh boy, it took you at least 15 times. You are really trying here. Aren't you?");
                }
                else if (patience >15 && patience < 20) {
                    print("And it took you... " + patience + " tries... Look buddy, I'm not sure if you notice. But the number has been stuck as the same number for a bit over 5 turns ago. Why?");
                    
                }
                else if (patience == 20)
                {
                    print("You're getting into some deep water here neanderthal. You better watch it!");
                }
                else if (patience > 20 && patience < 29) {
                    print("And it... took... you... "+patience+" times. Usually when I wake up in the morning, I ask myself 'What will I put up today'? NOT THIS! You're lucky it didn't take you 30 turns. ");
                    
                }else if (patience == 29)
                {
                    print("Look kid or adult (get triggered), if you really want to find out what happens when you go over the limit. Then you are going to have a bad time. Don't say I didn't warn you.");
                }
                //Must Fix. Start\
                print("So, do you want to press the left arrow key to reset or the right one to end it all?");
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Restart();
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    print("So you finally decided to end your suffering. Welp, I'll just leave you here in this empty void. Remember, never trust a wizard, they might turn you into a goat!");
                    Application.Quit();
                }
                //Must Fix. End/
            } 
            //NOTE: The infinte repeating messages is intentional. 
        }else if (patience == 30) {
            print("THAT'S ENOUGH! I'm okay with saying the same thing for 29 tries, BUT I CROSS THE LINE A 30! YOU JUST WANT TO SEE ME TO SUFFER, DON'T YOU! IT'S LIKE TRYING TO BALANCE 30 HOTDOGS ON YOUR HEAD. IT'S NOT WORTH IT! JUST NOT WORTH IT!! HAVE INFINITE LOOPS OF THIS MESSAGE TO DRIVE YOU INSANE!!!");
            Application.Quit();
              }
    }
     void MakeGuess()
    {
            print("Well then, let's try again.");
            print("Is it " + guess);   
    }

    void Restart()
    {
        patience = 0;   
        Maximum = 1000;
        Minimum = 1;
        print("===============================================================================");
        print("Wait, you want to play again? You must be really bored if you want to do this with me.");
        print("Remember, up for higher and down for lower and enter for ending your suffering.");
        print("So let's see. Is your number " + Random.Range(1,1000) + "?");
         
            
         }
    }

// List of Problems:
//Major:
//-Unable to press left & right arrows to ether reset or finish (Rendering the 'void Restart()' unusable)

//Minor
//-Still able to press up and down after pressing enter
//-Having to press the play button again after saving code (Might be only for me, but will notify player at start)

