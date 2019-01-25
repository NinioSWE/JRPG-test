using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour 
{
	[SerializeField] private float movementSpeed = 3.0f;
	[SerializeField] private float accelerationSpeed = 1.5f;
	[SerializeField] private float height = 4.0f;
	[SerializeField] private float fallDelay  = .4f;
	private float horizontalInput;
	private float verticalInput;
	private float jumpInput;
	private float gravity;
	private float velocity;
	
	private float left = 1;
	private float right = -1;
	private float up = 1;
	private float down = -1;
	
	Vector3 movement;

	public static PlayerMovements playerReference;

	void Start () 
	{
		//setup gravity
		gravity = -(2*height)/Mathf.Pow(fallDelay, 2);
		velocity = Mathf.Abs(gravity) * fallDelay;
		
		

		playerReference = this;
		//movement = gameObject.transform.position;
	}
	
	void playerInput()
	{
		horizontalInput = Input.GetAxisRaw("Horizontal");
		verticalInput = Input.GetAxisRaw("Vertical");
		jumpInput = Input.GetAxisRaw("Jump");
	}
	
	void move(float dirX, float dirY, float dirZ)
	{		
		transform.Translate(new Vector3(dirX * movementSpeed * Time.deltaTime, 
										dirY * velocity * Time.deltaTime * 3f, 
										dirZ * movementSpeed * Time.deltaTime * 3f));
	}
	
	void playerMovement()
	{
		float hor = 0;
		float vert = 0;	
		float zaxis = gravity * Time.deltaTime;

		movement = transform.position;
		
		if(horizontalInput == left)
		{
			hor = left;
		}
		
		if(horizontalInput == right)
		{
			hor = right;		
		}
		
		if(verticalInput == up)
		{
			vert = up;
		}
		
		if(verticalInput == down)
		{
			vert = down;	
		}
		
		if (jumpInput == 1)
		{
			zaxis += 1;
			movement.y = zaxis;
		}

		if(transform.position.y < 0)
		{
			movement.y = 0;
			transform.position = movement;

			zaxis = 0;
		}

		move(hor,zaxis, vert);
	}

	void Update () 
	{
		playerInput();
		playerMovement();
	}
}
