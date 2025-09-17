using System;
using UnityEngine;
using UnityEngine.InputSystem;

/*References:
Title: Unity 6 Split-Screen Multiplayer (2–4 Players) with the New Input System 
Author: Faktory Studios
Date: 2025, June 25
Code version: 6000.0.51f1
Availability: https://www.youtube.com/watch?v=55MPgeVaqpU
*/

[RequireComponent(typeof(Camera))]
public class SplitScreenCamera : MonoBehaviour
{
    private Camera cam;
    private int index;
    private int totalPlayers;

    private void Awake()
    {
        PlayerInputManager.instance.onPlayerJoined += HandlePlayerJoined;
    }

    private void HandlePlayerJoined(PlayerInput input)
    {
        totalPlayers = PlayerInput.all.Count;
        SetupCamera();
    }

    private void SetupCamera()
    {
        if (totalPlayers == 1)
        {
            cam.rect = new Rect(0, 0, 1, 1);
        }
        else if (totalPlayers == 2)
        {
            cam.rect = new Rect(index == 0 ? 0 : 0.5f, 0, 0.5f, 1);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        index = GetComponentInParent<PlayerInput>().playerIndex;
        totalPlayers = PlayerInput.all.Count;
        cam = GetComponent<Camera>();
        cam.depth = index;

        SetupCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
