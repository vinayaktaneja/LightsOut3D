using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeAnim : MonoBehaviour
{
    public GameObject bridge1;
    public GameObject disable1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Candle"))
        {
            bridge1.GetComponent<Animator>().enabled = true;
            Destroy(disable1);
        }
    }
}
