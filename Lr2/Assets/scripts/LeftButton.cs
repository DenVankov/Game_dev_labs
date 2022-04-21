using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour {

    public Camera cameraM;
    public GameObject obj;
    public Material[] mat;
    public Material red;


    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray vec = cameraM.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(vec.origin, vec.direction, out hit, Mathf.Infinity)) {
                if (hit.rigidbody == null && hit.transform.tag == "plane") {
                    int rand = Random.Range(0, mat.Length);
                    Instantiate(obj, hit.point + 7 *  Vector3.up, Quaternion.identity);
                    obj.GetComponent<Rigidbody>().useGravity = false;
                    obj.GetComponent<MeshRenderer>().material = mat[rand];
                } else if (hit.transform.tag != "wall") {
                    hit.transform.gameObject.GetComponent<MeshRenderer>().material = red;
                    hit.transform.gameObject.tag = "ball";
                }
            }
        }
    }
}
