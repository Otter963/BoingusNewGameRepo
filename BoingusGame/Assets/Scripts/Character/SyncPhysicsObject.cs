using UnityEngine;

/*References:
Title: Tutorial series: Active Ragdoll Online multiplayer with Photon Fusion & Unity. 
Author: Pretty Fly Games
Date: 2024, July 16
Code version: 6000.0.51f1
Availability: https://youtube.com/playlist?list=PLyDa4NP_nvPeSosMrZ0Gv03v5s4k7Le7N&si=zdK90WrcznovDCtC
*/

public class SyncPhysicsObject : MonoBehaviour
{
    Rigidbody myRB;
    ConfigurableJoint joint;

    [SerializeField] Rigidbody animatedRigidBody;

    [SerializeField] bool syncAnimation = false;

    //keep track of the starting rotation
    Quaternion startLocalRotation;

    void Awake()
    {
        myRB = GetComponent<Rigidbody>();
        joint = GetComponent<ConfigurableJoint>();

        //storing the starting local rotation
        startLocalRotation = transform.localRotation;
    }

    public void UpdateJointFromAnimation()
    {
        if (!syncAnimation)
            return;

        ConfigurableJointExtensions.SetTargetRotationLocal(joint, animatedRigidBody.transform.localRotation, startLocalRotation);
    }
}
