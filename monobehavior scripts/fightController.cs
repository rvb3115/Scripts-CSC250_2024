using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fightController : MonoBehaviour
{
    public GameObject hero_GO, monster_GO;
    public TextMeshPro hero_hp_TMP, monster_hp_TMP;
    private GameObject currentAttacker;
    private Animator theCurrentAnimator;

    // Start is called before the first frame update
    void Start()
    {
        this.hero_hp_TMP.text = "Current HP: " + MySingleton.thePlayer.getHP() + " AC: " + MySingleton.thePlayer.getAC(); 
        int num = Random.Range(0, 2); //coin flip, will produce 0 and 1 (since 2 is not included)
        if(num == 0)
        {
            this.currentAttacker = hero_GO;
        }
        else
        {
            this.currentAttacker = monster_GO;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.theCurrentAnimator = this.currentAttacker.GetComponent<Animator>();
        this.theCurrentAnimator.SetTrigger("attack");
        if(this.currentAttacker == this.hero_GO)
        {
            this.currentAttacker = this.monster_GO;
        }
        else
        {
            this.currentAttacker = this.hero_GO;
        }
    }
}