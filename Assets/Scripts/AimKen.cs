using UnityEngine;
using System.Collections;

public class AimKen : MonoBehaviour {
    public GameObject point;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.LookAt(new Vector3(point.transform.position.x, point.transform.position.y, 0)); //new Vector3(Input.mousePosition.x, 0, 0)
//        transform.Rotate(new Vector3(transform.rotation.x - 90, 0, 0));
    }
}
