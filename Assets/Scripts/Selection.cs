
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selection : MonoBehaviour
{
    //private GameObject[] pass;
    //private int selectedInt = 0;
    public int selected = 0;

    //public int testing = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Initialization(GameObject[] pass)
    {
        for (int i = 1; i < 5; i++)
        {
            pass[i].SetActive(false);
        }
        
        pass[0].SetActive(true);
    }

    

    public void Next(GameObject[] pass )
    {
        
        pass[selected].SetActive(false);      //it set active false the selected gun/player
        selected = (selected + 1) % pass.Length; //if the index is greater then array size, it would get to the first index of array.
        pass[selected].SetActive(true);       //shows the next selected gun/player
        Debug.Log(selected);

    }
    
    public void Previous(GameObject[] pass)
    {
        pass[selected].SetActive(false);      //it set active false the current gun selected
        selected--;
        if (selected < 0)  //if the index is below zero, it would get to the last index of array.
        {
            selected += pass.Length;
        }
        pass[selected].SetActive(true);     //shows the previous selected gun
    }

    public void NameText(TMP_Text name , GameObject[] pass)
    {
        name.text = pass[selected].name;
    }
    
    public void StartGame(string selectedIntName , int selectedInt)
    {
        PlayerPrefs.SetInt(selectedIntName , selectedInt);    //pass the int value to the other scene
        SceneManager.LoadScene(1, LoadSceneMode.Single);         //load the game scene
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}


