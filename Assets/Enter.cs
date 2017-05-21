using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Enter : MonoBehaviour {
    private int lives;
    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("Sphere")) {
            Debug.Log("Player did not catch ball. -1 Lives");
            lives--;
            Destroy(other.gameObject);   
        }
    }

    void Start() {
        lives = 1;
    }

    void Update() {
        if (lives <= 0) {
            SceneManager.LoadScene("TestLevel");
        }
    }     
}
