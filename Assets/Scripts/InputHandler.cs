using UnityEngine;

public class InputHandler : MonoBehaviour
{
    FirstPersonCam firstPersonCam;
    PlayerMovment playerMovment;
    PlayerInteraction playerInteraction;
    void Start()
    {
        firstPersonCam = GetComponent<FirstPersonCam>();
        playerMovment = GetComponent<PlayerMovment>();
        playerInteraction = GetComponent<PlayerInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCamInput();
        HandleMoveInput();
        HandleInteractionInput();
    }

    void HandleCamInput()
    {
        firstPersonCam.AddXAsixInput(Input.GetAxisRaw("Mouse Y") * Time.deltaTime);
        firstPersonCam.AddYAsixInput(Input.GetAxisRaw("Mouse X") * Time.deltaTime);
    }
    void HandleMoveInput()
    {
        float forwardInput = Input.GetAxisRaw("Vertical");
        float rightInput = Input.GetAxisRaw("Horizontal");

        playerMovment.AddMoveInput(forwardInput, rightInput);
    }

    void HandleInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerInteraction.TryInteract();
        }
    }
}
