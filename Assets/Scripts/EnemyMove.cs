using System;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    private float timer;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            direction *= -1;
            timer = 0;
        }
        rb2d.linearVelocity = direction.normalized * speed;
    }
}
