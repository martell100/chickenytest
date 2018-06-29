using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour
{
    //Public variable to store a reference to the player game object
    public GameObject player;

    //Private variable to store the offset distance between the player and camera
    private Vector3 offset;

    //Looking from Vector3.SmoothDamp docs
    private Vector3 velocity = Vector3.zero;
    private float distance;

    //This is how fast the camera will "chase" the player.
    private float speed;

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        //This is used to determine how far the player is from the camera, and how quickly the camera should snap to it.
        distance = Vector3.Distance(transform.position, player.transform.position + offset);

        if (distance > 2.5f)
        {
            Debug.Log(distance);
            speed = 0.8f;
            transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, speed);
        }
        if (distance > 11)
        {
            speed = 0.1f;
        }
        else
        {
            speed = 0.8f;
        }
    }
}