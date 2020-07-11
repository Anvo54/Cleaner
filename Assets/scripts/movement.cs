using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float speed = 5;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        if (Input.GetAxis("Horizontal") < 0){
            
            transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(Vector3.left * (speed * Time.deltaTime), Space.World);
        }
        if (Input.GetAxis("Horizontal") > 0){
             transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(Vector3.right * (speed * Time.deltaTime), Space.World);
        }
    }
}
