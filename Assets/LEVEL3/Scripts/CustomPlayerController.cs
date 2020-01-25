using UnityEngine;
using System.Collections;

public class CustomPlayerController : MonoBehaviour
{

	//Speed of the player
	public float moveSpeed;
	private float currentMoveSpeed;
	public float diagonalMoveModifier;

	//Player animator
	private Animator playerAnim;
	//Player RigidBody
	private Rigidbody2D playerRigidBody;
	//If the player is facing to some direction
	private bool playerMoving;
	//Record the las direction of the player
	public Vector2 lastMovement;
	//If the player exist. static makes that only the one that have the script added has the bool
	private static bool playerExists;
	//If the player it's attacking
	private bool playerAttack;
	public float playerAttackTime;
	private float playerAttackTimeCounter;

	//Start point of the player
	public string startPoint;
    public bool tombolkiri, tombolkanan, tombolatas, tombolbawah;


    public bool balik;
    public int pindah;


    // Use this for initialization
    void Start()
	{

		//I get the animator in the player
		playerAnim = GetComponent<Animator>();

		playerRigidBody = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{

		playerMoving = false;

		//If the player it's not attacking he does not move
		if (!playerAttack)
		{
            //Here i make an tranlate to move the player getting the axis

            //Moving to the right and the left
            if (Input.GetKey(KeyCode.A)| (tombolkiri==true))
            {
                transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
               playerMoving = true;
            }
            if (Input.GetKey(KeyCode.D) || (tombolkanan == true))
            {
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                playerMoving = true;
            }
            if (Input.GetKey(KeyCode.W) || (tombolatas == true))
            {
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime,0f);
                playerMoving = true;
            }
            if (Input.GetKey(KeyCode.S) || (tombolbawah == true))
            {
                transform.Translate(Vector2.up * -moveSpeed * Time.deltaTime,0f);
                playerMoving = true;
            }

   //         if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
			//{
			//	//transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));

			//	playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * currentMoveSpeed);
			//	playerMoving = true;
			//	lastMovement = new Vector2(0f, Input.GetAxisRaw("Vertical"));
			//}

            //If the player it's not moving it stops
            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
                playerRigidBody.velocity = new Vector2(0f, playerRigidBody.velocity.y);

            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
				playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, 0f);

            //Takes the valor of the axis and return in absolute, so i know if it's 1 or 0
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.5f && Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.5f)
            {
                //If there's any movement will slow 'cause we're moving diagonal
                currentMoveSpeed = moveSpeed * diagonalMoveModifier;
            }
            else
            {
                currentMoveSpeed = moveSpeed;
            }
            if (pindah > 0 && !balik)
            {
                balikbadan();
            }
            else if (pindah < 0 && balik)
            {
                balikbadan();
            }

        }

		//Here it's where i ser the animator
        playerAnim.SetFloat("MoveX",Input.GetAxisRaw("Horizontal"));
        playerAnim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
		playerAnim.SetBool("PlayerMoving", playerMoving);
		playerAnim.SetFloat("LastMoveX", lastMovement.x);
		playerAnim.SetFloat("LastMoveY", lastMovement.y);

        
	}
    void balikbadan()
    {
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }

    public void tekankiri()
    {
        tombolkiri = true;
    }
    public void lepaskiri()
    {
        tombolkiri = false;
    }
    public void tekankanan()
    {
        tombolkanan = true;
    }
    public void lepaskanan()
    {
        tombolkanan = false;
    }
    public void tekanatas()
    {
        tombolatas = true;
    }
    public void lepasatas()
    {
        tombolatas = false;
    }
    public void tekanbawah()
    {
        tombolbawah = true;
    }
    public void lepasbawah()
    {
        tombolbawah = false;
    }
}
