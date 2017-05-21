using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnterBox : MonoBehaviour {
    public Text guiText;
    private int score;
    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("Sphere")) {
            Debug.Log("Player caught ball: +1 score");
            score++;
            setScoreText();
            Destroy(other.gameObject);   
        }
    }
    void Start() {
        score = 0;
        setScoreText();
    }
    void Update() {
        
    }
    void setScoreText() {
        guiText.text = "Score: " + score.ToString();
    }
}
