using UnityEngine;

public class CameraCenterOnMouse2D : MonoBehaviour
{
    // Optional: Offset distance for the camera (e.g., if you want to offset the camera from the target position)
    public float cameraDistance = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            // Convert the mouse position to world space
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Optional: You can check for colliders here, e.g., if you want to center the camera on a specific object.
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null) {return;}

            // Move the camera to the mouse position
            Vector3 targetPosition = new Vector3(mousePosition.x, mousePosition.y, -cameraDistance); // Keeping the camera at a constant distance on the Z-axis

            // Move camera smoothly or instantly to the new position
            transform.position = targetPosition;
        }
    }
}
