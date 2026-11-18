using UnityEngine;
using FMOD.Studio;
using FMODUnity;

public class AudioTrigger : MonoBehaviour
{
    
public EventReference eventReference;
private EventInstance eventInstance;


    private void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
    }

    private void OnTriggerEnter(Collider other)
    {
        eventInstance.start();
        eventInstance.getPlaybackState(out PLAYBACK_STATE state);
        
        switch (state)
        {
            case PLAYBACK_STATE.PLAYING:
                break;
            case PLAYBACK_STATE.STARTING:
                break;
            case PLAYBACK_STATE.SUSTAINING:
                break;
            case PLAYBACK_STATE.STOPPING:
                break;
            case PLAYBACK_STATE.STOPPED:
                break;

                EventInstance instance = RuntimeManager.CreateInstance(eventReference);

                instance.getDescription(out EventDescription eventDescription);
                eventDescription.loadSampleData();
                
        }
        
        
        //pause the current event
        eventInstance.setPaused(true);
        
    }
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
