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
    private int scenarionum;

    // Use this for initialization
    void Start()
    {
        titleText.text = "Random Text Base Adventure";
        enterText("Welcome to the Text Based Adventure Game! Random Edition!");
        randLocationScenario();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && win == false)
        {
            enterText("You moved North.");
            if (scenarionum != 0)
                ForestScenario();
            else
                CavernScenario();
        }
        if (Input.GetKeyDown(KeyCode.A) && win == false)
        {
            enterText("You moved West.");
            if (scenarionum != 0)
                ForestScenario();
            else
                CavernScenario();
        }
        if (Input.GetKeyDown(KeyCode.S) && win == false)
        {
            enterText("You moved South.");
            if (scenarionum != 0)
                ForestScenario();
            else
                CavernScenario();
        }
        if (Input.GetKeyDown(KeyCode.D) && win == false)
        {
            enterText("You moved East.");
            if (scenarionum != 0)
                ForestScenario();
            else
                CavernScenario();
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

    void randLocationScenario()
    {
        int randScenerio = Random.Range(0, 2);
        scenarionum = randScenerio;
        if (randScenerio != 0)
            enterText("You are lost in a crowded forest.. use W,A,S,D keys to try to find your way out");
        else
            enterText("You are lost in a dark cavern.. use W,A,S,D keys to try to find your way out");
    }

    void ForestScenario()
    {
        float randText = Random.Range(0.0f, 10.0f);
        if (randText >= 0 && randText < 2)
            enterText("You feel like something is watching you..");
        if (randText >= 2 && randText < 3)
            enterText("There seems to be nothing that stands out here...");
        if (randText >= 3 && randText < 4)
            enterText("You hear eerie sounds in the distance. It's best to find a way out.");
        if (randText >= 4 && randText < 5)
            enterText("It's dark here and you should keep moving!");
        if (randText >= 5 && randText <6)
            enterText("It's unusually quiet in this area.");
        if (randText >= 6 && randText < 7)
            enterText("You ponder why you are even in this forest.");
        if (randText >= 7 && randText < 8)
            enterText("Still no signs of an exit...");
        if (randText >=8 && randText < 9)
            enterText("You arrive at a clearing and wonder if you will see the tall man here.");
        if (randText >= 9)
        {
            enterText("You Escaped!!");
            win = true;
        }
    }

    void CavernScenario()
    {
        float randText = Random.Range(0.0f, 10.0f);
        if (randText >= 0 && randText < 2)
            enterText("You feel like something is watching you..");
        if (randText >= 2 && randText < 3)
            enterText("The caverns never seem to end.");
        if (randText >= 3 && randText < 4)
            enterText("You hear eerie sounds in the distance. It's best to find a way out.");
        if (randText >= 4 && randText < 5)
            enterText("It's dark here and you should keep moving!");
        if (randText >= 5 && randText < 6)
            enterText("It's unusually quiet in this area.");
        if (randText >= 6 && randText < 7)
            enterText("You wonder why you decided to enter the cavern.");
        if (randText >= 7 && randText < 8)
            enterText("Everything looks the same here...");
        if (randText >= 8 && randText < 9)
            enterText("You hope you can find an exit soon.");
        if (randText >= 9)
        {
            enterText("You Escaped!!");
            win = true;
        }
    }


   public void ChangeLocation()
    {
        if (scenarionum == 0)
        {
            scenarionum = 1;
            enterText("You have been teleported into the forest.");
        }

        else
        {
            scenarionum = 0;
            enterText("You have been teleported into the cavern.");
        }

    }

    void gameWin()
    {
        enterText("\n Congrats!");
        enterText("Play again?");
        enterText("Please press 'Y' or 'N' \n");
    }
}
