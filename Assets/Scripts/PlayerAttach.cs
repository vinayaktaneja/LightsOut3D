using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttach : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        col.transform.parent = transform;
    }

    private void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;

    }
}
