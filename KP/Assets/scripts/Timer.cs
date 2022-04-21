using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour {
    public static float TimeStart = 0f;
    public Text timer;

    // Start is called before the first frame update
    void Start() {
        // DontDestroyOnLoad(this.gameObject);
        TimeStart = 0f;
        timer.text = TimeStart.ToString();
    }

    // Update is called once per frame
    void Update() {
        TimeStart += Time.deltaTime;
        timer.text = Mathf.Round(TimeStart).ToString();
    }
}