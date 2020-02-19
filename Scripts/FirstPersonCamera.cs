using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float smooth = 5;
    public float lookSpeed = 1;
    private float lookLeftRight = 0;
    private float lookUpDown = 0;
    public GameObject target;

    public float gravity = -1;
    public float speed = 1;
    

    
    void Start()
    {
        
    }

    // This script should be put onto the player object, with the player object being the GameObject target. The camera should be attached to the player.
    void Update()
    {
        
        lookLeftRight = (Input.GetAxis("Mouse X") * lookSpeed) + lookLeftRight;
        lookUpDown = (Input.GetAxis("Mouse Y") * lookSpeed) + lookUpDown;
        //float x = Mathf.Clamp(lookLeftRight, -170f, 170f);
        float y = Mathf.Clamp(lookUpDown, -90f, 90f);

        Quaternion rotate = Quaternion.Euler(-y, lookLeftRight, 0);
        target.transform.localRotation = Quaternion.Slerp(target.transform.localRotation, rotate, smooth);
    }
    //This lets the player object move. However, this does not move based on the local roatation, meaning that A and D will always move the player in the same global direction. Not currently sure how to fix this.
    private void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveHoriz, gravity, moveVert);
        //target.transform.right = new Vector3(moveHoriz, 0, 0) * speed;
        //target.transform.forward = new Vector3(0, 0, moveVert) * speed;
        GetComponent<Rigidbody>().velocity = move * speed;
    }


}
