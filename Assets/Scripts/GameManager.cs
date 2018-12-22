using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int attempts = 1;

    bool hasLost = false;

    public float restartDelay = 1f;

    public GameObject EndUI;

    public Text attempt;
    public Text endAttempts;

    public void GameOver()
    {
        if(!hasLost)
        {
            Debug.Log("Game Over");
            hasLost = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        attempts = attempts + 1;
    }

    public void CompleteLevel()
    {
        endAttempts.text = attempts.ToString();
        EndUI.SetActive(true);
        attempts = 1;
    }
}
