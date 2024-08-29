
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    //Veriables
    public float speed = 10f;
    public Rigidbody rb;

    float horizontalInput;
    //public float horizontalMultiplier = 1.6f;

    //Bounds Range
  // public float xRange = 4.0f;

    public bool isOnGround = true;
   // public float jumpForce;

    public bool gameOver = false;

      

    
    // // Start is called before the first frame update
    void Start()
    {
       

         rb = GetComponent<Rigidbody>();

      
    }

    
    //Fixed update allows for palyer to move forward every 5 units per seconds giving better performance and smootness
    //Constant forward movements for runner
    private void FixedUpdate ()
    {     
        
        Vector3 forwardMove =  transform.forward * speed * Time.fixedDeltaTime;

        //Side movements left/right
        float horizontalInput = Input.GetAxis("Horizontal");

        //Horizontal movement while keeping speed and forward projection
        //horizontalMulti allowing to move faster horizontaly compared to forward
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime /* horizontalMultiplier */ ;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {


    //     //Keep Player In bounds
	// if (transform.position.x < -xRange)
	// {
	// 	transform.position = new Vector3(-xRange, transform.position.x, transform.position.z);
	// }

	// if (transform.position.x > xRange)
	// {
	// 	transform.position = new Vector3(xRange, transform.position.x, transform.position.z);
	// }

    //jumping with spacebar
    // if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
    //      rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse) ;
    //     // isOnGround = false; 
    //     } 

    } //end of UpDate void

    // private void OnCollisionEnter(Collision collision) 
    // {
    //     isOnGround = true; 
    // }


    //Check if player runs into obstecle and if on ground then gives gameover message
    private void OnCollisionEnter(Collision collision)
    {
         // If player collides with the ground, they're on ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        // If player collides with obstacles, it's game over
        else if (collision.gameObject.CompareTag("Obstacle") ||
                // Obs red kills player so game over
                 collision.gameObject.CompareTag("Obs1") ||
                 //Obs2 blue orange takes half lifes
                 collision.gameObject.CompareTag("Obs2") ||
                 //obs 3 just a box can pass trough it 
                 collision.gameObject.CompareTag("Obs3"))
        {
           // gameOver = true;
            //SceneController.LoadScene(2);
          //  Debug.Log("Game Over!");
        }

    }
    

      // Handle collision stay (to prevent player passing through walls)
   private void OnCollisionStay(Collision collision)
{
    // Check if the colliding object is tagged as a wall
    if (collision.gameObject.CompareTag("Wall"))
    {
        // If player collides with a wall, prevent passing through
        if (!isOnGround) // Ensure the player is not on the ground
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                if (Vector3.Dot(contact.normal, rb.velocity) < 0)
                {
                    rb.velocity -= Vector3.Project(rb.velocity, contact.normal);
                }
            }
        }
    }
}

    

}
