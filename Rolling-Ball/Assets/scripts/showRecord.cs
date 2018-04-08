using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class showRecord : MonoBehaviour {
    public Text Record;//
                          // Use this for initialization
    void Start ()
    {
        string temp = "";
        for (int i = 1; i < globalsetting.level(); i++)
        {
            //float record = PlayerPrefs.GetFloat(i);
            if (PlayerPrefs.HasKey(i.ToString()))
            {
                temp += "第" + i.ToString() + "关成绩：" + PlayerPrefs.GetFloat(i.ToString()).ToString("N") + "s\n";
            }
            else
                temp += "第" + i.ToString() + "关还没有成绩哦\n";
        }
        for (int i = globalsetting.level(); i < 8; i++)
        {
            temp += "第" + i.ToString() + "关还没有成绩哦\n";

        }
        Record.text = temp;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
