using UnityEngine;

public class dirt : MonoBehaviour
{    // Start is called before the first frame update
    [SerializeField] float speed = 1.5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down *(speed * Time.deltaTime), Space.World);  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
