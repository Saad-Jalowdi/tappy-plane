using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeating : MonoBehaviour {
    public float groundHorizantalLength = 8;
    Vector2 groundOffset;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -groundHorizantalLength)
        {
            repositionBackground();
        }
	}
    public void repositionBackground()
    {
        groundOffset = new Vector2(groundHorizantalLength*2,0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
