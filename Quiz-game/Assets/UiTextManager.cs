using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiTextManager : MonoBehaviour
{
    public Text welcome;
    public Text Hi;
    // Start is called before the first frame update
    void Start()
    {
        //welcome = GetComponent<Text>();
        //Hi = GetComponent<Text>();

        int temp = Random.Range(0, 2);
        if (temp == 0)
        {
            if (welcome != null && Hi != null)
            {

                Debug.Log("amil1");
                welcome.enabled = true;
                Debug.Log("amil2");
                Hi.enabled = false;
                Debug.Log("amil3");
            }
        }
        else
        {
            print(temp);
            Debug.Log("amil4");
            welcome.enabled = false;
            Hi.enabled = true;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
