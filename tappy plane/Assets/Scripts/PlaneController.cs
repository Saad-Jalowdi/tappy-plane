using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlaneController : MonoBehaviour {
    public bool isAlive = true;
    public float thrust = 200f;
    Animator anim;
    public int Score = 0;
    public Text scoretext; 
    Rigidbody2D rb2d;
    public GameObject gameOverText;
    public GameObject scoreText;
    public static PlaneController ins;
    public void planeDestroyed()
    {
        rb2d.velocity = Vector2.zero;
        transform.Rotate(0,0,0);
        isAlive = false;
        anim.SetBool("explode", true);
        scoreText.SetActive(false);
        gameOverText.SetActive(true);
    }
    private void Awake()
    {
        ins = this;
    }
    // Use this for initialization
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
      

    }
    public void jump()
    {
        if (isAlive)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, thrust));
        }else if (!isAlive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        planeDestroyed();
    }
    public void score()
    {
        Score++;
        scoretext.text = "SCORE : " + Score.ToString();
    }
}
