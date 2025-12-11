
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    InputAction move;
    Rigidbody2D rb;
    public int speed;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move = InputSystem.actions.FindAction("move");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = move.ReadValue<Vector2>();
        rb.linearVelocity = new Vector2(0, input.y * speed);

        if(transform.position.y > 3.5)
        {
            Debug.Log("what the fuck dude");
        }
    }
}
