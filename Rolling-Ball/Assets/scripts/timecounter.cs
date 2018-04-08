using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timecounter : MonoBehaviour {
    public static float sumTime;
    float starttime;
    public Text TimeLabel;//时间显示Label
	// Use this for initialization
	void Start () {
        starttime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    //

    public void startcount()
    {
        starttime = Time.time;
    }

    void FixedUpdate()
    {
        sumTime = Time.time- starttime;
        TimeLabel.text = "Time:" + (sumTime).ToString("f0")+'s';
    }
}
