using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class ImpGUI : MonoBehaviour
{
    public string labelText;
    private GUIStyle labelStyle;
    // Player 1 Stats
    private int Player_1_Attack = 300;
    private int Player_1_Defense = 100;
    private int Player_1_Speed = 50;
    private int Player_1_Luck = 30;
    private int Player_1_Intelligence = 10;
    // Player 2 Stats
    private int Player_2_Attack = 99999;
    private int Player_2_Defense = 3333;
    private int Player_2_Speed = 44444;
    private int Player_2_Luck = 555;
    private int Player_2_Intelligence = 55;
    // Player 3 Stats
    private int Player_3_Attack = 1000;
    private int Player_3_Defense = 20;
    private int Player_3_Speed = 30;
    private int Player_3_Luck = 10;
    private int Player_3_Intelligence = 10;

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
            labelText = "Name: Freddy Fazbear\n\rAttack: " + Player_1_Attack + "\n\rDefense: " + Player_1_Defense + "\n\rSpeed: " + Player_1_Speed + "\n\rLuck: 30" + Player_1_Luck + "\n\rIntelligence: " + Player_1_Intelligence;
        }

        if (GUI.Button(new Rect(220, 330, 100, 100), "Player 2 Stats"))
        {
            print("p2");
            labelText = "Name: Marcud\n\rAttack: " + Player_2_Attack + "\n\rDefense: " + Player_2_Defense + "\n\rSpeed: " + Player_2_Speed + "\n\rLuck: " + Player_2_Luck + "\n\rIntelligence: " + Player_2_Intelligence;
        }

        if (GUI.Button(new Rect(220, 480, 100, 100), "Player 3 Stats"))
        {
            print("p3");
            labelText = "Name: Taylor Swift\n\rAttack: " + Player_3_Attack + "\n\rDefense: " + Player_3_Defense + "\n\rSpeed: " + Player_3_Speed + "\n\rLuck: " + Player_3_Luck + "\n\rIntelligence: " + Player_3_Intelligence;
        }

        GUI.Label(new Rect(800, 300, 200, 200), labelText, labelStyle);
    }
}
