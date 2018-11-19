using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

    public gameManage game;

    // Use this for initialization
    public void OnTriggerEnter()
    {
        game.finishlevel();

    }
}
