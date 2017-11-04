using System.Collections;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Boundary")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
}
