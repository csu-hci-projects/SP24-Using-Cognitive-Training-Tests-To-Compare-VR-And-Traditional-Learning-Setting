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
        textColors = new List<Color>() { Color.blue, Color.red, Color.green, Color.yellow };
        GenerateColorMap();
        StartCoroutine(CycleColors(1.2f));
    }

    void GenerateColorMap()
    {
        Shuffle(colorNames);
        Shuffle(textColors);

        for (int i = 0; i < colorNames.Count; i++)
        {
            colorMap.Add(colorNames[i], textColors[i]);
        }
    }

    IEnumerator CycleColors(float waitTime)
    {
        List<string> allCombinations = GenerateAllCombinations(colorNames, textColors);

        while (true)
        {
            Shuffle(allCombinations);
            foreach (string combination in allCombinations)
            {
                DisplayColorName(combination);
                yield return new WaitForSeconds(waitTime);
            }
        }
    }

    void DisplayColorName(string combination)
    {
        string[] parts = combination.Split('|');
        string colorName = parts[0];
        Color textColor = colorMap[colorName];


        this.colorName.text = colorName;
        this.colorName.color = textColor;
    }

    List<string> GenerateAllCombinations(List<string> colorNames, List<Color> textColors)
    {
        List<string> combinations = new List<string>();

        foreach (string colorName in colorNames)
        {
            foreach (Color textColor in textColors)
            {
                combinations.Add(colorName + "|" + textColor);
            }
        }

        return combinations;
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