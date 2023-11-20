using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabrikaMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    bool acikMi = false;
    public bool FabrikaKuruldu_Mu;
    private static FabrikaMenu instance;
    public static FabrikaMenu Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<FabrikaMenu>(true);

            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }
    private void OnMouseDown()
    {
        if (acikMi)
        {
            GameManager.Instance.GameStateManager(GameManager.GameState.Playing);
            
            acikMi = false;
        }
        else
        {
            GameManager.Instance.GameStateManager(GameManager.GameState.Click_Menu);
            acikMi = true;
        }
    }
}
