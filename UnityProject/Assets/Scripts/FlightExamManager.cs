using UnityEngine;
using TMPro;

public class FlightExamManager : MonoBehaviour
{
    [SerializeField] private TMP_Text statusText;
    [SerializeField] private TMP_Text missionText;
    [SerializeField] private AudioSource warningSource;
    
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
}
