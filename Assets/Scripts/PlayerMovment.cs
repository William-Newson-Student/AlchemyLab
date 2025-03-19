using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    CharacterController caracterController;

    public float moveSpeed = 5f;
    private Vector3 movedirection;
    void Start()
    {
        caracterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
     // recive input
        
        movedirection.Normalize();
        movedirection.y = -1f; // gravity

     // move player
        caracterController.Move(movedirection * moveSpeed * Time.deltaTime);
    }
    public void AddMoveInput(float forwardInput, float rightInput)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        movedirection = (forwardInput * forward) + (rightInput * right);
    }
    
}
