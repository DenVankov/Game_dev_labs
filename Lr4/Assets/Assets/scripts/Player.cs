using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour {
    public Camera cam;
    public float speed = 0.05f;
    Rigidbody rb;

    float vert;
    float hor;


    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "astr") {
        }
    }

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        vert = Input.GetAxisRaw("Vertical");
        hor = Input.GetAxisRaw("Horizontal");
        rb.AddRelativeForce(new Vector3(hor, vert, 0 ) * speed / Time.deltaTime);
    }
}
