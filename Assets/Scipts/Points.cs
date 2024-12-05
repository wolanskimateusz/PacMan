using UnityEngine;

public class Points : MonoBehaviour
{
    public int  points = 10;

    protected virtual void Eat()
    {
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player")){
            Eat();
        }
    }
}
