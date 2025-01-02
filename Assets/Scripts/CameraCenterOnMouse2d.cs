using UnityEngine;

public class CameraCenterOnMouse2d : MonoBehaviour
{
    // The camera's smoothing speed
    public float smoothingSpeed = 5f;

    // To keep track of the target position
    private Vector3 targetPosition;

    private Camera cameraComponent;

    void Start()
    {
        // Get the main camera component
        cameraComponent = Camera.main;
        
        // Initialize the target position to the camera's starting position
        targetPosition = transform.position;
    }

    void Update()
    {
        // If the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in world space (2D)
            Vector2 mousePosition = cameraComponent.ScreenToWorldPoint(Input.mousePosition);

            // Set the target position to the mouse position but preserve the Z-axis
            targetPosition = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }

        // Smoothly move the camera towards the target position (in 2D: only X and Y are modified)
        if (targetPosition != transform.position)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothingSpeed * Time.deltaTime);
        }
    }
}
