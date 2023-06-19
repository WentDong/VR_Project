using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTarget : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Stone")
        {
            Destroy(other.gameObject, 10);
        }
    }
}
