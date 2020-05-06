using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject[] dress;

    private int _index;

    public void PreviousModel()
    {
        // Hide current model
        dress[_index].SetActive(false);

        _index--;
        if (_index < 0)
        {
            _index = dress.Length - 1;
        }

        // Show previous model
        dress[_index].SetActive(true);
    }

    public void NextModel()
    {
        // Hide current model
        dress[_index].SetActive(false);

        _index++;

        if (_index > dress.Length - 1)
        {
            _index = 0;
        }

        // Show next model
        dress[_index].SetActive(true);
    }

}
