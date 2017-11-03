using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour {

    public Transform goal;
    public float speed;
    // Use this for initialization
    void Start () {

        speed = 0.5f;
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, goal.position, step);

    }
}
