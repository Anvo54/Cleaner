using UnityEngine;

public class dirt : MonoBehaviour
{    // Start is called before the first frame update
    private bool onFloor = false;
    private Rigidbody2D tolloRB;
    private Collider2D tolloCol;
    [SerializeField] float speed = 1.5f;
    void Start()
    {
        tolloRB = GetComponent<Rigidbody2D>();
        tolloCol = GetComponent<Collider2D>();
    }
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
            tolloCol.isTrigger = false;
            tolloRB.gravityScale = 1;
            tolloRB.angularDrag = 2;
        }
        if (other.gameObject.tag == "dirt" && other.gameObject.transform.position.y < -2){
            onFloor = true;
            tolloCol.isTrigger = false;
            tolloRB.gravityScale = 1;
            tolloRB.angularDrag = 2;
        }
    }
}
