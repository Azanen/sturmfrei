using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsPonoAnim : MonoBehaviour
{
    public string footWalk = "Foot_Walk";
    public string footJump = "Foot_Jump";
    public string footIdle = "Foot_Idle ";
    public string footInteract = "Foot_Interaction";
    public string footFalling = "Foot_Falling";
    public string footDashJump = "Foot_DashJump";
    public string footLanging = "Foot_Landing";
    public string flyingStart = "Flying_Start";
    public string flyingForward = "Flying_Idle";
    public string flyingDown = "Flying_Down";
    public string flyingDash = "Flying_Dash";
    public string flyingLanding = "Flying_Landing";
    public string flyingStunned = "Flying_Stunned";
    public bool debugEnabled = false;
    public GameObject ponoAnim;

    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    //On foot
    void Foot_Walk()
    {
        AkSoundEngine.PostEvent(footWalk, gameObject);
        if (debugEnabled) { Debug.Log("walking"); }
    }

    void Foot_Jump()
    {
        AkSoundEngine.PostEvent(footJump, gameObject);
        if (debugEnabled) { Debug.Log("jumping"); }
    }

    void Foot_Idle()
    {
        AkSoundEngine.PostEvent(footIdle, gameObject);
        if (debugEnabled) { Debug.Log("idling"); }
    }

    void Foot_Interaction()
    {
        AkSoundEngine.PostEvent(footInteract, gameObject);
        if (debugEnabled) { Debug.Log("Interacting"); }
    }

    void Foot_Falling()
    {
        AkSoundEngine.PostEvent(footFalling, gameObject);
        if (debugEnabled) { Debug.Log("falling"); }

    }

    void Foot_DashJump()
    {
        AkSoundEngine.PostEvent(footDashJump, gameObject);
        if (debugEnabled) { Debug.Log("dashingUp"); }

    }

    void Foot_Landing()
    {
        AkSoundEngine.PostEvent(footLanging, gameObject);
        if (debugEnabled) { Debug.Log("landingStraight"); }
    }

    //Flying

    void Flying_Start()
    {
        AkSoundEngine.PostEvent(flyingStart, gameObject);
        if (debugEnabled) { Debug.Log("wingSwitch"); }
    }

    void Flying_Idle()
    {
        AkSoundEngine.PostEvent(flyingForward, gameObject);
        if (debugEnabled) { Debug.Log("flying"); }
    }

    void Flying_Down()
    {
        AkSoundEngine.PostEvent(flyingDown, gameObject);
        if (debugEnabled) { Debug.Log("flyingDown"); }
    }

    void Flying_Dash()
    {
        AkSoundEngine.PostEvent(flyingDash, gameObject);
        if (debugEnabled) { Debug.Log("flyingDash"); }
    }

    void Flying_Landing()
    {
        AkSoundEngine.PostEvent(flyingLanding, gameObject);
        if (debugEnabled) { Debug.Log("landingRun"); }
    }

    void Flying_Stunned()
    {
        AkSoundEngine.PostEvent(flyingStunned, gameObject);
        if (debugEnabled) { Debug.Log("Stunned"); }
    }
}
