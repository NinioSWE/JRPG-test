using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	[SerializeField] private float movementSpeed = 3.0f;
	private float horizontalInput;
	private float verticalInput;
	
	private float left = 1;
	private float right = -1;
	private float up = 1;
	private float down = -1;
	
	Vector3 movement;

	void Start () 
	{
		
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
		
		move(hor, vert, zaxis);
		
	}

	void Update () 
	{
		playerInput();
		playerMovement();
	}
}
