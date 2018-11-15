using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {
    //enemy is a subclass of character

    //variable space




    //method space


    public override void Die()
    {
        base.Die();
        //insert all the stuff enemies do when they die, presumably a death animation followed by them dissappearing and being deleted
    }//end enemy override die

    //to do: a method to determine if the player is in range of any known spells, then deciding to use one if so

    //to do: a method for determining and enacting enemy movement





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
