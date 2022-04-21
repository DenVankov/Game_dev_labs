using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour {

    public Camera camera;
    public GameObject obj;
    public Sprite[] sprites;
    public Sprite red;
    bool r = false;


    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 vec = camera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(vec, Vector3.forward, Mathf.Infinity);

            if (hit.rigidbody == null && hit.transform.tag == "plane") {
                int rand = Random.Range(0, sprites.Length);
                Instantiate(obj, camera.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward, Quaternion.identity);
                obj.GetComponent<SpriteRenderer>().sprite = sprites[rand];
            } else {
                hit.transform.gameObject.GetComponent<SpriteRenderer>().sprite = red;
                hit.transform.tag = "ball";
            }
        }
    }
}
