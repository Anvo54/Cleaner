using UnityEngine;

public class dirt : MonoBehaviour
{    // Start is called before the first frame update
    private bool onFloor = false;
    private bool cleaned = false;
    private bool setMinus = false;

    private SpriteRenderer spr;
    private Rigidbody2D tolloRB;
    private Collider2D tolloCol;
    [SerializeField] float speed = 1.5f;
    void Start()
    {
        tolloRB = GetComponent<Rigidbody2D>();
        tolloCol = GetComponent<Collider2D>();
        spr = GetComponent<SpriteRenderer>();
        speed = Random.Range(1.5f, 6);
    }
    void Update()
    {
        if (!onFloor)
            transform.Translate(Vector3.down *(speed * Time.deltaTime), Space.World); 
        if (transform.position.y < -3f && cleaned == false){
            onFloor = true;
            tolloCol.isTrigger = false;
            tolloRB.gravityScale = 5;
            spr.color = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 5));
            if (!setMinus){
                if(transform.position.x < 0)
                    gameManager.RemoveLeftScore();
                else
                    gameManager.RemoveRightScore();
                setMinus = true;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            tolloCol.isTrigger = false;
            tolloRB.gravityScale = 2;
            onFloor = true;
            cleaned = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "RightBin"){
            gameManager.SetRightScore(1);
        }
        if (other.gameObject.tag == "LeftBin"){
            gameManager.SetLeftScore(1);
        }
    }
}
