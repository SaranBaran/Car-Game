        using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 20f;
    public float sidewayForce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewayForce ,0 ,0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewayForce ,0 ,0, ForceMode.VelocityChange);
        }

        if (transform.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
