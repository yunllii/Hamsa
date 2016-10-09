using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cliff : MonoBehaviour {

    public GameObject VRcamera;
    public GameObject All_Scenes;
    bool startFalling = false;
    

	// Use this for initialization
	void  Awake() {
        Vector3 tempPos = VRcamera.transform.position;
        tempPos.y = -0.5f;
        tempPos.x -= -0.5f;
        All_Scenes.transform.position = tempPos;

        Debug.Log("I am awake");


	}
	
	// Update is called once per frame
	void Update () {
        if (startFalling == true) {
            allThingsFall();
        }
        

    }

    void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.name == "Camera (eye)") {
            //collision.gameObject.name == "Cube (2)"
            StartCoroutine(Fall());
        }

       // Debug.Log(collision.gameObject.name);
    }

    void allThingsFall() {
        Vector3 tempPos2 = All_Scenes.transform.position;
        tempPos2.y += 0.2f;
        All_Scenes.transform.position = tempPos2;

    }


    IEnumerator Fall() {
        startFalling = true;
        yield return new WaitForSeconds(5);
        startFalling = false;
        SceneManager.LoadScene("Bridge");
        Debug.Log("Reload");
    }
}
