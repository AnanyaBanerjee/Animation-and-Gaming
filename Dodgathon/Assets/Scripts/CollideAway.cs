using UnityEngine;

public class CollideAway : MonoBehaviour
{
    public MovePlayer movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
