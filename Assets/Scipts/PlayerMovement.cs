using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 movement;
    private SpriteRenderer sprite;
    private Rigidbody2D rb;
    public bool canMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       sprite = GetComponent<SpriteRenderer>();
       canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("d")){
            movement = new Vector3(3,0,0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }
        if (Input.GetKey("a")){
            movement = new Vector3(-3,0,0);
            transform.localRotation = Quaternion.Euler(0, 0, 180);

        }
        if (Input.GetKey("w")){
            movement = new Vector3(0,3,0);
            transform.localRotation = Quaternion.Euler(0, 0, 90);

        }
        if (Input.GetKey("s")){
            movement = new Vector3(0,-3,0);
            transform.localRotation = Quaternion.Euler(0, 0, 270);

        }
        rb.MovePosition(transform.position+movement * Time.fixedDeltaTime);
    
        
    }
}
