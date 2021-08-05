using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody myRigidbody;
    private Vector3 change;
    public VectorValue playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        transform.position = playerPosition.initialValue;
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.z = Input.GetAxisRaw("Vertical");
        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
