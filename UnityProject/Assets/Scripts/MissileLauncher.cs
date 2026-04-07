using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    [SerializeField] private GameObject missilePrefab;
    [SerializeField] private Transform missileSpawn;
    [SerializeField] private ThreatRadar threatRadar;
    
    private GameObject activeMissile;

    public void DestroyActiveMissile()
    {
        if (activeMissile != null)
        {
            Destroy(activeMissile);
            activeMissile = null;

            if (threatRadar != null)
            {
                threatRadar.SetIncomingMissile(null);
            }
        }
    }

    public GameObject Launch(Transform target)
    {
        activeMissile = Instantiate(missilePrefab, missileSpawn.position, missileSpawn.rotation);
        activeMissile.GetComponent<MissileHoming>().SetTarget(target);

        if (threatRadar != null)
        {
            threatRadar.SetIncomingMissile(activeMissile.transform);
        }
        return activeMissile;
    }
}
