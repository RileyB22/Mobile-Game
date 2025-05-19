
using UnityEngine;
/// <summary>
/// Responsible for moving the player automatically and receiving input.
/// </summary>

public class PlayerBehaviour : MonoBehaviour
{
    /// <summary>
    /// A reference to the Rigidbody component
    /// </summary>
    // A reference to the Rigidbody component
    private Rigidbody rb;
    [Tooltip("How fast the ball moves left/right")]
    // How fast the ball moves left/right
    public float dodgeSpeed = 5;
    [Tooltip("How fast the ball moves forward  automatically")]
    [Range(0, 10)]
    // How fast the ball moves forward  automatically
    public float rollSpeed = 5;

    // Start is called before the first frame update
    void Start()

    {
        // Get access to our Rigidbody component
        rb = GetComponent<Rigidbody>();
      
    }
    void Update()
    {
        // Check if we're moving to the side       
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }
}
