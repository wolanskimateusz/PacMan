using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 movement;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")){
            movement = new Vector2(1,0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }
        if (Input.GetKey("a")){
            movement = new Vector2(-1,0);
            transform.localRotation = Quaternion.Euler(0, 0, 180);

        }
        if (Input.GetKey("w")){
            movement = new Vector2(0,1);
            transform.localRotation = Quaternion.Euler(0, 0, 90);

        }
        if (Input.GetKey("s")){
            movement = new Vector2(0,-1);
            transform.localRotation = Quaternion.Euler(0, 0, 270);

        }
        rb.MovePosition(rb.position+movement * Time.fixedDeltaTime);
    }
}
