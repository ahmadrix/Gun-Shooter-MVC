using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPlayer : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    public GameObject[] gunPrefabs;
    public GameObject newPlayerObject;
    public Camera fpsCamera;
    
    public Transform spawnPoint;
    public TMP_Text label_player;
    public TMP_Text label_gun;
    
    // Start is called before the first frame update
    void Start()
    {
        int selectedPlayer = PlayerPrefs.GetInt("selectedPlayer");   //get the pass value of int from selection scene
        
        GameObject prefab = playerPrefabs[selectedPlayer];         //store the Prefab array gameObject (from the selectedPlayer index) to a new gameobject 
        //(make the player a parent of camera)
        newPlayerObject = Instantiate(prefab, spawnPoint.position, Quaternion.identity);      //Instantiating the prefab gameobject
        newPlayerObject.SetActive(true);
        label_player.text = prefab.name;      //printing the name of the instantiated prefab

        
        int selectedGun = PlayerPrefs.GetInt("selectedGun");
        
        GameObject gunPrefab = gunPrefabs[selectedGun];

        GameObject newGunObject;
        newGunObject = Instantiate(gunPrefab, spawnPoint.position = new Vector3(0.5f,1,0.8f), gunPrefab.transform.rotation);
        newGunObject.transform.SetParent(fpsCamera.transform);    //make it a child of camera
        newGunObject.SetActive(true);
        label_gun.text = gunPrefab.name;
    }

    public void PlayerSelect()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);         //load the selection scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
