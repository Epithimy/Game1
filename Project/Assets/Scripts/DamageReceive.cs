using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision) {
         
         
         if (collision.gameObject.name == "DamageTest")
        {
            //If the GameObject has the same tag as specified, output this message in the console
        Vector3 theScale = transform.localScale;
		theScale.x *= 5;
		
        }
    }
}
