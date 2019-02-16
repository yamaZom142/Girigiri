using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerMan : MonoBehaviour {
    Rigidbody2D rb2d;
    GameObject TimeBoy;
    bool DamFlag;
    public float GoalSpeed = 0.25f;
    public PlayerController PlayerController;
	// Use this for initialization
	void Start () {
        this.rb2d = GetComponent<Rigidbody2D>();
        DamFlag = PlayerController.DamageFlag;
    }
	
	// Update is called once per frame
	void Update () {
        DamFlag = PlayerController.DamageFlag;
        if (DamFlag == false)
        {
            Vector2 direction = new Vector2(0, GoalSpeed).normalized;
            rb2d.velocity = direction * GoalSpeed;
        }else
        {
            rb2d.velocity = Vector2.zero;
        }

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
