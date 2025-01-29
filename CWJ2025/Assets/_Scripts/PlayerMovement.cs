using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5;
    public Rigidbody playerRb;
    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction.z = speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction.z = -speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction.x = speed;
        }

        playerRb.linearVelocity += direction * Time.deltaTime;
    }
}
