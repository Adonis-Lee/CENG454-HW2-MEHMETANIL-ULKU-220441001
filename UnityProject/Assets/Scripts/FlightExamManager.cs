using UnityEngine;
using TMPro;

public class FlightExamManager : MonoBehaviour
{
    [SerializeField] private TMP_Text statusText;
    [SerializeField] private TMP_Text missionText;
    
    [SerializeField] private AudioSource warningSource;
    [SerializeField] private AudioSource winSource;
    
    private bool hasTakenOff = false;
    private bool enteredDangerZone = false;
    private bool threatCleared = false;
    private bool missionCompleted = false;
    
    void Start()
    {
        
        statusText.text = "";
        missionText.text = "";
        
    }
    
    void Update()
    {
        
    }

    public void EnterDangerZone()
    {
        enteredDangerZone = true;
        statusText.text = "Entered a Danger Zone!";
        warningSource.Play();
    }

    public void ExitDangerZone()
    {
        enteredDangerZone = false;
        statusText.text = "";
        threatCleared = true;
        warningSource.Stop();
    }

    public void TakeOff()
    {
        hasTakenOff = true;
        missionText.text = "Take off successful!\nHead to the danger zone.";
    }
    
    public void LandingAttempt()
    {
        if (hasTakenOff && threatCleared && !missionCompleted)
        {
            missionCompleted = true;
            missionText.text = "Mission completed successfully!";
            statusText.text = "";
            winSource.Play();
        }
        
        else if (!threatCleared)
        {
            missionText.text = "Clear Threat Zone!";
        }
    }
}
