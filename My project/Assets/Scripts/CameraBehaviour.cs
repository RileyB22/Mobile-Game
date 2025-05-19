
using UnityEngine;
/// <summary>
/// Will adjust the camera to follow and face a target
/// </summary>

public class CameraBehaviour : MonoBehaviour
{
    [Tooltip("What object should the camera be looking at")]
    public Transform target;
    [Tooltip("offset camera to be target")]
    public Vector3 offset = new Vector3(0, 3, -6);

    /// <summary>
    /// update once per frame
    /// </summary>
    
    private void Update()
    {
        //check target is valid
        if (target != null)
        {
            // Set our position to an offset of our target
            transform.position = target.position + offset;
            // Change the rotation to face target
            transform.LookAt(target);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
