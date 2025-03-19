using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "i'm an interactable object!";
    public UnityEvent OnInteract = new UnityEvent();

    private void OnEnable()
    {
        
    }

    public string GetInterationText()
    {
        return interactionText;
    }

    public void Interact()
    {
        OnInteract.Invoke();
    }
}
