using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOneMove : MonoBehaviour
{
    public Rigidbody Barrel;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        

        if (Barrel.transform.position.x < 5)
        {
            Barrel.AddForce(speed, 0, 0);
            print("123");
        }
        else if(Barrel.transform.position.x >= 5)
        {
            Barrel.AddForce(Vector3.zero);
            Barrel.transform.position = new Vector3(5, 0, 0);
        }
        

    }
}
