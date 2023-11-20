using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    
    FabrikaMenu fabrikaKuruldu_Mu;
    private static GameManager instance;
    [SerializeField] private GameObject panel;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<GameManager>(true);

            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }
   
    public GameState currentState;
    public enum GameState
    {
        Playing,
        Click_SondajMenu,
        Click_Menu,
        Click_GüneþPanel,
        
        

    }
    private void Start()
    {
        GameStateManager(GameState.Playing);
    }

    public void GameStateManager(GameState state)
    {
                GameObject[] Deniz = GameObject.FindGameObjectsWithTag("Deniz");
                GameObject[] Kum = GameObject.FindGameObjectsWithTag("Kum");
                GameObject[] Rüzgar = GameObject.FindGameObjectsWithTag("Rüzgar");
                GameObject[] Maden = GameObject.FindGameObjectsWithTag("MadenTutucu");
        currentState = state;

        switch (state)
        {
            case GameState.Playing:
                panel.SetActive(false);

                
                break;
            case GameState.Click_SondajMenu:
                panel.SetActive(false);
                foreach (var item in Deniz)
                {
                    item.gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                foreach (var item in Kum)
                {
                    item.gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                foreach (var item in Rüzgar)
                {
                    item.gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                foreach (var item in Maden)
                {
                   
                    Transform[] children = item.GetComponentsInChildren<Transform>(true);
                    
                    children[2].gameObject.GetComponent<Animator>().enabled = true;
                }
                break;
            case GameState.Click_Menu:
                panel.SetActive(true);
                if (FabrikaMenu.Instance.FabrikaKuruldu_Mu)
                {
                    UIManager.Instance.ActiveSondaButon();
                    UIManager.Instance.DeactiveFabrikaButon();
                }
                break;
            case GameState.Click_GüneþPanel:
                panel.SetActive(false);
                
                foreach (var item in Deniz)
                {
                    item.gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                foreach (var item in Kum)
                {
                    item.gameObject.GetComponent<Animator>().enabled = true;
                }
                foreach (var item in Rüzgar)
                {
                    item.gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                foreach (var item in Maden)
                {
                    item.gameObject.GetComponent<BoxCollider>().enabled = false;
                   
                }
                break;
        }
    }

    


}
