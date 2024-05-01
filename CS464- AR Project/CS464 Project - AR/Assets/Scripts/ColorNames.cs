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
            { "Red", Color.green },
            { "Blue", Color.yellow },
            { "Green", Color.red },
            { "Yellow", Color.blue },
            { "Green", Color.green },
            { "Blue", Color.red },
            { "Red", Color.yellow },
            { "Yellow", Color.blue },
            { "Green", Color.yellow },
            { "Red", Color.blue },
            { "Blue", Color.green },
            { "Yellow", Color.red },
            { "Green", Color.green },
            { "Red", Color.red },
            { "Blue", Color.blue },
            { "Yellow", Color.yellow },
            { "Green", Color.red },
            { "Red", Color.blue },
            { "Blue", Color.yellow },
            { "Yellow", Color.green },
            { "Green", Color.yellow },
            { "Red", Color.green },
            { "Blue", Color.blue },
            { "Yellow", Color.red },
            { "Green", Color.green },
            { "Red", Color.yellow },
            { "Blue", Color.green },
            { "Red", Color.red },
            { "Yellow", Color.blue },
            { "Green", Color.red },
            { "Blue", Color.yellow },
            { "Red", Color.blue },
            { "Yellow", Color.green },
            { "Green", Color.yellow },
            { "Red", Color.green },
            { "Blue", Color.red },
            { "Yellow", Color.blue },
            { "Green", Color.green },
            { "Red", Color.yellow },
            { "Blue", Color.blue },
            { "Yellow", Color.red },
            { "Green", Color.green },
            { "Red", Color.blue },
            { "Blue", Color.yellow },
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
