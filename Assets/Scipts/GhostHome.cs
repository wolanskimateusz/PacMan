using UnityEngine;

[RequireComponent(typeof(Ghost))]
public class GhostHome : MonoBehaviour
{
    public Ghost ghost {get; private set;}
    public float duration;

    private void Start()
    {
        this.ghost = GetComponent<Ghost>();
        this.enabled = false;
    }
}
