using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorNames : MonoBehaviour
{
    public TextMeshProUGUI colorName; 

    private Dictionary<string, Color> colorMap;
    private List<string> colorNames;
    private List<Color> textColors;

    void Start()
    {
        colorMap = new Dictionary<string, Color>();
        colorNames = new List<string>() { "Yellow", "Blue", "Green", "Red" };
        textColors = new List<Color>() { Color.red, Color.yellow, Color.green, Color.blue };
        StartCoroutine(CycleColors(0.8f)); // Display color combinations every 0.8 seconds
    }

    IEnumerator CycleColors(float waitTime)
    {
        while (true)
        {
            Shuffle(colorNames);

            foreach (string colorName in colorNames)
            {
                Color textColor = GetRandomColor();
                DisplayColorName(colorName, textColor);
                yield return new WaitForSeconds(waitTime); // Wait for the specified time between each combination
            }
        }
    }

    void DisplayColorName(string colorName, Color textColor)
    {
        // Assuming colorName is your TextMeshProUGUI component
        this.colorName.text = colorName; // Assign the color name string
        this.colorName.color = textColor; // Assign the color
    }

    Color GetRandomColor()
    {
        return textColors[Random.Range(0, textColors.Count)]; // Randomly select a color from the list
    }

    void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
