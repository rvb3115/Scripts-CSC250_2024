using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player2Controller : MonoBehaviour
{

   private Player thePlayer;
   public TextMeshPro tm;
   
    // Start is called before the first frame update
    void Start()
    {
        this.thePlayer = new Player ("Dave");
        tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
    this.tm.transform.position = new Vector3(
      this.gameObject.transform.position.x,
      this.gameObject.transform.position.y + 5,
      this.gameObject.transform.position.z);
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
       this.thePlayer.display();
    }
}
