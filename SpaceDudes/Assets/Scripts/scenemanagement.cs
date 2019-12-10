using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagement : MonoBehaviour
{
    // Start is called before the first frame update
    public void P1Wins()
    {
        SceneManager.LoadScene("P1Wins");
    }

    public void P2Wins()
    {
        SceneManager.LoadScene("P2Wins");
    }

    public void Restart()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
