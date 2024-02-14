using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Player1;
    public GameObject destination;
    public float speed;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Player1.transform.position = Vector3.MoveTowards(Player1.transform.position, destination.transform.position, speed); 
    }
}
