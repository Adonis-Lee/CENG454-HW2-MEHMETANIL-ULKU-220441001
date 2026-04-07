using UnityEngine;

public class AircraftThreatHandler : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private FlightExamManager examManager;
    [SerializeField] private AudioSource explosionSource;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            Destroy(other.gameObject);
            transform.position = respawnPoint.position;
            transform.rotation = respawnPoint.rotation;
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            explosionSource.PlayOneShot(explosionSource.clip);
        }
    }
}
