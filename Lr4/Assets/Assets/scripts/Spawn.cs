using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour {
    public GameObject astr;
    public GameObject spwn;

    void Start() {
        StartCoroutine(create());       
    }

    IEnumerator create() {
        while (true) {
            int randX = Random.Range(-15, 8);
            int randZ = Random.Range(-6, 7);
            int randY = Random.Range(-10, 11);

            float rx = (float)randX;
            float rz = (float)randZ;
            float ry = (float)randY;

            Instantiate(astr, new Vector3(spwn.transform.position.x + rx, spwn.transform.position.y + ry, spwn.transform.position.z + rz), Quaternion.identity);
            
            yield return new WaitForSeconds(0.10f);
        }
    }
}
