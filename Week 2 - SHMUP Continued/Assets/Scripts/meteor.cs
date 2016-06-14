using UnityEngine;
using System.Collections;

public class meteor : MonoBehaviour {

    

    public float xLower;
    public float xUpper;

    public float zLower;
    public float zUpper;
    public Vector3 newPos;
    public Quaternion newRot;
    public float randXRot;
    public float randYRot;
    public float randZRot;

    public float moveSpeed;
    public float maxSpeed;
    public float minSpeed;

    public GameObject model;
    public Rigidbody rb;



    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(this.gameObject.transform.position.z < zLower)
        {
            newPos.x = Random.Range(xLower, xUpper);
            newPos.y = transform.position.y;
            newPos.z = zUpper;
            newRot.x = Random.Range(0, 360);
            newRot.y = Random.Range(0, 360);
            newRot.z = Random.Range(0, 360);
            transform.position = newPos;
            model.transform.rotation = newRot;
            moveSpeed = Random.Range(minSpeed, maxSpeed);
            rb.AddTorque(transform.up * randXRot);
            rb.AddTorque(transform.forward * randYRot);
            rb.AddTorque(transform.right * randZRot);
        }
        model.transform.position = transform.position;
        transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        randXRot = Random.Range(-50, 50);
        randYRot = Random.Range(-50, 50);
        randZRot = Random.Range(-50, 50);

    }
}
