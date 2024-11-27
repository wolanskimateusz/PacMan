using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 8.0f;
    public Vector2 initialDiretion;
    public Vector2 direction;
    public Vector2 nextDirection;
    public LayerMask walls;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W)){
            this.SetDirection(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            this.SetDirection(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            this.SetDirection(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.D)){
            this.SetDirection(Vector2.right);
        }


        if (this.nextDirection != Vector2.zero)
        {
            SetDirection(this.nextDirection);
        }
    }
    void FixedUpdate()
    {
        Vector2 position = this.rb.position;
        this.rb.MovePosition(position + this.direction * this.speed * Time.fixedDeltaTime);
    }

    public void SetDirection(Vector2 direction)
    {
        if (!Occupied(direction))
        {
            this.direction = direction;
            this.nextDirection = Vector2.zero;
        }
        else
        {
            this.nextDirection = direction;
        }
    }

    public bool Occupied(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast(this.transform.position,Vector2.one * 0.75f,0.0f,direction, 1.5f, this.walls);
        return hit.collider !=null;
    }

    
}
