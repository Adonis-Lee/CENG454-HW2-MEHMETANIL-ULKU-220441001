using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    [SerializeField] private GameObject missilePrefab;
    [SerializeField] private Transform missileSpawn;
    private GameObject activeMissile;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DestroyActiveMissile()
    {
        if (activeMissile != null)
        {
            Destroy(activeMissile);
            activeMissile = null;
        }
    }

    public GameObject Launch(Transform target)
    {
        activeMissile = Instantiate(missilePrefab, missileSpawn.position, missileSpawn.rotation);
        activeMissile.GetComponent<MissileHoming>().SetTarget(target);
        return activeMissile;
    }
}
