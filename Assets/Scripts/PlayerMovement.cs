using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    float step = 3.0f;
    public GameObject Chicken;
    private float tooFarLeft = -23;
    private float tooFarRight = 23;

	// Use this for initialization
	void Start () {
       // Chicken = this.gameObject.transform.GetChild(0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, step), Space.World);
            Chicken.transform.eulerAngles = new Vector3(0, 270, 0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector3(-step, 0, 0), Space.World);
            Chicken.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -step), Space.World);
            Chicken.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(new Vector3(step, 0, 0), Space.World);
            Chicken.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (transform.position.x <= tooFarLeft)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (transform.position.x >= tooFarRight)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
