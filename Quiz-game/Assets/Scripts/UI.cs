using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text energyAmt;

    public void Answer(string ans)
    {
        int n;
        if (int.TryParse(ans, out n))
        {
            print("amil4");
            energyAmt.text = ans;
        }
    }
}
