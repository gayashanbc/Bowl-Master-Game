using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Rigidbody rigidBody;
    private AudioSource audioSource;
    private Vector3 ballStartPosition;

    public bool inPlay = false;


	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        ballStartPosition = transform.position;
    }

    public void Launch(Vector3 velocity) {
        inPlay = true;

        rigidBody.useGravity = true;
        rigidBody.velocity = velocity;
        
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    public void Reset() {
        inPlay = false;
        transform.position = ballStartPosition;

        //reset rotation to (0, 0, 0)
        transform.rotation = Quaternion.identity;

        rigidBody.velocity = Vector3.zero; ;
        rigidBody.angularVelocity = Vector3.zero;
        rigidBody.useGravity = false;
    }

}
