using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // velocidad del jugador

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(h, v).normalized;

        transform.position += (Vector3)movement * speed * Time.deltaTime;
    }
}
