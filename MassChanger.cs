using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MassChanger : MonoBehaviour
{
private Rigidbody2D Ball;
    // Start is called before the first frame update
    void Start()
    {
	
	Ball = GetComponent<Rigidbody2D>();
        System.Random rnd = new System.Random();
	Ball.mass = rnd.Next(1,5);
    }

	void Update()
     {
         
     }
}
