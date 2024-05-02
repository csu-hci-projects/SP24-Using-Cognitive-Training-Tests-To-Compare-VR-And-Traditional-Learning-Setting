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
        StartCoroutine(CycleColors(1.2f)); 
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
                yield return new WaitForSeconds(waitTime); 
            }
        }
    }

    void DisplayColorName(string colorName, Color textColor)
    {
        
        this.colorName.text = colorName; 
        this.colorName.color = textColor; 
    }

    Color GetRandomColor()
    {
        return textColors[Random.Range(0, textColors.Count)]; 
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
