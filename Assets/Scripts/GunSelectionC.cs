using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GunSelectionC : Selection
{
    public GameObject[] guns;
   // public int selectedGun = 0;
    
    public TMP_Text gunName;

    public string selectedGunName;
    // Start is called before the first frame update
    void Start()
    {
        selectedGunName = "selectedGun";
        Initialization(guns);
    }

    // Update is called once per frame
    void Update()
    {
        NameText(gunName , guns);
    }

    public void NextGunC()
    {
        Next(guns);
    }

    public void PreviousGunC()
    {
        Previous(guns);
    }

    public void StartGameC()
    {
        StartGame(selectedGunName , selected);
    }
    
}
