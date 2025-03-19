using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{

    float xAxis;
    float yAxis;

    float XSensitivity = 36;
    float YSensitivity = 36;

    public float Sensitivity;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;        
    }

    // Update is called once per frame

    private void LateUpdate()
    {
        Quaternion newrotation = Quaternion.Euler(xAxis, yAxis, 0);

        Camera.main.transform.rotation = newrotation;
    }

    public void AddXAsixInput(float input)
    {
        xAxis -= input * Sensitivity * XSensitivity;
        xAxis = Mathf.Clamp(xAxis, -90, 90);
    }
    public void AddYAsixInput(float input)
    {
        yAxis += input * Sensitivity * YSensitivity;

    }
}
