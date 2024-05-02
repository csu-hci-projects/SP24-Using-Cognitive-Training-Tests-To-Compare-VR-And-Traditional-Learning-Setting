using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorNames : MonoBehaviour
{
    public TextMeshProUGUI colorName; 

    private Dictionary<string, Color> colorMap;
    private List<string> colorKeys;
    private int currentIndex = 0;

    void Start()
    {
        colorMap = new Dictionary<string, Color>(){
            { "Red", Color.blue },    // "Red" text will be displayed in blue color
            { "Blue", Color.red },    // "Blue" text will be displayed in red color
            { "Green", Color.yellow }, // "Green" text will be displayed in magenta color
            { "Yellow", Color.blue },  // "Yellow" text will be displayed in green color
            { "Red", Color.red },      // "Orange" text will be displayed in red color
            { "Blue", Color.green },
            { "Red", Color.red },    
            { "Yellow", Color.green },
            { "Green", Color.yellow},
            { "Red", Color.green },
            { "Blue", Color.red },
            { "Yellow", Color.blue },
            { "Green", Color.yellow },
            { "Red", Color.blue },
            { "Blue", Color.yellow },
            { "Yellow", Color.red },
            { "Green", Color.green },
            { "Red", Color.yellow },
            { "Blue", Color.green },
            { "Yellow", Color.blue },
            { "Green", Color.red },
            { "Red", Color.red },
            { "Blue", Color.blue },
            { "Yellow", Color.yellow },
            { "Green", Color.green },
            { "Red", Color.blue },
            { "Blue", Color.yellow },
            { "Yellow", Color.red },
            { "Green", Color.green },
            { "Red", Color.yellow },
            { "Blue", Color.green },
            { "Yellow", Color.blue },
            { "Green", Color.red },
            { "Red", Color.red },
            { "Blue", Color.blue },
            { "Yellow", Color.yellow },
            { "Green", Color.green },
            { "Red", Color.green },
            { "Blue", Color.red },
            { "Yellow", Color.blue },
            { "Green", Color.yellow },
            { "Red", Color.blue },
            { "Blue", Color.yellow },
            { "Yellow", Color.red },
            { "Green", Color.green }
        };

        colorKeys = new List<string>(colorMap.Keys); // Store the keys in a list for easy access
        StartCoroutine(CycleColors());
    }

    IEnumerator CycleColors()
    {
        while (true)
        {
            DisplayColorName(colorKeys[currentIndex]);
            currentIndex = (currentIndex + 1) % colorKeys.Count; // Loop back to the start after reaching the end
            yield return new WaitForSeconds(3); // Wait for 3 seconds
        }
    }

    void DisplayColorName(string colorNameString)
    {
        if (colorMap.TryGetValue(colorNameString, out Color textColor))
        {
            colorName.text = colorNameString;
            colorName.color = textColor;
        }
        else
        {
            colorName.text = "Unknown Color";
            colorName.color = Color.black; // Default to black if the color is not found
        }
    }
}
