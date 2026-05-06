using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int life;

    private void ChangeLife(int value)
    {
        life += value;
        if(life<=0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ChangeLife(-1);
        }
    }
}
