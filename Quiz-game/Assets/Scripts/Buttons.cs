using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject[] dress;
    public GameObject displayImage;

    private int _index;
    public int i = 0;


    public void PreviousModel()
    {
        
        _index = Mathf.Clamp(_index - 1, 0, 6);
        Debug.Log(_index);

        // code to show your model dress[_index] ...
        dress[_index + 1].SetActive(false);
        dress[_index].SetActive(true);
        //dress[_index].transform.position = dress[_index + 1].transform.position;

        if (i + 1 < dress.Length)
        {
            i++;
        }
    }

    public void NextModel()
    {
        _index = Mathf.Clamp(_index + 1, 0, 6);
        Debug.Log(_index);

        // code to show your model dress[_index] ...
        dress[_index - 1].SetActive(false);
        dress[_index].SetActive(true);

        //dress[_index].transform.position = dress[_index - 1].transform.position;
        if (i - 1 > 0)
        {
            i--;
        }
    }
}

    //void Update()
    //{
    //    displayImage = dress[i];
    //}
