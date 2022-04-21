using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public float speed = 2f;

    Vector3 startpos;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "astr") {
            collision.gameObject.GetComponent<SphereCollider>().enabled = false;

            if (PlayerPrefs.GetInt("time10") < (int)Timer.TimeStart) {
                if (PlayerPrefs.GetInt("time9") < (int)Timer.TimeStart) {
                    if (PlayerPrefs.GetInt("time8") < (int)Timer.TimeStart) {
                        if (PlayerPrefs.GetInt("time7") < (int)Timer.TimeStart) {
                            if (PlayerPrefs.GetInt("time6") < (int)Timer.TimeStart) {
                                if (PlayerPrefs.GetInt("time5") < (int)Timer.TimeStart) {
                                    if (PlayerPrefs.GetInt("time4") < (int)Timer.TimeStart) {
                                        if (PlayerPrefs.GetInt("time3") < (int)Timer.TimeStart) {
                                            if (PlayerPrefs.GetInt("time2") < (int)Timer.TimeStart) {
                                                if (PlayerPrefs.GetInt("time1") < (int)Timer.TimeStart) {
                                                    PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                                                    PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                                                    PlayerPrefs.SetInt("time8", PlayerPrefs.GetInt("time7"));
                                                    PlayerPrefs.SetInt("time7", PlayerPrefs.GetInt("time6"));
                                                    PlayerPrefs.SetInt("time6", PlayerPrefs.GetInt("time5"));
                                                    PlayerPrefs.SetInt("time5", PlayerPrefs.GetInt("time4"));
                                                    PlayerPrefs.SetInt("time4", PlayerPrefs.GetInt("time3"));
                                                    PlayerPrefs.SetInt("time3", PlayerPrefs.GetInt("time2"));
                                                    PlayerPrefs.SetInt("time2", PlayerPrefs.GetInt("time1"));
                                                    PlayerPrefs.SetInt("time1", (int)Timer.TimeStart);
                                                } else {
                                                    PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                                                    PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                                                    PlayerPrefs.SetInt("time8", PlayerPrefs.GetInt("time7"));
                                                    PlayerPrefs.SetInt("time7", PlayerPrefs.GetInt("time6"));
                                                    PlayerPrefs.SetInt("time6", PlayerPrefs.GetInt("time5"));
                                                    PlayerPrefs.SetInt("time5", PlayerPrefs.GetInt("time4"));
                                                    PlayerPrefs.SetInt("time4", PlayerPrefs.GetInt("time3"));
                                                    PlayerPrefs.SetInt("time3", PlayerPrefs.GetInt("time2"));
                                                    PlayerPrefs.SetInt("time2", (int)Timer.TimeStart);
                                                }
                                            } else {
                                                PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                                                PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                                                PlayerPrefs.SetInt("time8", PlayerPrefs.GetInt("time7"));
                                                PlayerPrefs.SetInt("time7", PlayerPrefs.GetInt("time6"));
                                                PlayerPrefs.SetInt("time6", PlayerPrefs.GetInt("time5"));
                                                PlayerPrefs.SetInt("time5", PlayerPrefs.GetInt("time4"));
                                                PlayerPrefs.SetInt("time4", PlayerPrefs.GetInt("time3"));
                                                PlayerPrefs.SetInt("time3", (int)Timer.TimeStart);
                                            }
                                        } else {
                                            PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                                            PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                                            PlayerPrefs.SetInt("time8", PlayerPrefs.GetInt("time7"));
                                            PlayerPrefs.SetInt("time7", PlayerPrefs.GetInt("time6"));
                                            PlayerPrefs.SetInt("time6", PlayerPrefs.GetInt("time5"));
                                            PlayerPrefs.SetInt("time5", PlayerPrefs.GetInt("time4"));
                                            PlayerPrefs.SetInt("time4", (int)Timer.TimeStart);
                                        }
                                    } else {
                                        PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                                        PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                                        PlayerPrefs.SetInt("time8", PlayerPrefs.GetInt("time7"));
                                        PlayerPrefs.SetInt("time7", PlayerPrefs.GetInt("time6"));
                                        PlayerPrefs.SetInt("time6", PlayerPrefs.GetInt("time5"));
                                        PlayerPrefs.SetInt("time5", (int)Timer.TimeStart);
                                    }
                                } else {
                                    PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                                    PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                                    PlayerPrefs.SetInt("time8", PlayerPrefs.GetInt("time7"));
                                    PlayerPrefs.SetInt("time7", PlayerPrefs.GetInt("time6"));
                                    PlayerPrefs.SetInt("time6", (int)Timer.TimeStart);
                                }
                            } else {
                                PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                                PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                                PlayerPrefs.SetInt("time8", PlayerPrefs.GetInt("time7"));
                                PlayerPrefs.SetInt("time7", (int)Timer.TimeStart);
                            }
                        } else {
                            PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                            PlayerPrefs.SetInt("time9", PlayerPrefs.GetInt("time8"));
                            PlayerPrefs.SetInt("time8", (int)Timer.TimeStart);
                        }
                    } else {
                        PlayerPrefs.SetInt("time10", PlayerPrefs.GetInt("time9"));
                        PlayerPrefs.SetInt("time9", (int)Timer.TimeStart);
                    }
                } else {
                    PlayerPrefs.SetInt("time10", (int)Timer.TimeStart);
                }
            }
            SceneManager.LoadScene(0);
        }
    }

    void Start() {
        startpos = transform.position;
    }

    void Update() {
        Vector3 destination = new Vector3(-115f, 0, 0);

        float vert = Input.GetAxisRaw("Vertical");
        float hor = Input.GetAxisRaw("Horizontal");

        if (hor < 0) {
            transform.Translate(new Vector3(-1,0, 0) * speed * Time.deltaTime);
        } else if (hor > 0) {
            transform.Translate(new Vector3 (1, 0, 0) * speed * Time.deltaTime);
        } else {}

        if (vert > 0) {
            transform.Translate(new Vector3(0, 1,0) * speed * Time.deltaTime);
        } else if (vert < 0) {
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        } else {}

        Vector3 go = new Vector3(hor, vert, 0);
    }
}
