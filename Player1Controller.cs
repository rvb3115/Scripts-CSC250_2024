using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player1Controller : MonoBehaviour
{
   private Player thePlayer;
   public TextMeshPro tm;

    void Start()// Start is called before the first frame update
    {
    this.thePlayer = new Player("Brady");
    tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
    
    
    }
   

    private void FixedUpdate() //locked at 60fps  // Update is called once per frame
    {
       this.thePlayer.display();
       

    }
}
