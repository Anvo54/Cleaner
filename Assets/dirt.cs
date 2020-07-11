using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirt : MonoBehaviour
{    // Start is called before the first frame update
    [SerializeField] float speed = 1.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down *(speed * Time.deltaTime), Space.World);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player");
            Destroy(gameObject);
        }
    }
}
