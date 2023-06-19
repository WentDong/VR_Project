using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetarget : MonoBehaviour
{
    public float MoveSpeed = 0.25f;
    // public GameObject counter;
    public Vector3 MoveDistance = new Vector3(2f, 0f, 0f);
    private Vector3 startPos;
    private Vector3 targetPos;
    private bool move = true;


    private void OnCollisionExit(Collision other) {
        if (move){
            GameObject.Find("Text (TMP)").GetComponent<count>().score += 1;
        }
		GetComponent<MeshRenderer>().material.color = Color.red;
        move = false;
	}

    // Start is called before the first frame update
    void Start()
    {
        if (move){
            startPos = transform.position;
            targetPos = startPos + MoveDistance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (move){
            transform.position = Vector3.Lerp(startPos, targetPos, Mathf.PingPong(Time.time * MoveSpeed, 1));
        }

    }
}