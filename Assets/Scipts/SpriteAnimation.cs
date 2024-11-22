using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerAnimation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer {get; private set;}
    public Sprite[] sprites;
    public float animationTime = 0.25f;
    public int animationFrame {get; private set;}
    public bool loop = true;


    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Advance),this.animationTime,this.animationTime);
    }

    private void Advance()
    {
        this.animationFrame++;

        if(this.animationFrame >= this.sprites.Length && this.loop)
        {
            this.animationFrame = 0;
        }
        this.spriteRenderer.sprite = this.sprites[this.animationFrame];
    }
}
