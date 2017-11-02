using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour {

    public Transform goal;
    public float speed;
    // Use this for initialization
    void Start () {
        
        speed = Random.Range(0.5f,2f);
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, goal.position, step);
        
        RaycastHit hit; //check when hit
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.2f) && hit.collider.tag == "wall")
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y + 2, transform.rotation.z,transform.rotation.w);
        }
    }
}
