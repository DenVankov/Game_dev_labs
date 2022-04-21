using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour {
    public Material[] mat;
    Rigidbody rb;
    public float speed;
    public Material red;
    Vector3 go;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "ball" || collision.gameObject.tag == "Untagged") {
            if (gameObject.tag == "ball") {       
                gameObject.tag = "Untagged";
                int rand = Random.Range(0, mat.Length);
                gameObject.GetComponent<MeshRenderer>().material = mat[rand];

            }
        }
    }

    void Update() {
        if (rb.useGravity == false) {
            float vert = Input.GetAxisRaw("Vertical");
            Vector3 go = new Vector3(0, vert, 0);
            transform.Translate(go.normalized * 5 * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space)) {
                rb.useGravity = true;
            }
        }

        if (Input.GetMouseButtonDown(1)) {
            if (rb.useGravity == true) {
                Ray vec = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(vec.origin, vec.direction, out hit, Mathf.Infinity)) {
                    if (hit.rigidbody == null && hit.transform.tag == "plane") {
                        if (gameObject.tag == "ball") {
                            Vector3 t = hit.point - transform.position;
                            rb.AddForce(t * speed, ForceMode.Impulse);
                        }
                    }
                }
            }
        }
    }
}
