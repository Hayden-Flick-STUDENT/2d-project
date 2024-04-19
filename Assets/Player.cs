using UnityEngine;

// TODO: Script should require a Rigidbody2D component

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    // TODO: Reference to Rigidbody2D component should have class scope.
    public float jumpHeight = 1;
    // TODO: A float variable to control how high to jump / how much upwards
    // force to add.

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // TODO: Use GetComponent to get a reference to attached Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpHeight);
        }
        // TODO: On the frame the player presses down the space bar, add an instant upwards
        // force to the rigidbody.
    }
}