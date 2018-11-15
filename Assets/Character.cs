using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    //character is a parent class of "enemy" and "player"

    //variables space
    public float maxHp;
    public float hp;
    public float speed;


    public List<Spell> knownSpells = new List<Spell>();


    //method space

    public void takeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0f) // < if your hp is zero or lower that means you are dead. funny how that works
        {
            hp = 0f;//no negative hp for potential UI reasons
            Die();//oh shit
        }//end if
         
        
    }//end take damage

    public virtual void Die()//this method does what it says on the tin
    //virtual because enemies and the player will do different things upon death. the capacity to die is universal. the reaper is equal opportunity
    {
        //insert debug message announcing that this entity has died
    }//end die

	// Use this for initialization
	void Start ()
    {
		
	}//end start
	
	// Update is called once per frame
	void Update ()
    {
		
	}//end update
}
