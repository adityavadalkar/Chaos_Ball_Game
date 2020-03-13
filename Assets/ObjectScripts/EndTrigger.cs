
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public SphereMovement movement;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
        movement.enabled = false;

    }


}
