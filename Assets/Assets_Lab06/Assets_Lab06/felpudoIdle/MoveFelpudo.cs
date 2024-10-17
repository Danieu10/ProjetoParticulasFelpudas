using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFelpudo : MonoBehaviour
{
	public Vector3 moveSpeed;
	public float speedmodifier = 0.2f;
	public float spawnDelay = 2f;

	// Use this for initialization
	void Start()
	{
		moveSpeed = Vector3.right * Time.deltaTime* speedmodifier;
		
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "final")
        {
			
            speedmodifier = 0;
			moveSpeed = Vector3.right * Time.deltaTime * speedmodifier;
        }
    }

    // Update is called once per frame
    void Update()
	{
		transform.position += moveSpeed;
	}
}