using TMPro;
using UnityEngine;

public class AircraftThreatHandler : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private FlightExamManager examManager;
    [SerializeField] private AudioSource explosionSource;
    [SerializeField] private GameUIManager uiManager;


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
            TriggerCrash();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            TriggerCrash();
        }
    }

    private void TriggerCrash()
    {
        if (explosionSource != null)
        {
            explosionSource.ignoreListenerPause = true;
            explosionSource.PlayOneShot(explosionSource.clip);
        }

        if (uiManager != null)
        {
            uiManager.TriggerGameOver();
        }
    }
}
