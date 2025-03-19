using UnityEngine;

public class Flicker : MonoBehaviour
{
    public float LightTime = 0.15f;
    public float LightMin = 1f;
    public float LightMax = 5f;
    public new Light light;
    void Awake()
    {
        light = GetComponent<Light>();
    }
    void Start()
    {
        InvokeRepeating("Flickerer", 0f, LightTime);
    }
    
    void Flickerer()
    {
        light.intensity = Random.Range(LightMin, LightMax);
    }
}
