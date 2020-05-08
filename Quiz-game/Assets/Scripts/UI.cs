using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public InputField iField;
    string Planet;

    public void MyFunction()
    {
        Debug.Log(iField.text);
        Planet = iField.text;

        if (Planet == "JUPITER" || Planet == "jupiter")
        {
            Debug.Log("Correct answer");
        }
        else
        {
            Debug.Log("Wrong answer");
        }
    }
}
