using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogicManagerScript : MonoBehaviour
{
    public GameObject seat;
    public float startPoint = -0.5f;
    public float endPoint = 0.5f;
    public float distance;
    public Vector2 force = new Vector2(0, 0);
    public Vector2 addedForce = new Vector2(0.3f,0);
    public Vector2 friction = new Vector2(-0.03f, 0);
    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        distance = endPoint - startPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            addForce();
            seat.GetComponent<SpriteRenderer>().color = Color.red;
        }

        force =;
        Debug.Log(force);
    }

    void addForce()
    {
        force += addedForce;
    }
}
