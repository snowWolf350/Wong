using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ball : MonoBehaviour
{
    public Rigidbody2D ballrb;
    public float speed = 4;
    public Vector2 start;
    public AudioSource bounce;
    // Start is called before the first frame update
    void Start()
    {

        start = transform.position;
        launch();
    }

    void launch()
    {
            float x = Random.Range(0, 2) == 0 ? -1 : 1;
            float y = Random.Range(0, 2) == 0 ? -1 : 1;
            ballrb.velocity = new Vector2(x * speed, y * speed);
    }
    public void restart()
    {
        ballrb.velocity = Vector2.zero;
        transform.position = start;
        launch();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        bounce.Play();
    }
}
