
using UnityEngine;

public class Collision : MonoBehaviour {

    public Movment mov;


	void OnCollisionEnter (UnityEngine.Collision collision) {
       
        if (collision.collider.tag == "Przeszkoda")
        {
         
            mov.enabled = false;
            FindObjectOfType<gameManage>().EndGame();
            Debug.Log("Uderzyłeś w przeszkode");
        }
       /* if(collision.collider.name=="Finish")
        {
            FindObjectOfType<EndTrigger>().OnTrigger();
        }*/
	}
	
}
