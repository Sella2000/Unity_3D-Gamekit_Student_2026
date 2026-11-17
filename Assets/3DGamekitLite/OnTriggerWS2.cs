using Gamekit3D;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;


public enum ElementalPower
{                         
    None,                 
    Fire,                 
    Lightning,            
    Ice,                  
    Earth,                
}
[System.Serializable]
public struct CharacterInformation
{
    public string name;
    public ElementalPower elementalPower;
    public float speed;
    public int Health;
    public bool canFly;
    public int damagePower;

}

public class OnTriggerWS2 : MonoBehaviour
{
    public CharacterInformation Character;
    
    
    
    public ElementalPower ElementKraft;

    public int[] characterInformation;

    public int[] highScore;
    
    private void Start()
    {
        Debug.Log(ElementKraft);
        
        Debug.Log(characterInformation);

        Debug.Log(highScore[0]);
        Debug.Log(highScore[1]);
        Debug.Log(highScore[2]);
        Debug.Log(highScore[3]);

        if (highScore[0] < highScore[1]) 
        {
            Debug.Log("nice");
        } 
        
        switch (ElementKraft)
        {
            case ElementalPower.Fire:                 <
                //Run this code
            Debug.Log("Fire");
                if (true == false)
                {
                    Debug.Log("IMPOSSIBLE!");    
                }

                break;
            case ElementalPower.Ice:
                Debug.Log("Ice");
                break;
            
            case ElementalPower.Earth:
                Debug.Log("Earth");
                break;
            
            case ElementalPower.Lightning:
                Debug.Log("Lightning");
                break;
            
        }

        //eventInstance = RuntimeManager.CreateInstance(eventRef);
        //eventInstance.start();
        
        //eventInstance.getPlaybackState(out PLAYBACK_STATE state);
        //Debug.Log(state);


        //foreach (CharacterInformation score in characterInformation) 
        {
            //Debug.Log(score.name);
        }
    }

    private void Update()
    {
        //if (highScore == [1336])
        //{
            //Debug.Log("Nice");
            
        //}
    }
    
    //private void OnTriggerEnter(Collider other)
    //{
        //if (other.tag == "Player")
        //{
            //Debug.Log("Triggered");
        //}
    //}        
}
