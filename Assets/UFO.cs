using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{

    public Rigidbody leftLegRigidBody;
    public Rigidbody rightLegRigidBody;
    public float speed = 3f;
    public float rotationMultiplayer = 0.8f;
    public SceneLoader sceneLoader;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            leftLegRigidBody.AddRelativeForce(Vector3.up * speed);
            rightLegRigidBody.AddRelativeForce(Vector3.up * speed * rotationMultiplayer);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rightLegRigidBody.AddRelativeForce(Vector3.up * speed);
            leftLegRigidBody.AddRelativeForce(Vector3.up * speed * rotationMultiplayer);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            leftLegRigidBody.AddRelativeForce(Vector3.up * speed);
            rightLegRigidBody.AddRelativeForce(Vector3.up * speed);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy");
        }
        else if (collision.gameObject.tag == "Friend")
        {
            Debug.Log("Friend");
        }
    }
}
