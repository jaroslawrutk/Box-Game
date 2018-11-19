using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    Button startGame;
    private void Start()
    {
        startGame = GameObject.Find("Start Game").GetComponent<Button>();
        startGame.onClick.AddListener(() => Startuje());
    }
    public void Startuje()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
