using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRotation : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        GameObject character = GameObject.FindGameObjectWithTag("Player");
        GameObject platform = GameObject.FindGameObjectWithTag("Platform");

        character.transform.SetParent(this.transform, false);
        platform.transform.SetParent(this.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
