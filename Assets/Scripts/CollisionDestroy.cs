using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        Object.Destroy(collision.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
