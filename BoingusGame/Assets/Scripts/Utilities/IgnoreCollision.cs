using UnityEngine;

/*References:
Title: Tutorial series: Active Ragdoll Online multiplayer with Photon Fusion & Unity. 
Author: Pretty Fly Games
Date: 2024, July 16
Code version: 6000.0.51f1
Availability: https://youtube.com/playlist?list=PLyDa4NP_nvPeSosMrZ0Gv03v5s4k7Le7N&si=zdK90WrcznovDCtC
*/

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] Collider thisCollider;

    [SerializeField] Collider[] colliderToIgnore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Collider otherCollider in colliderToIgnore)
        {
            Physics.IgnoreCollision(thisCollider, otherCollider, true);
        }
    }

    
}
