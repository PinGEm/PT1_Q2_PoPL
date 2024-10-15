using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class ImpGUI : MonoBehaviour
{
    public string labelText;
    private GUIStyle labelStyle;

    private void Start()
    {
        // Font Size & Color
        labelStyle = new GUIStyle();
        labelStyle.fontSize = 20;
        labelStyle.normal.textColor = Color.white;
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(150, 65, 1200, 600), "Player Stats");

        if (GUI.Button(new Rect(220, 180, 100, 100), "Player 1 Stats"))
        {
            print("p1");
            labelText = "Name: Freddy Fazbear\n\rAttack: 300\n\rDefense: 100\n\rSpeed: 50\n\rLuck: 30\n\rIntelligence: 10";
        }

        if (GUI.Button(new Rect(220, 330, 100, 100), "Player 2 Stats"))
        {
            print("p2");
            labelText = "Name: Marcud\n\rAttack: 99999\n\rDefense: 3333\n\rSpeed: 44444\n\rLuck: 555\n\rIntelligence: 55";
        }

        if (GUI.Button(new Rect(220, 480, 100, 100), "Player 3 Stats"))
        {
            print("p3");
            labelText = "Name: Taylor Swift\n\rAttack: 1000\n\rDefense: 20\n\rSpeed: 30\n\rLuck: 10\n\rIntelligence: 10";
        }

        GUI.Label(new Rect(800, 300, 200, 200), labelText, labelStyle);
    }
}
