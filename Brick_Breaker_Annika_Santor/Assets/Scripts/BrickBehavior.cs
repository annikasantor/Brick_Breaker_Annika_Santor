using System;
using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    private float _lives;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _lives = 2;
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Ball")
        {
            _lives--; 
            
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRenderer.color = Color.darkRed;
        }
    }

    private void Update()
    {
        if (_lives == 0)
        {
            GameBehavior.Instance.Scored();
            
            Destroy(gameObject);
        }
    }
}
