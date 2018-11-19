using UnityEngine;

public class Movment : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 800f;
    public float sideforce = 200f;
    // Use this for initialization
    void Start () {

        //rb.AddForce(0, 200, 500);
        Debug.Log("Elko");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(0, 0, forwardforce* Time.deltaTime); //fpsy 
        if(Input.GetKey("right"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }
        if (Input.GetKeyDown("up"))
        {
            if (rb.position.y <1)
            rb.AddForce(0, 300 , 0 * Time.deltaTime);

        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<gameManage>().EndGame();
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManage>().EndGame();
        }
        if(rb.position.x<=-10)
        {
            FindObjectOfType<gameManage>().EndGame();
        }
        if (rb.position.x >= 10)
        {
            FindObjectOfType<gameManage>().EndGame();
        }
    }
}
