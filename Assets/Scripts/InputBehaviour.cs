using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    public Text titleText;
    public Text logText;
    public bool win = false;
    private int temp = 0;
    // Use this for initialization
    void Start()
    {
        titleText.text = "Random Text Base Adventure";
        enterText("Welcome to the Text Based Adventure Game! Random Edition!");
        enterText("You are lost in a crowded forest.. use W,A,S,D keys to try to find your way out");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && win == false)
        {
            enterText("You moved North.");
            randomScenario();
        }
        if (Input.GetKeyDown(KeyCode.A) && win == false)
        {
            enterText("You moved West.");
            randomScenario();
        }
        if (Input.GetKeyDown(KeyCode.S) && win == false)
        {
            enterText("You moved South.");
            randomScenario();
        }
        if (Input.GetKeyDown(KeyCode.D) && win == false)
        {
            enterText("You moved East.");
            randomScenario();
        }

        if (win == true)
        {
            if (temp == 0)
            {
                gameWin();
                temp += 1;
            }

            if (Input.GetKeyDown(KeyCode.Y))
            {
                logText.text = "";
                win = false;
                enterText("You decided to turn around and get lost again...");
                temp = 0;
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                logText.text = "";
                enterText("Thanks for playing!!");
            }
        }
    }


    void enterText(string text)
    {
        logText.text += (text + "\n");
    }

    void randomScenario()
    {
        float random = Random.Range(0.0f, 10.0f);
        if (random <= 3)
        {
            enterText("There seems to be nothing that stands out here...");
        }
        if (random > 3 && random < 4)
        {
            enterText("You hear eerie sounds in the distance. It's best to find a way out.");
        }
        if (random >= 4 && random < 5)
        {
            enterText("It's dark here and you should keep moving!");
        }
        if (random >= 5 && random <6)
        {
            enterText("It's unusually quiet in this area.");
        }
        if (random >= 6 && random < 7)
        {
            enterText("You ponder why you are even in this forest.");
        }
        if (random >= 7 && random < 8)
        {
            enterText("Still no signs of an exit...");
        }
        if (random >=8 && random < 9)
        {
            enterText("You arrive at a clearing and wonder if you will see the tall man here.");
        }
        if (random >= 9)
        {
            enterText("You Escaped!!");
            win = true;
        }
    }

    void gameWin()
    {
        enterText("\n Congrats!");
        enterText("Play again?");
        enterText("Please press 'Y' or 'N' \n");
    }
}
