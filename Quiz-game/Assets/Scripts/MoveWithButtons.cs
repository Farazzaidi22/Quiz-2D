using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveWithButtons : MonoBehaviour
{
    public GameObject[] mailPrefab;
    int currentIndex = 0;

    //sets everything except the first gameObject to inactive
    void Awake()
    {
        if (mailPrefab.Length > 0) //you might not need this check, but it will catch any weird edge cases
        {
            for (int i = 1; i < mailPrefab.Length; ++i)
            {
                mailPrefab[i].SetActive(false);
            }
        }
    }

    public int CurrentIndex
    {
        get
        {
            return currentIndex;
        }
        set
        {
            if (mailPrefab[currentIndex] != null)
            {
                //set the current active object to inactive, before replacing it
                GameObject aktivesObj = mailPrefab[currentIndex];
                aktivesObj.SetActive(false);
            };

            if (value < 0)
                currentIndex = mailPrefab.Length - 1;
            else if (value > mailPrefab.Length - 1)
                currentIndex = 0;
            else
                currentIndex = value;
            if (mailPrefab[currentIndex] != null)
            {
                GameObject aktivesObj = mailPrefab[currentIndex];
                aktivesObj.SetActive(true);
            }
        }
    }
}
