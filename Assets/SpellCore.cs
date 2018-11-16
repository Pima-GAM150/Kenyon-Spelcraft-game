using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCore : MonoBehaviour {
    //SpellCore is a parent class to all spell core types
    //spell cores are the element, damage, and effects of a spell

    //variable space

    public float coreMpcost;//the portion of the mp cost incurred by the core, to be added to the base to get the total mp cost of the spell

    public float coreCastlag;//cast lag is the time before the caster can act again after casting the spell. this is the portion that the core contributes to

    



    //method space

	// Use this for initialization
	void Start ()
    {
		
	}//end start
	
	// Update is called once per frame
	void Update ()
    {
		
	}//end update

    public virtual void Execute(Spell thisSpell)//<spellcore>.Execute() is the call to enact the spell's effects on its target, such as blowing it up or freezing it
    //virtual method because WHAT a spell does depends on the specific spell core
    {
        //idk what to even put here, if anything
         
    }//end execute


}//end class
