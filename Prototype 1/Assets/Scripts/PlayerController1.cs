using UnityEngine;

public class PlayerController1 : MonoBehaviour
{  
    // Private Variable
    private float speed = 5.0f;
    private float turnSpeed;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We'll Move our vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        // We Turn Vehicles
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
 