// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// // using UnityEngine.UI;
// // using System;
// // using System.IO;
// // using System.Text;

// public class count : MonoBehaviour
// {
//     public int counter;
// 	// public Text scoretext;
//     // Start is called before the first frame update
//     void Start()
//     {
//         counter = 0;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         // scoretext.text = counter.ToString();
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class count: MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Text = transform.GetComponent<TextMeshProUGUI>();
        Text.text = "Your score" + score.ToString();
        // TxtCurrentTime = GetComponent<TextMeshPro> ();
    }

    // Update is called once per frame
    void Update()
    {
        //获取系统当前时间
        System.DateTime NowTime = System.DateTime.Now.ToLocalTime();
        // Text.text = NowTime.ToString("HH:mm");
        Text.text = "Score:" + score.ToString();
    }
}

