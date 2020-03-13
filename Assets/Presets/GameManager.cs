using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public GameObject completeLevelUI;

    bool gameHasEnded = false;

    public float Delay = 2f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("end");
            Invoke("Restart", Delay);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
