using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    public float tumble;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
