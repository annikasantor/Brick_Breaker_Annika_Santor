using UnityEngine;

public class KeepInBounds : MonoBehaviour
{
    public float minX = -11.6f;
    public float maxX = 11.6f;
    public float minY = -5.5f;
    public float maxY = 5.5f;
    

    void LateUpdate()
    {
        Vector3 currentPosition = transform.position;
        
        currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
        currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        
        transform.position = currentPosition;
    }
}
