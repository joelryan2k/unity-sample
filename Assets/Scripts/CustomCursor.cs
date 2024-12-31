// using UnityEngine;

// public class CustomCursor : MonoBehaviour
// {
//     public Texture2D customCursorTexture;  // Reference to your custom cursor texture
//     public Vector2 hotSpot = Vector2.zero; // Hotspot is the point that will click (usually the top-left corner)

//     void Start()
//     {
//         // Set the custom cursor when the game starts
//         Cursor.SetCursor(customCursorTexture, hotSpot, CursorMode.Auto);
//     }

//     // Optionally, you can also change the cursor when the mouse enters or exits a specific area
//     void OnApplicationFocus(bool hasFocus)
//     {
//         if (!hasFocus)
//         {
//             Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); // Set to default if the application loses focus
//         }
//     }
// }
