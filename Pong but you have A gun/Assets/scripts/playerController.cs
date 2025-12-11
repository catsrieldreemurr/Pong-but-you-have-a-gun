
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    InputAction move;
    InputAction p2move;
    Rigidbody2D rb;
    public int speed;
    public int plr;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move = InputSystem.actions.FindAction("move");
        p2move = InputSystem.actions.FindAction("P2Move");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input;
        if(plr == 1)
        {
            input = move.ReadValue<Vector2>();        
        }
        else
        {
            input = p2move.ReadValue<Vector2>();
        }

        if(transform.position.y > 3.5 && input.y > 0)
        {  
            rb.linearVelocity = new Vector2(0,0);
        }
        else if(transform.position.y < -3.5 && input.y < 0)
        {
            rb.linearVelocity = new Vector2(0,0);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, input.y * speed);

        }
    }
}
