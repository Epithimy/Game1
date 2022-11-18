using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBehaviour : MonoBehaviour
{
    public Rigidbody2D rb2d;
    [SerializeField]private float dragAmount = 4f; 
 
    void OnTriggerEnter (Collider other) {
         if (other.gameObject.tag == "Water") {
             rb2d.drag = dragAmount;
        }
    }   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
