using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public static MenuManager MenuManagerInstance;
    public bool GameState; //check the game state!
    public GameObject[] menuElement = new GameObject[2];
    void Start()
    {
        GameState = false;
        MenuManagerInstance = this;
    }
    
    void Update()
    {
        
    }

    public void StartTheGame()
    {
        GameState = true;
        menuElement[0].SetActive(false);
        GameObject.FindWithTag("particle").GetComponent<ParticleSystem>().Play();
    }
}
