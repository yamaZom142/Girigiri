using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    Rigidbody2D rb2d;
    float speed = 3.5f;
    // Use this for initialization
    void Start () {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(0, speed*-1).normalized;
        rb2d.velocity = direction * speed;
        if (this.transform.position.y <= -10)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Hit");
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
