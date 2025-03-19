using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sit : MonoBehaviour
{
    public GameObject theOneWhoSits;
    bool keepSiting = false;
    public void RunToilet()
    {
        keepSiting = true;
        InvokeRepeating("Toilet", 0.01f, 0.01f);
    }
    private void Toilet()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            keepSiting = false;
        }
        else if (keepSiting == true)
        {
            theOneWhoSits.transform.position = new Vector3(4f, 0.4f, -5.75f);
        }
        else
        {
            Unsit();
        }
    }

    public void Unsit()
    {
        theOneWhoSits.transform.position = new Vector3(4f, 0.6799998f, -5);
        theOneWhoSits.GetComponent<CharacterController>().enabled = true;
        CancelInvoke("Toilet");
    }
}
