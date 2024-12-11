using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GhostMovement movement { get; private set; }
    public GhostHome home { get; private set; }
    public GhostScatter scatter { get; private set; }
    public GhostChase chase { get; private set; }
    public GhostFrightened frightened { get; private set; }

    public GhostBehavior initBehaviour;
    public Transform targer;
    public int points = 200;

    private void Start()
    {
        this.movement = GetComponent<GhostMovement>();
        this.home = GetComponent<GhostHome>();
        this.scatter = GetComponent<GhostScatter>();
        this.chase = GetComponent<GhostChase>();
        this.frightened = GetComponent<GhostFrightened>();
    }

    
}
