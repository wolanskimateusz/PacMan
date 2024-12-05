using UnityEngine;
using System.Threading;
using System.Diagnostics;
[RequireComponent(typeof(Rigidbody2D))]
public class GhostMovement : MonoBehaviour
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
         
        int dir = Random.Range(0, 4);
        rb.MovePosition(rb.position+movement * Time.fixedDeltaTime);
        switch (dir)
        {
            case 0: movement = new Vector2(0, 1); break;
            case 1: movement = new Vector2(0, -1); break;
            case 2: movement = new Vector2(1, 0); break;
            case 3: movement = new Vector2(-1, 0); break;
        }
        
      
        
    }
}
