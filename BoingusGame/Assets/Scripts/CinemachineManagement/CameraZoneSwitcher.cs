using Unity.Cinemachine;
using UnityEngine;

/*References:
Title: How to switch cameras in Cinemachine | Unity Tutorial 
Author: This is GameDev
Date: 2023, March 22
Code version: 6000.0.51f1
Availability: https://www.youtube.com/watch?v=X_vK66w3GJk
*/

public class CameraZoneSwitcher : MonoBehaviour
{
    public string triggerTag;

    public CinemachineCamera primaryCamera;

    public CinemachineCamera[] otherCameras;

    private void Start()
    {
        SwitchToCamera(primaryCamera);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            CinemachineCamera targetCamera = other.GetComponentInChildren<CinemachineCamera>();
            SwitchToCamera(targetCamera);
            SoundManager.PlaySound(SoundType.TUTORIALVOICETHREE);
        }
    }

    private void SwitchToCamera(CinemachineCamera targetCamera)
    {
        foreach (CinemachineCamera camera in otherCameras)
        {
            camera.enabled = camera == targetCamera;
        }
    }
}
