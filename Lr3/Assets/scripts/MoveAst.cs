using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAst : MonoBehaviour {
    private int count = 0;
    Rigidbody m_Rigidbody;
    private int o = 0;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            if(transform.position.x < 0) {
                o = 1;
            } else {
                o = -1;
            }
            m_Rigidbody.isKinematic = false;

            float rx = Random.Range(-4.0f, -2.0f);
            float ry = Random.Range(-3.0f, 3.0f);
            float rz = Random.Range(-3.0f, 3.0f);
            m_Rigidbody.AddForce(new Vector3(rx * o, ry, rz) * 10f, ForceMode.Impulse);
            count++;
        }
    }


    void Start() {    
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if(count == 0) {
            transform.Translate(Vector3.down * 15f * Time.deltaTime);
        }
        if(transform.position.y < -66.3f) {
            Destroy(gameObject);
        }
    }
}
