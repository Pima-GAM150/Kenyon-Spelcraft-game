using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {
    //each spell object contains a SpellBase and SpellCore component



    //variable space

    public string spellName;//spells can be named during the creation process

    public float mpCost;//mp cost of the spell
    public float castLag;//time after casting before the caster can act again


    public SpellBase thisBase;
    public SpellCore thisCore;
    

    //method space

    //to do: im pretty sure im gonna need a constructor but im rusty on how to do that



	// Use this for initialization
	void Start ()
    {
		
	}//end start
	
	// Update is called once per frame
	void Update ()
    {
		
	}//end update

    public void Cast(Character caster)//"ABRACA HAPPEN!"
    {
        //probably SpellBase.Execute() but im not sure lots of variables and information is having to get passed between various scripts. this is getting confusing
        //after that would SpellCore.Execute() happen here or would it happen in like, an object created by SpellBase.Execute()?
        //also probably more code stuff needs to happen

    }//end cast

}//end class
