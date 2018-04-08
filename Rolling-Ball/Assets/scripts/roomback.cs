using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;


public class roomback : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        List<string> btnsName = new List<string>();
        btnsName.Add("bt_back");


        foreach (string btnName in btnsName)
        {
            GameObject btnObj = GameObject.Find(btnName);
            Button btn = btnObj.GetComponent<Button>();
            btn.onClick.AddListener(delegate () {
                this.OnClick(btnObj);
            });
        }
    }

    public void OnClick(GameObject sender)
    {
        switch (sender.name)
        {
            case "bt_back":
                Debug.Log("bt_back");
                SceneManager.LoadScene("_mainscene");
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
