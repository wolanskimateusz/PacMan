using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.position;
        transform.position = pos + new Vector3(0,0,-10);

    }
}
