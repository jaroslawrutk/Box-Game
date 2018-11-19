using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    Button startGame;
    private void Start()
    {
        startGame = GameObject.Find("Reset").GetComponent<Button>();
        startGame.onClick.AddListener(() => Startuje());
    }
    public void Startuje()
    {
        SceneManager.LoadScene(1);
    }
}
