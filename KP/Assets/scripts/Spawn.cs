using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour {
    public GameObject astr;
    public float push = 0.15f;

    void Start() {
        StartCoroutine(create());       
    }

    IEnumerator create() {
        while (true) {
            push -= 0.0001f;
            int randX = Random.Range(-10, 11);
            int randZ = Random.Range(-6, 7);
            float rx = (float)randX;
            float rz = (float)randZ;
            
            Instantiate(astr, new Vector3(rx, -10f, rz), Quaternion.identity);
            
            yield return new WaitForSeconds(push);
        }
    }
}
