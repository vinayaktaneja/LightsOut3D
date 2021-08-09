using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class candlepickup : MonoBehaviour
{
    
    public Text time;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Candle")
        {
            Destroy(other.gameObject);
            //time.text += 50f;
            time.GetComponent<GameOver>().timer += 25f;
        }
    }
}
