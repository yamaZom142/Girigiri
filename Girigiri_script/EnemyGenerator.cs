using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    public GameObject Pattern01;
    public GameObject Pattern02;
    public GameObject Pattern03;
    public GameObject Pattern04;
    public GameObject Pattern05;
    public GameObject Pattern06;
    public GameObject Pattern07;
    public GameObject Pattern08;
    public GameObject Pattern09;
    public float span = 3.5f;
    float delta = 0f;
    GameObject LetsGo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //時間判別
        this.delta += Time.deltaTime;
        if (this.delta > this.span) //一定時間経過で
        {
            //リセット
            this.delta = 0;

            //ランダムパターンで
            int range = Random.Range(1, 10);
            switch (range)
            {
                case 1:
                    //生成
                    Instantiate(Pattern01);
                    break;
                case 2:
                    Instantiate(Pattern02);
                    break;
                case 3:
                    Instantiate(Pattern03);
                    break;
                case 4:
                    Instantiate(Pattern04);
                    break;
                case 5:
                    Instantiate(Pattern05);
                    break;
                case 6:
                    Instantiate(Pattern06);
                    break;
                case 7:
                    Instantiate(Pattern07);
                    break;
                case 8:
                    Instantiate(Pattern08);
                    break;
                case 9:
                    Instantiate(Pattern09);
                    break;

            }
        }

	}
}
