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

    public void Enable()
    {
        Enable(this.duration);

    }
    public void Enable(float duration)
    {
        this.enabled = true;
        CancelInvoke();
        Invoke(nameof(Disable),duration);
    }
    public void Disable()
    {
        this.enabled = false;
        CancelInvoke();
    }
}
