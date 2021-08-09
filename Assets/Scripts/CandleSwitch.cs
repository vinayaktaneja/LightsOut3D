using NaughtyCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleSwitch : MonoBehaviour
{

    public GameObject enable1;
    public GameObject disable1;
    public GameObject disable2;
    public GameObject disable3;
    bool CandleOn = true;
    public GameObject Ellen;
     


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (CandleOn == true)
            {
                CandleOn = false;
            }

            else
            {
                CandleOn = true;
            }
        }

        if (CandleOn == false)
        {
            enable1.SetActive(true);
            disable1.SetActive(false);
            disable2.SetActive(false);
            disable3.SetActive(false);
            Ellen.GetComponent<Character>().enabled = false;
        }
        else
        {
            enable1.SetActive(false);
            disable1.SetActive(true);
            disable2.SetActive(true);
            disable3.SetActive(true);
            Ellen.GetComponent<Character>().enabled = true;
        }
    }
}
