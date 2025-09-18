using UnityEngine;
using UnityEngine.InputSystem;

/*References:
Title: Pick up and throw stuff in Unity 6! 2024 tutorial
Author: Matt’s Computer Lab
Date: 2024, December 15
Code version: 6000.0.51f1
Availability: https://www.youtube.com/watch?v=fApXEL0xsx4
*/

public class Pickup : MonoBehaviour
{
    //player input
    [SerializeField] private InputActionAsset playerInput;
    private InputAction pickupAction;

    bool isHolding = false;

    //[SerializeField] float throwForce = 600f;

    //[SerializeField] float maxDistance = 3f;

    float distance;

    TempParent tempParent;
    Rigidbody rb;

    Vector3 objectPos;

    private void Awake()
    {
        pickupAction = playerInput.FindActionMap("Player").FindAction("Pickup");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tempParent = TempParent.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        OnButtonDown();

        if (isHolding)
        {
            Hold();
        }
    }

    private void OnButtonDown()
    {
        //pickup
        if (tempParent != null)
        {
            isHolding = true;
            rb.useGravity = false;
            rb.detectCollisions = true;

            this.transform.SetParent(tempParent.transform);
        }
        else
        {
            Debug.Log("Temp parent item not found in scene!");
        }
    }

    private void OnButtonUp()
    {
        //drop
    }

    private void Hold()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        if (pickupAction.IsPressed())
        {
            //throw
        }
    }
}
