using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManage : MonoBehaviour {

    bool gamended = false;


    public GameObject CompleteUI;
    public Movment mov;


    public void finishlevel()
    {
        CompleteUI.SetActive(true);
        mov.enabled = false;
    }



	public void EndGame()
    {
        if (gamended == false)
        {

            gamended = true;
            Debug.Log("ENDGAME");
            Invoke("Restart", 2f);

        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
