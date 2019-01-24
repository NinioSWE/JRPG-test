using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	[SerializeField] private float movementSpeed = 3.0f;
	private float horizontalInput;
	private float verticalInput;
	
	private int left = -1;
	private int right = 1;
	private int up = 1;
	private int down = -1;
    private Animator mAnimator;
    private int lastDir = 0;
	
	Vector3 movement;

	void Start () 
	{
        mAnimator = GetComponent<Animator>();
	}
	
	void playerInput()
	{
		horizontalInput = Input.GetAxisRaw("Horizontal");
		verticalInput = Input.GetAxisRaw("Vertical");	
	}
	
	void move(float dirX, float dirY, float dirZ)
	{
		transform.Translate(new Vector3(dirX * movementSpeed * Time.deltaTime, dirY * movementSpeed * Time.deltaTime, dirZ * movementSpeed * Time.deltaTime));
	}
	
	void playerMovement()
	{
		float hor = 0;
		float vert = 0;	
		float zaxis = 0;
		
		if(horizontalInput == left)
		{
			hor = left;
            mAnimator.SetInteger("MoveDirection", 4);
            mAnimator.SetInteger("IdleDirection", 0);
            lastDir = 4;

        }
		
		else if(horizontalInput == right)
		{
            mAnimator.SetInteger("MoveDirection", 2);
            mAnimator.SetInteger("IdleDirection", 0);
            hor = right;
            lastDir = 2;
        }
		
		else if(verticalInput == up)
		{
            mAnimator.SetInteger("MoveDirection", 1);
            mAnimator.SetInteger("IdleDirection", 0);
            vert = up;
            lastDir = 1;
        }
		
		else if(verticalInput == down)
		{
            mAnimator.SetInteger("MoveDirection", 3);
            mAnimator.SetInteger("IdleDirection", 0);
            vert = down;
            lastDir = 3;
        }

        //Debug.Log(verticalInput + " " + horizontalInput);
        else if (verticalInput == 0 && horizontalInput == 0)
        {
            mAnimator.SetInteger("IdleDirection", lastDir);
            mAnimator.SetInteger("MoveDirection", 0);
        }
		
		move(hor, vert, zaxis);
		
	}

	void Update () 
	{
		playerInput();
		playerMovement();
	}
}
