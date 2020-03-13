using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 1000f;

 

 
    // Update is called once per frame
    void Update()
    {


        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        { 
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.Acceleration);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
