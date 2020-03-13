
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public SphereMovement movement;
    
        void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
           
        }
    }
}
