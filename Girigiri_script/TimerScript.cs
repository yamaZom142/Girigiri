using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {
    float countTime = 0;
    float TotalTime = 30;
    float LastTime = 0;
    public Text timer;

    bool dameFlag;
    public PlayerController PlayerController;
    // Use this for initialization
    void Start () {
        this.timer.text = "Time : 30.00";
        dameFlag = PlayerController.DamageFlag;
    }
	
	// Update is called once per frame
	void Update () {


        countTime += Time.deltaTime;
        LastTime = TotalTime - countTime;
        if(LastTime <= 0)
        {
            dameFlag = true;
            this.timer.text = "Oh...";
            if(LastTime <= -2)
                SceneManager.LoadScene("GameOver");
        }else
        {
            this.timer.text = "Time : " + LastTime.ToString("F2");
        }
	}
}
