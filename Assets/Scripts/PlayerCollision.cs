using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollision : MonoBehaviour {

    public GameObject playerAlive;
    public GameObject playerDead;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            playerAlive.SetActive(false);
            playerDead.SetActive(true);
            StartCoroutine(WaitToReload());
           // playerAlive.SetActive(true);
           // playerDead.SetActive(false);
        }
    }
    IEnumerator WaitToReload()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
