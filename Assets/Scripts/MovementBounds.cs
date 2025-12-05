using UnityEngine;

public class MovementBounds : MonoBehaviour
{
    public Vector2 minBounds; 
    public Vector2 maxBounds;

    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minBounds.x, maxBounds.x);
        pos.y = Mathf.Clamp(pos.y, minBounds.y, maxBounds.y);

        transform.position = pos;
    }
}
