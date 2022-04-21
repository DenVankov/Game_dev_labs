using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAst : MonoBehaviour {
    public Camera cam;
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Finish" || collision.gameObject.tag == "Player") {
            Destroy(gameObject);
        }
    }
    void Update() {
        transform.Translate(new Vector3(cam.transform.position.x, 0 , cam.transform.position.z) * 3f * Time.deltaTime);
    }
}
