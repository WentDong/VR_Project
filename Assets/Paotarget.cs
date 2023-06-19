using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paotarget : MonoBehaviour
{
    public float MoveSpeed = 0.25f;
    // public GameObject counter;
    public Vector3 MoveDistance = new Vector3(2f, 0f, 0f);
    private Vector3 startPos;
    private Vector3 targetPos;
    private bool move = true;
    private bool start = false;
    private Vector3 globalStartPos;
    // private void OnCollisionExit(Collision other) {
    //     if (move){
    //         GameObject.Find("Text (TMP)").GetComponent<count>().score += 1;
    //     }
	// 	GetComponent<MeshRenderer>().material.color = Color.red;
    //     move = false;
	// }

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("START GAME!");
        // Debug.Log(GetComponent<Rigidbody>().position);
        // Debug.Log(startPos);
        globalStartPos = GetComponent<Rigidbody>().position;
        // Debug.Log("#####################################");
        if (move){
            startPos = transform.position;
            targetPos = startPos + MoveDistance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if (move){
        //     Debug.Log(GetComponent<Rigidbody>().position);
        //     Debug.Log(globalStartPos);
        //     Debug.Log("#####################################");
        // }
        if (move && Vector3.Distance(GetComponent<Rigidbody>().position,globalStartPos)>0.01){
            GetComponent<MeshRenderer>().material.color = Color.red;
            GameObject.Find("Text (TMP)").GetComponent<count>().score += 1;
            move = false;
        }
    }
}