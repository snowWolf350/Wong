using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2 : MonoBehaviour
{
    public float move = 4;
    public float max = 3.34F;
    public Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < max)
            transform.position += Vector3.up * move * Time.deltaTime;
        if (Input.GetKey(KeyCode.S) && transform.position.y > -max)
            transform.position += Vector3.down * move * Time.deltaTime;
    }
    public void restart()
    {
        transform.position = start;
    }
}
