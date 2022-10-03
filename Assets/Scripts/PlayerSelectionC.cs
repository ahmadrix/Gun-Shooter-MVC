using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSelectionC : Selection
{
    public GameObject[] players;

    public int selectedPlayer = 0;

    public TMP_Text playerName;
    public string selectedPlayerName;
    // Start is called before the first frame update
    void Start()
    {
        selectedPlayerName = "selectedPlayer";
        Initialization(players);
    }

    // Update is called once per frame
    void Update()
    {
        NameText(playerName , players);
    }
    
    public void NextPlayerC()
    {
        Next(players);
    }

    public void PreviousPlayerC()
    {
        Previous(players);
    }

    public void StartGameC()
    {
        StartGame(selectedPlayerName , selected);
    }
}
