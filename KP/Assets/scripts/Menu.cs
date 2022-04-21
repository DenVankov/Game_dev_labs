using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    private int zero = 0;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;

    public void loadLevel() { 
        SceneManager.LoadScene(1);
    }
    
    public void Remove() {
        PlayerPrefs.SetInt("time1", 0);
        PlayerPrefs.SetInt("time2", 0);
        PlayerPrefs.SetInt("time3", 0);
        text1.text = zero.ToString();
        text2.text = zero.ToString();
        text3.text = zero.ToString();
        PlayerPrefs.SetInt("time4", 0);
        PlayerPrefs.SetInt("time5", 0);
        PlayerPrefs.SetInt("time6", 0);
        text4.text = zero.ToString();
        text5.text = zero.ToString();
        text6.text = zero.ToString();
        PlayerPrefs.SetInt("time7", 0);
        PlayerPrefs.SetInt("time8", 0);
        PlayerPrefs.SetInt("time9", 0);
        text7.text = zero.ToString();
        text8.text = zero.ToString();
        text9.text = zero.ToString();
        PlayerPrefs.SetInt("time10", 0);
        text10.text = zero.ToString();
    }

    public void Exit() {
        Application.Quit();
    }
}
