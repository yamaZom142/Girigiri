using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5;
    float rotate = 0f;
    public bool DamageFlag = false;


    float timer = 0;
    float span = 0;

    public AudioClip SE;
    private AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = SE;
    }

    // Update is called once per frame
    void Update()
    {
        //左右操作
        if (DamageFlag == false)
        {
            float x = Input.GetAxisRaw("Horizontal");
            if (-5.5 <= transform.position.x && transform.position.x <= 1)
            {
                Vector2 direction = new Vector2(x, 0).normalized;
                rb2d.velocity = direction * speed;
            }
            else if (transform.position.x <= -3)
            {
                rb2d.velocity = new Vector2(1, 0).normalized;
            }
            else
            {
                rb2d.velocity = new Vector2(-1, 0).normalized;
            }

            //斜めを向く
            if (Input.GetKeyDown(KeyCode.Q) && rotate != 90)
            {
                rotate += 90;
                //this.transform.rotation += new Vector3(0f, 0f, 5f));
                Vector3 position = this.transform.localPosition;
                Quaternion rotation = this.transform.localRotation;
                Vector3 scale = this.transform.localScale;

                // クォータニオン → オイラー角への変換
                Vector3 rotationAngles = rotation.eulerAngles;

                // X軸の90度回転
                //rotationAngles.x = rotationAngles.z + 10.0f;
                // Vector3の加算は以下のような書き方も可能
                rotationAngles += new Vector3(0.0f, 0.0f, 90.0f);

                // オイラー角 → クォータニオンへの変換
                rotation = Quaternion.Euler(rotationAngles);

                // Transform値を設定する
                this.transform.localPosition = position;
                this.transform.localRotation = rotation;
                this.transform.localScale = scale;
            }
            else if (Input.GetKeyDown(KeyCode.E) && rotate != -90)
            {
                rotate -= 90;
                //this.transform.rotation += new Vector3(0f, 0f, 5f));
                Vector3 position = this.transform.localPosition;
                Quaternion rotation = this.transform.localRotation;
                Vector3 scale = this.transform.localScale;

                // クォータニオン → オイラー角への変換
                Vector3 rotationAngles = rotation.eulerAngles;

                // X軸の90度回転
                //rotationAngles.x = rotationAngles.z + 10.0f;
                // Vector3の加算は以下のような書き方も可能
                rotationAngles += new Vector3(0.0f, 0.0f, -90.0f);

                // オイラー角 → クォータニオンへの変換
                rotation = Quaternion.Euler(rotationAngles);

                // Transform値を設定する
                this.transform.localPosition = position;
                this.transform.localRotation = rotation;
                this.transform.localScale = scale;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Hit");
        if (coll.gameObject.tag == "Enemy" && DamageFlag == false)
        {
            StartCoroutine(Wait());
            Debug.Log("End");
        }
    }
    public IEnumerator Wait()
    {
        audioSource.Play();
        Debug.Log("wait");
        DamageFlag = true;
        rb2d.velocity = Vector2.zero;
        yield return new WaitForSeconds(0.5f);

        DamageFlag = false;
        Debug.Log("Waitしたよ");
        //リセット
    }
}
