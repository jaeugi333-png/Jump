using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MovingCloud : MonoBehaviour
{
    public float avgSpeed = 0.05f;
    float maxX = 12.0f;
    int direction = 1;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(avgSpeed * 0.6f, avgSpeed * 1.4f);
        direction = Random.Range(0, 2) == 0 ? 1 : -1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * direction, 0, 0);

        if(transform.position.x > maxX)
        {
            direction = -1;
            speed = Random.Range(avgSpeed * 0.6f, avgSpeed * 1.4f);
        }
        else if(transform.position.x < -maxX)
        {
            direction = 1;
            speed = Random.Range(avgSpeed * 0.6f, avgSpeed * 1.4f);
        }
    }
}
