using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statictarget : MonoBehaviour
{
    // Start is called before the first frame update
    private bool move = true;

    private void OnCollisionExit(Collision other) {
        if (move){
            GameObject.Find("Text (TMP)").GetComponent<count>().score += 1;
        }
		GetComponent<MeshRenderer>().material.color = Color.red;
        move = false;
	}

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
