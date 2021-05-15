
using UnityEngine;

public class follow_player : MonoBehaviour
{

    public Transform player;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0, 5, distance);
    }
}
