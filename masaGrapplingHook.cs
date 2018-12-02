using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masaGrapplingHook : MonoBehaviour {

    //public LineRenderer line;
    DistanceJoint2D joint;
    GameObject ship;
    Vector3 targetPos;
    RaycastHit2D hit;
    public float distance = 10f;
    public LayerMask mask; //might be useless to code

	// Use this for initialization
	void Start () {
        joint = GetComponent<DistanceJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
        targetPos = ship.transform.position;
        targetPos.z = 0;

        hit = Physics2D.Raycast(transform.position, targetPos - transform.position, distance, mask); //simulates being pulled by boat

        //line.SetPosition(0, transform.position);
        //line.SetPosition(1, targetPos);
	}
}
