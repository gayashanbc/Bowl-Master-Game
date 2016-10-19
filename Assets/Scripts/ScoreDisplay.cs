using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScoreDisplay : MonoBehaviour {

    public Text[] rollTexts, frameTexts;

	public void FillRolls(List<int> rolls)
    {
        string scoresString = FormatRolls(rolls);

        for (int i = 0; i < scoresString.Length; i++)
        {
            rollTexts[i].text = scoresString[i].ToString();
        }
    }

    public void FillFrames(List<int> frames)
    {
        for(int i=0; i<frames.Count; i++)
        {
            frameTexts[i].text = frames[i].ToString();
        }
    }

    public static string FormatRolls(List<int> rolls)
    {
        string output = "";

        for(int i=0; i<rolls.Count; i++)
        {
            int box = output.Length + 1; //Score box 1 to 21

            if(rolls[i] == 0) 
            {
                output += "-"; //Always enter 0 as '-'
            }

            //we are in an even roll or last bowl
            else if((box % 2 == 0 || box == 21) && rolls[i-1] + rolls[i] == 10)
            {
                output += "/"; //SPARE anywhere
            }

            else if(box >= 19 && rolls[i] == 10) //STRIKE in frame 10
            {
                output += "X"; //X without space
            }

            else if(rolls[i] == 10)
            {
                output += "X "; //STRIKE - X with space in frame 1-9
            }

            else
            {
                output += rolls[i].ToString(); //Normal 1-9 bowl
            }
        }

        return output;
    }
}
