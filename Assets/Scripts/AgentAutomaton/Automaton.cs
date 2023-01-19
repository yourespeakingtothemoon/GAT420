using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Automaton : Agent
{
    //Named Automaton after the name for a machine that can perform a task without human intervention
    //This is a class that will be used to create a machine that can perform a task without human intervention
    //This class will be used to create a machine that can perform a task without human intervention
    //This class will be used to create a machine that can perform a task without human intervention
    //This class will be used to create a machine that can perform a task without human intervention
    //Most of these comments were brought to you by Github CoPilot
    //Github CoPilot in a way is a type of automaton
    //Github CoPilot is a type of automaton
    //Github CoPilot is a type of automaton
    //Github CoPilot is a type of automaton

    public float wanderDistance = 1;
	public float wanderRadius = 3;
	public float wanderDisplacement = 5;

	public float wanderAngle { get; set; }


	// Update is called once per frame
	void Update()
    {
        var gameObjects = perception.GetGameObjects();
        foreach (var gameObject in gameObjects)
        {
            Debug.DrawLine(transform.position, gameObject.transform.position);
        }
        if (gameObjects.Length>0)
    {
			movement.ApplyForce(Steering.Seek(this, gameObjects[0]));
		}
		if (movement.acceleration.sqrMagnitude <= movement.maxForce * 0.1f)
		{
			movement.ApplyForce(Steering.Wander(this));
		}
		transform.position = Utilities.Wrap(transform.position, new Vector3(-10, -10, -10), new Vector3(10, 10, 10));
    }

  
    
}
