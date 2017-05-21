using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSpheres : MonoBehaviour {
    float randomTime;
    float randomXValue;
    public GameObject spherePrefab;
	// Use this for initialization
	void Start () {
        StartCoroutine(Instantiate());
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    IEnumerator Instantiate() {
        while (true) {
            randomXValue = Random.Range(-6.0f, 6.0f);
            Vector3 position = new Vector3(randomXValue, 10f, 0f);
            Instantiate(spherePrefab, position, Quaternion.identity);
            randomTime = Random.Range(0.5f, 2f);
            yield return new WaitForSeconds(randomTime);
        }


    }
}
