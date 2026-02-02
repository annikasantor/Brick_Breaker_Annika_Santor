using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed = 3.0f;

    private Vector2 direction;
    void Start()
    {
// Ternary operator: condition ? pass : fail (what happens if you pass or fail)
        direction.x = Random.value > 0.5f ? 1 : -1;
        direction.y = Random.value > 0.5f ? 1 : -1;
    }


    void Update()
    {
        Vector3 movement = direction * Speed * Time.deltaTime;
        
        transform.Translate(movement);
    }
}
