using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float Speed = 5.0f;

    public KeyCode LeftDirection = KeyCode.A;
    public KeyCode RightDirection = KeyCode.D;
    
    void Update()
    {

        float movement = 0.0f;
            
        if (Input.GetKey(LeftDirection))
        {
            movement -= Speed;
        }
        
        // can also be written like if (Input.GetKey(UpDirection)) movement += Speed;
        //this only works if there's only one line in the if statement
        
        if (Input.GetKey(RightDirection))
        {
            movement += Speed;
        }
        
        //transform.position += new Vector3(0.0f, movement, 0.0f) * Time.deltaTime; same as the line below

        transform.Translate(new Vector3(movement, 0.0f, 0.0f) * Time.deltaTime);
    }
}
