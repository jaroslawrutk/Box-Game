using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    gameManage game;
    gameManage GAM1;

	// Use this for initialization
	public void OnTriggerEnter()
    {
        GAM1.finishlevel();

    }
}
