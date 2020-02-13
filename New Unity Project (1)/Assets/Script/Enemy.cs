using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float speed = 3.0f;
	// Start is called before the first frame update
	void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
		transform.position += transform.forward * speed * Time.deltaTime;
		if (transform.position.z<0)
		{
			speed *= -1;
		}
		if (transform.position.z >5 )
		{
			speed *= -1;
		}
		
	}
}
