using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float speed = 2f;
    public int CNT = 0;

    Vector3 startpos;
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "astr") {
            transform.position = new Vector3(0.05341797f, -56.99992f, -0.3f);
            Debug.Log("You hit the asteroid. Total hits: " + CNT);
            CNT++;
        }
    }


    void Start() {
        startpos = transform.position;
    }

    void Update() {
        Vector3 destination = new Vector3(-115f, 0, 0);
        
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        
        if (horizontal < 0) {
            transform.Translate(new Vector3(-1,0, 0) * speed * Time.deltaTime);
        } else if (horizontal > 0) {
            transform.Translate(new Vector3 (1, 0, 0) * speed * Time.deltaTime);
        } else {}
        
        if (vertical > 0) {
            transform.Translate(new Vector3(0, 1,0) * speed * Time.deltaTime);
        } else if (vertical < 0) {
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        } else {}
        
        Vector3 go = new Vector3(horizontal, vertical, 0);

    }
}
