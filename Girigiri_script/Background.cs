using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
    public float speed = -0.1f;
    bool dameFlag;
    public PlayerController PlayerController;
    // Use this for initialization
    void Start () {
        dameFlag = PlayerController.DamageFlag;
    }
	
	// Update is called once per frame
	void Update () {
        dameFlag = PlayerController.DamageFlag;
        if (dameFlag == false)
        {
            // 時間によってYの値が0から1に変化していく。1になったら0に戻り、繰り返す。
            float y = Mathf.Repeat(Time.time * speed, 1);

            // Yの値がずれていくオフセットを作成
            Vector2 offset = new Vector2(0, y);

            // マテリアルにオフセットを設定する
            GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
        }
    }
}
