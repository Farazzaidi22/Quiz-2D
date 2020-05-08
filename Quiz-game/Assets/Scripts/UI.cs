using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public InputField[] iField;
    string Answers;

    public void Q1()
    {
        Debug.Log(iField[0].text);
        Answers = iField[0].text;

        if (Answers == "JUPITER" || Answers == "jupiter")
        {
            Debug.Log("Correct answer 1");
            Answers = "";
        }
        else
        {
            Answers = "";
            Debug.Log("Wrong answer 1");
        }
    }

    public void Q2()
    {
        Debug.Log(iField[1].text);
        Answers = iField[1].text;
        if (Answers == "NEPTUNE" || Answers == "neptune")
        {
            Debug.Log("Correct answer 2");
            Answers = "";
        }
        else
        {
            Answers = "";
            Debug.Log("Wrong answer 2");
        }
    }

    public void Q3()
    {
        Debug.Log(iField[2].text);
        Answers = iField[2].text;
        if (Answers == "CERES" || Answers == "ceres")
        {
            Debug.Log("Correct answer 3");
            Answers = "";
        }
        else
        {
            Answers = "";
            Debug.Log("Wrong answer 3");
        }
    }

    public void Q4()
    {
        Debug.Log(iField[3].text);
        Answers = iField[3].text;
        if (Answers == "Third" || Answers == "third" || Answers == "3")
        {
            Debug.Log("Correct answer 4");
            Answers = "";
        }
        else
        {
            Answers = "";
            Debug.Log("Wrong answer 4");
        }
    }

    public void Q5()
    {
        Debug.Log(iField[4].text);
        Answers = iField[4].text;
        if (Answers == "Eight" || Answers == "8")
        {
            Debug.Log("Correct answer 5");
            Answers = "";
        }
        else
        {
            Answers = "";
            Debug.Log("Wrong answer 5");
        }
    }

    public void Q6()
    {
        Debug.Log(iField[5].text);
        Answers = iField[5].text;
        if (Answers == "MARS" || Answers == "mars")
        {
            Debug.Log("Correct answer 6");
            Answers = "";
        }
        else
        {
            Answers = "";
            Debug.Log("Wrong answer 6");
        }
    }
}
