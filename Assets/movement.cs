using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
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
            transform.Translate(Vector3.left * (speed * Time.deltaTime), Space.World);
        }
        if (Input.GetAxis("Horizontal") > 0){
            transform.Translate(Vector3.right * (speed * Time.deltaTime), Space.World);
        }
    }
}
