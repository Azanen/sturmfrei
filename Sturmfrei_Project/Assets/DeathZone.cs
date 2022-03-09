using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Vector3 respawnPoint;
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            respawnPoint = other.GetComponent<PlayerCollisionSphere>().PlayerMov.gameObject.GetComponent<PlayerRespawn>().respawnPoint;

            other.transform.position = respawnPoint;
        }
    }
}

