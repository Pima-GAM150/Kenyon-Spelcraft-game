using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBase : MonoBehaviour {
    //SpellBase is the parent class of all spell bases
    //spell bases are the basic shape and function of a spell, such as a projectile, an area of effect, a cone in front, and more
    //spell bases combine with spell cores to form a complete spell


    //variable space

    public float baseMpcost;
    public float baseCastlag;
    

    //method space

	// Use this for initialization
	void Start ()
    {
		
	}//end start
	
	// Update is called once per frame
	void Update ()
    {
		
	}//end update

    public virtual void Execute(Spell thisSpell)//<spellbase>.Execute() calls the behaviour of the spell base, such as creating a projectile and checking if it hits any enemies
    //virtual method because the behavior is different for every spell base
    {

    }//end base execute


}//end class
