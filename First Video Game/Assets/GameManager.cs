using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float RestartOffset = 1f;

    public GameObject CompleteLevelUI;
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GAME OVER");
            gameHasEnded = true;
            Invoke("Restart", RestartOffset);
        }
    }

    public void LevelComplete ()
    {
        CompleteLevelUI.SetActive(true);
        Debug.Log("Level Complete");
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
