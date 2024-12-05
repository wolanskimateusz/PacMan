using UnityEngine;
using System.Threading;
using System.Diagnostics;
[RequireComponent(typeof(Rigidbody2D))]
public class GhostMovement : MonoBehaviour
{

    public float speed = 8.0f;
    public Vector2 initialDiretion;
    public Vector2 direction;
    public Vector2 nextDirection;
    public LayerMask walls;
     private Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(this.nextDirection != Vector2.zero)
        {
            SetDirection(this.nextDirection);
        }
    }

    void SetDirection(Vector2 direction)
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
    void FixedUpdate()
    {
         Vector2 position = this.rb.position;
         this.rb.MovePosition(position + this.direction * this.speed * Time.fixedDeltaTime);
    }

    private bool Occupied(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast(this.transform.position,Vector2.one * 0.75f,0.0f,direction, 1.5f, this.walls);
        return hit.collider !=null;
    }
}
