using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    public Sprite[] sprites;
    public Sprite red;
    public float speed;
    bool m = false;
    Vector3 go;
    Rigidbody2D rb;


    void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag != "wall") {
            if (gameObject.tag == "ball") {
                gameObject.tag = "Untagged";
                int rand = Random.Range(0, sprites.Length);
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[rand];
            }
        }

    }

    void Update() {
        if (Input.GetMouseButtonDown(1)) {
            Vector2 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 point = new Vector2(vec.x - transform.position.x, vec.y - transform.position.y);
            if (gameObject.tag == "ball") {
                rb.AddForce(point * speed, ForceMode2D.Impulse);
            }
        }
    }
}
