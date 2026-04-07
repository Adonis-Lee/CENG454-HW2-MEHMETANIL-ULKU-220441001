using UnityEngine;
using System.Collections;

public class DangerZoneController : MonoBehaviour
{
    [SerializeField] private FlightExamManager examManager;
    [SerializeField] private MissileLauncher missileLauncher;

    [SerializeField] private float missileDelay = 5f;
    
    Coroutine activeCountdown = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            examManager.EnterDangerZone();
            if (activeCountdown == null)
            {
                activeCountdown = StartCoroutine(MissileCountdown(other.transform));    
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (activeCountdown != null)
            {
                StopCoroutine(activeCountdown);
                activeCountdown = null;
            }
            
            missileLauncher.DestroyActiveMissile();
            
            examManager.ExitDangerZone();
        }
    }

    private IEnumerator MissileCountdown(Transform other)
    {
        yield return new WaitForSeconds(missileDelay);
        missileLauncher.Launch(other);

        activeCountdown = null;
    }
}
