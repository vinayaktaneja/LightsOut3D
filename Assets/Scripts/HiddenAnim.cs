using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenAnim : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Animator>().enabled = true;
        }
    }

}
