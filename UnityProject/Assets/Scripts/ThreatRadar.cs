using System;
using UnityEngine;

public class ThreatRadar : MonoBehaviour
{
    [Header("Radar References")]
    public RectTransform radarArrow;
    public Transform playerTransform;
    public Camera mainCamera;

    [Header("Radar Settings")] 
    public float edgePadding = 50f;
    
    private Transform activeMissile;

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
        
        if (radarArrow != null)
        {
            radarArrow.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (activeMissile == null || playerTransform == null || mainCamera == null)
        {
            if (radarArrow.gameObject.activeSelf)
                radarArrow.gameObject.SetActive(false);
            return;
        }
        
        if (!radarArrow.gameObject.activeSelf)
            radarArrow.gameObject.SetActive(true);
        
        Vector3 screenPos = mainCamera.WorldToScreenPoint(activeMissile.position);
        Vector3 screenCenter = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        
        Vector3 direction = screenPos - screenCenter;
        direction.z = 0f;

        if (screenPos.z < 0)
        {
            direction *= -1f;
        }
        
        Vector3 dirNorm = direction.normalized;
        
        float angle = Mathf.Atan2(dirNorm.y, dirNorm.x) * Mathf.Rad2Deg;
        radarArrow.localEulerAngles = new Vector3(0f, 0f, angle - 90f);
        
        Vector3 screenBounds = new Vector3((Screen.width / 2f) - edgePadding, (Screen.height / 2f) - edgePadding, 0f);
        
        float scaleX = Mathf.Abs(screenBounds.x / dirNorm.x);
        float scaleY = Mathf.Abs(screenBounds.y / dirNorm.y);
        
        float minScale = Mathf.Min(scaleX, scaleY);
        
        Vector3 edgePos = screenCenter + (dirNorm * minScale);
        radarArrow.position = edgePos;
    }

    public void SetIncomingMissile(Transform missile)
    {
        activeMissile = missile;
    }
}