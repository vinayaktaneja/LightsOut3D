using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float turnSpeed = 50f;

    public void Update()
    {
        transform.Rotate(new Vector3(0f, turnSpeed, 0f) * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider col)
    {
        col.transform.parent = transform;
    }

    private void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;

    }
}