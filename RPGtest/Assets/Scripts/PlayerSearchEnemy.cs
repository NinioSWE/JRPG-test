using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSearchEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Grass")
        {
            Debug.Log("test");
            if (Random.Range(0,4) == 3)
            {
                SceneManager.LoadScene("combat");
            }
        }
    }
}
