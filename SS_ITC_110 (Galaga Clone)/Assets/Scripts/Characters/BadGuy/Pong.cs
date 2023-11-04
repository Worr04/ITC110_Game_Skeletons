using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour
{
    public GameObject obj;
    public Vector2 startPos;
    public Vector2 endPos;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        if (transform.position == new Vector3(endPos.x, endPos.y, 0)) 
        {
            Vector2 temp = endPos;
            endPos = startPos;
            startPos = temp;
        }
    }
}
