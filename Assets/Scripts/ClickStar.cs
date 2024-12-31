using UnityEngine;

public class ClickStar : MonoBehaviour
{
    // As It's Name Suggests, This Script Will Let You CLick The Star
    void Update()
    {
        {
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Convert mouse position to world space
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // Cast a ray at the mouse position

            if (hit.collider != null && hit.collider.CompareTag("Selectable"))
            {
                Debug.Log("Object Selected: " + hit.collider.name);
                SelectObject(hit.collider.gameObject);
            }
        }
    }

    void SelectObject(GameObject selectedObject)
    {
        // Change color or perform other actions upon selection
        SpriteRenderer renderer = selectedObject.GetComponent<SpriteRenderer>();
        if (renderer != null)
        {
            
        }
    }
    }
}