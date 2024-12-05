using UnityEngine;

public class PowerPoints : Points
{
    public float duration = 8.0f;

    protected virtual void Eat()
    {
        FindObjectOfType<PlayerMovement>().speed  = 16.0f;
    }
}
