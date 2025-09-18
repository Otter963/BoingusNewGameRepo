using UnityEngine;

/*References:
Title: Pick up and throw stuff in Unity 6! 2024 tutorial
Author: Matt’s Computer Lab
Date: 2024, December 15
Code version: 6000.0.51f1
Availability: https://www.youtube.com/watch?v=fApXEL0xsx4
*/

public class TempParent : MonoBehaviour
{
    public static TempParent Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
