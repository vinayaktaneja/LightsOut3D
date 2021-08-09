using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityActivate : MonoBehaviour
{
    public Image abilityIcon1;
    public Image abilityIcon2;
    public GameObject disableDoor;

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
        if (other.CompareTag("Player"))
        {
            abilityIcon1.enabled = true;
            abilityIcon2.enabled = true;
            disableDoor.SetActive(false);
        }
    }

}
