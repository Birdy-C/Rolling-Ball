using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

//这段代码我拖相机上了

public class globalsetting : MonoBehaviour {
    public GameObject[] objects;
    public static int curLevel;


    public static void Load()
    {
        if (PlayerPrefs.HasKey("curLevel"))
        {
            curLevel = PlayerPrefs.GetInt("curLevel");
        }
        if (curLevel == 0)
        {

            curLevel = 1;
        }
    }

    void Start () {
        //检查文件是否存在 -- 否:返回null.
        //globalsetting.SaveJson();
        // PlayerPrefs.SetInt("curLevel", curLevel);
        //curLevel = 1;
        globalsetting.Load();
        print("level" + curLevel);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void addlevel(int i,float time) {
        if (i == curLevel)
        {
            curLevel++;
            PlayerPrefs.SetInt("curLevel", curLevel);
        }
        if (PlayerPrefs.HasKey(i.ToString()))
        {
            float t = PlayerPrefs.GetFloat(i.ToString());
            if (time < t)
                PlayerPrefs.SetFloat(i.ToString(), time);
        }
        else
        {
            PlayerPrefs.SetFloat(i.ToString(), time);
        }
    }
    public static int level()
    {
        return curLevel;
    }


}
