using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorNames : MonoBehaviour
{
    public TextMeshProUGUI colorName;

    private Dictionary<string, Color> colorMap;
    private List<string> colorNames;
    private List<string> words;
    private int currentIndex = 0;

    void Start()
    {
        colorMap = new Dictionary<string, Color>();
        colorNames = new List<string>() { "Yellow", "Blue", "Green", "Red" };
        words = GenerateWords();

        GenerateColorMap();
        StartCoroutine(CycleColors());
    }

    List<string> GenerateWords()
    {
        List<string> generatedWords = new List<string>();

        foreach (string colorName in colorNames)
        {
            foreach (string wordColor in colorNames)
            {
                generatedWords.Add(colorName + " " + wordColor);
            }
        }

        return generatedWords;
    }

    void GenerateColorMap()
    {
        // Shuffle the list of words
        Shuffle(words);

        // Assign colors to words
        for (int i = 0; i < words.Count; i++)
        {
            string colorName = colorNames[i % colorNames.Count];
            colorMap.Add(words[i], GetColor(colorName));
        }
    }

    IEnumerator CycleColors()
    {
        while (true)
        {
            DisplayColorName(words[currentIndex]);
            currentIndex = (currentIndex + 1) % words.Count; // Loop back to the start after reaching the end
            yield return new WaitForSeconds(3); // Wait for 3 seconds
        }
    }

    void DisplayColorName(string word)
    {
        if (colorMap.TryGetValue(word, out Color textColor))
        {
            colorName.text = word;
            colorName.color = textColor;
        }
        else
        {
            colorName.text = "Unknown Color";
            colorName.color = Color.black; // Default to black if the color is not found
        }
    }

    Color GetColor(string colorName)
    {
        switch (colorName)
        {
            case "Yellow":
                return Color.yellow;
            case "Blue":
                return Color.blue;
            case "Green":
                return Color.green;
            case "Red":
                return Color.red;
            default:
                return Color.black; // Default to black if color name is not recognized
        }
    }

    // Fisher-Yates shuffle algorithm for shuffling lists
    void Shuffle(List<string> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}