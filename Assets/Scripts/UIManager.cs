using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    
    [SerializeField] private GameObject fabrika;
    [SerializeField] private TextMeshProUGUI SilikonText;
    [SerializeField] private TextMeshProUGUI DemirText;
    [SerializeField] private TextMeshProUGUI EnerjiText;
    [SerializeField] private GameObject SondaButon;
    [SerializeField] private GameObject FabrikaButon;
    private static UIManager instance;
    bool acik_mi=false;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<UIManager>(true);

            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }

    public void FabrikaKur()
    {
        fabrika.SetActive(true);
        FabrikaMenu.Instance.FabrikaKuruldu_Mu = true;
    }

    public void ClickMenu()
    {
        
        if (acik_mi)
        {  
            GameManager.Instance.GameStateManager(GameManager.GameState.Playing);
            acik_mi = false;
        }
        else
        {
        GameManager.Instance.GameStateManager(GameManager.GameState.Click_Menu);
            acik_mi = true;
        }
        
    }
    public void SondajMenu()
    {
        GameManager.Instance.GameStateManager(GameManager.GameState.Click_SondajMenu);
        
    }
    public void GüneþPaneliMenu()
    {
        GameManager.Instance.GameStateManager(GameManager.GameState.Click_GüneþPanel);
    }
    public void setSilikonText(int adet)
    {
        this.SilikonText.text = adet.ToString();
    }
    public void setEnerjiText(int adet)
    {
        this.EnerjiText.text = adet.ToString();
    }
    public void setDemirText(int adet)
    {
        this.DemirText.text = adet.ToString();
    }
    public void ActiveSondaButon()
    {
        SondaButon.SetActive(true);
    }
    public void DeactiveFabrikaButon()
    {
        FabrikaButon.SetActive(false);
    }
}
