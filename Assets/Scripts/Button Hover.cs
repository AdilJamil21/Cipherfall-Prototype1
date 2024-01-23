using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{
    private Image buttonImage; // Reference to the Image component

    // Start is called before the first frame update
    void Start()
    {
        // Get the Image component once at the start
        buttonImage = GetComponent<Image>();
    }

    public void OnHoverEnter()
    {
        // Change the color to black with adjusted alpha on hover enter
        if (buttonImage != null)
        {
            Color newColor = Color.black;
            newColor.a = 0.4f; // Set your desired alpha value (0.0f to 1.0f)
            buttonImage.color = newColor;
        }
    }

    public void OnHoverExit()
    {
        // Change the color to your custom color with adjusted alpha on hover exit
        if (buttonImage != null)
        {
            Color newColor = HexToColor("BE1C84");
            newColor.a = 0.0f; // Reset alpha to fully opaque
            buttonImage.color = newColor;
        }
    }

    private Color HexToColor(string hex)
    {
        Color color = Color.white;
        if (ColorUtility.TryParseHtmlString("#" + hex, out color))
        {
            return color;
        }
        else
        {
            Debug.LogWarning("Invalid hex color code: " + hex);
            return Color.white;
        }
    }
}
