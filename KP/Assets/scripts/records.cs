using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class records : MonoBehaviour {
    public Text text1;
    public int time1;
    public Text text2;
    public int time2;
    public Text text3;
    public int time3;
    public Text text4;
    public int time4;
    public Text text5;
    public int time5;
    public Text text6;
    public int time6;
    public Text text7;
    public int time7;
    public Text text8;
    public int time8;
    public Text text9;
    public int time9;
    public Text text10;
    public int time10;

    // Start is called before the first frame update
    void Start() {
        time1 = PlayerPrefs.GetInt("time1");
        text1.text = time1.ToString();
        time2 = PlayerPrefs.GetInt("time2");
        text2.text = time2.ToString();
        time3 = PlayerPrefs.GetInt("time3");
        text3.text = time3.ToString();
        time4 = PlayerPrefs.GetInt("time4");
        text4.text = time4.ToString();
        time5 = PlayerPrefs.GetInt("time5");
        text5.text = time5.ToString();
        time6 = PlayerPrefs.GetInt("time6");
        text6.text = time6.ToString();
        time7 = PlayerPrefs.GetInt("time7");
        text7.text = time7.ToString();
        time8 = PlayerPrefs.GetInt("time8");
        text8.text = time8.ToString();
        time9 = PlayerPrefs.GetInt("time9");
        text9.text = time9.ToString();
        time10 = PlayerPrefs.GetInt("time10");
        text10.text = time10.ToString();
    }
}
