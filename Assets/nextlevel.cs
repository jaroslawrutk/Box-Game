
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour {

    public void startnext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
