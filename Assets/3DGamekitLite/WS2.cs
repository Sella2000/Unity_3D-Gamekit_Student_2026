using UnityEngine;
using Gamekit3D;
using FMODUnity;
using FMOD.Studio;

public class WS2 : MonoBehaviour
{

    public float timer = 5f; 
    
    
    public EventInstance Instance;
    public EventReference referens;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //eventInstance = RuntimeManager.CreateInstance(referens);
        //Instance.start();

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            
        }
    }
}
