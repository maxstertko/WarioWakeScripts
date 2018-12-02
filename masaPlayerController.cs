using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class masaPlayerController : MonoBehaviour {

    public float timer;
    public bool isAlive;
    public Text endText;

    public float speed;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        timer = 10;
        isAlive = true;
        //endText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (timer > 0 && isAlive == true) {
            timer = timer + Time.deltaTime;
        }
        else if (timer <= 0 || isAlive == false) {
            int wholeTime = (int)timer;

            endText.text = "You did this for " + wholeTime + " Seconds!";

            //GameLoader.AddScore(wholeTime);

            StartCoroutine(ByeAfterDelay(2));
            
        }
        
        

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        rb.velocity = movement * speed;
	}

    IEnumerator ByeAfterDelay(float time) {
        yield return new WaitForSeconds(time);

        //GameLoader.gameOn = false;
    }
}
