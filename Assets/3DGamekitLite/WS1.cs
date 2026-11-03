using UnityEngine;
using UnityEngine.Events;
//using UnityEngine.InputSystem;
using Gamekit3D;

public class WS1 : MonoBehaviour
{
    public int myNumber = 0;

    private Rigidbody2D rb;

    public UnityEvent onStart;

    private float timer = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onStart.Invoke();

        myNumber++;
        myNumber = myNumber + 1;
        myNumber += 1;
        
        myNumber = Random.Range(0, 10);
        //Debug.Log(myNumber);
        
        string playerName = "Sella";
        playerName = "Norling";
        
        rb = GetComponent<Rigidbody2D>();

        for (int counter = 0; counter < 10; counter++)
        {
            Debug.Log(counter);
            
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        Debug.Log(timer);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            YSpeed();
        }
    }

    public void YSpeed()
    {
        if (myNumber == 39)
        {
            rb.linearVelocityY = 13.37f;
        }
    }
    
}
