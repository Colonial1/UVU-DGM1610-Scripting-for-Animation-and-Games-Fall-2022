using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float speed;

   private float xRange = 11.0f;

    public GameObject LaserBolt;

    public Transform Blaster; // point of orgin for the LaserBolt
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontal input to recieve values from the keyboard keymap horizontal -1 1
        hInput = Input.GetAxis("Horizontal");
        
        //Move the player left and right
    transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);
    
    //Keep player within set bounds
    //Keep player inside right wall at set xRange

    if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    if(Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(LaserBolt, Blaster.transform.position, Blaster.transform.rotation); // Initiate LaserBolt GameObject at Blaster position
    }

    }
}
