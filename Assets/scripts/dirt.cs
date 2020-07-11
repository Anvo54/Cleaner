using UnityEngine;

public class dirt : MonoBehaviour
{    // Start is called before the first frame update
    private bool onFloor = false;
    [SerializeField] float speed = 1.5f;
    // Update is called once per frame
    void Update()
    {
        if (!onFloor)
            transform.Translate(Vector3.down *(speed * Time.deltaTime), Space.World); 
    }

    public bool GetFloor()
    {
        return onFloor;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.SetScore(10);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
        if (other.gameObject.tag == "dirt" && other.gameObject.transform.position.y < -2){
            onFloor = true;
        }
    }
}
