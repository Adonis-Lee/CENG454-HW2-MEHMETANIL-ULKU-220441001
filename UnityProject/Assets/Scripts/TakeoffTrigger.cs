using UnityEngine;

public class TakeoffTrigger : MonoBehaviour
{
    [SerializeField] private FlightExamManager examManager;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            examManager.TakeOff();
        }
    }
}
