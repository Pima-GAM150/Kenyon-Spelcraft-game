using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : SpellBase {
    //projectile is a subclass of spellbase


    //variable space


    




    //method space

    public override void Execute(Spell thisSpell, Character caster)
    {
        
        float projectileSpeed = thisSpell.basePotencyA;

        OnEnemyCollide(thisSpell);

    }//end execute


    public void OnEnemyCollide(Spell thisSpell)//change this to be called when the projectile object collides with an enemy
    {

        thisSpell.thisCore.Execute(thisSpell);
        


    }//end on enemy collide







    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
