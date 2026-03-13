// FlightController.cs
// CENG 454 - HW1 : Sky-High Prototype
// Author: Mehmet Anil ULKU | Student ID: 220441001

using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] private float pitchSpeed = 45f;
    [SerializeField] private float yawSpeed = 45f;
    [SerializeField] private float rollSpeed = 45f;
    [SerializeField] private float thrustSpeed = 5f;
    
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;       // I will change rotation with just transform.
    }
    
    void Update()
    {
        HandleRotation();
        HandleThrust();
    }

    private void HandleRotation()
    {
        float pitch = Input.GetAxis("Vertical") * pitchSpeed * Time.deltaTime;
        transform.Rotate(Vector3.right * pitch);
        
        float yaw = Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * yaw);

        float roll = 0f;
        if (Input.GetKey(KeyCode.E))
        {
            roll = -1f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            roll = 1f;
        }
        
        transform.Rotate(Vector3.forward * roll * rollSpeed * Time.deltaTime);
    }

    private void HandleThrust()
    {
        transform.Translate(Vector3.down * 3f * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * thrustSpeed * Time.deltaTime);
            
        }
    }
}
