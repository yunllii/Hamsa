using UnityEngine;
using System.Collections;

public class playNote : MonoBehaviour {


    AudioSource do_note;
	// Use this for initialization
	void Start () {
        do_note = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        
            do_note.Play();
            Debug.Log("Haha");


    }
}
