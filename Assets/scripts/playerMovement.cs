using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWayForce = 500f;


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if(Input.touchCount > 0){
            var touch = Input.touches[0];
            if(touch.position.x < Screen.width/2){
                rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }


            if(touch.position.x > Screen.width/2){
                rb.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

        }


        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(rb.position.y < -1f){

            FindObjectOfType<gameManager>().EndGame();

        }
    }
}
