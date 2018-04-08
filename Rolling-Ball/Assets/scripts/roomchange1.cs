using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class roomchange1 : MonoBehaviour {
    public GameObject[] button;
    // Use this for initialization
    void Start()
    {
        button = new GameObject[8];
        button[0] = GameObject.Find("Button"); 
        button[1] = GameObject.Find("Button (1)");
        button[2] = GameObject.Find("Button (2)");
        button[3] = GameObject.Find("Button (3)");
        button[4] = GameObject.Find("Button (4)");
        button[5] = GameObject.Find("Button (5)");
        button[6] = GameObject.Find("Button (6)");
        button[7] = GameObject.Find("Button (7)");
        List<string> btnsName = new List<string>();
        btnsName.Add("Button");
        btnsName.Add("Button (1)");
        btnsName.Add("Button (2)");
        btnsName.Add("Button (8)");
        foreach (string btnName in btnsName)
        {
            GameObject btnObj = GameObject.Find(btnName);
            Button btn = btnObj.GetComponent<Button>();
            btn.onClick.AddListener(delegate () {
                this.OnClick(btnObj);
            });
        }
       // ColorBlock colors;
        for (int i = globalsetting.level(); i < 8; i++)
        {
            var colors = button[i].GetComponent<Button>().colors;
            colors.normalColor = Color.grey;
            button[i].GetComponent<Button>().colors = colors;
            //print(globalsetting.level());
        }

    }

    public void OnClick(GameObject sender)
    {
        switch (sender.name)
        {
            case "Button":
                Debug.Log("Button");
                SceneManager.LoadScene("_scene0");
                break;
            case "Button (1)":
                Debug.Log("Button1");
                SceneManager.LoadScene("_scene1");
                break;
            case "Button (2)":
                Debug.Log("Button2");
                SceneManager.LoadScene("_scene2");

                break;
            case "Button (8)":
                SceneManager.LoadScene("_mainscene_ranking");

                break;
            default:
                Debug.Log("none");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}