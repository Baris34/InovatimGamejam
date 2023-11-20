using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICodeScene_PlanetManager : MonoBehaviour
{
    public bool acikMi=false;

    private RawMaterialType Hammadde;
    public FabrikaUretim uretimState;
    
    public static int SilikonAdet;
    public static int DemirAdet;
    public static int EnerjiSayi;
    [SerializeField]
    private int GezegenKapasite; // kaosüle baðla 
    [SerializeField]
    private float timer;
    [SerializeField]
    private int UretimSayisi;
    
    int sayici = 0;


    public enum RawMaterialType
    {
        Kömür,
        Bakýr,
        Demir
    }
    public enum FabrikaUretim
    {
        Hepsi,
        SilikonDemir,
        Silikon,
        Demir,
        Enerji
    }

    void Start()
    {

    }


    private void FixedUpdate()
    {
        
        ProductMetod();
    }
    
    public void ProductMetod()
    {

        int silikonCarpan = (int)(Random.Range(1, 3));
        int demirCarpan = (int)(Random.Range(1, 3));
        int enerjiCarpan = (int)(Random.Range(1, 3));
        if (!acikMi)
        {
            return;
        }
            
            sayici++;

        if (sayici==timer)
        {
            sayici = 0;
            switch (uretimState)
            {

                case FabrikaUretim.Silikon:
                    SilikonAdet += UretimSayisi * silikonCarpan;
                    UIManager.Instance.setSilikonText(SilikonAdet );
                    break;
                case FabrikaUretim.Demir:
                    DemirAdet += UretimSayisi * demirCarpan;
                    UIManager.Instance.setDemirText(DemirAdet );
                    break;
                case FabrikaUretim.SilikonDemir:
                    SilikonAdet += UretimSayisi * silikonCarpan;
                    DemirAdet += UretimSayisi * demirCarpan;
                    UIManager.Instance.setSilikonText(SilikonAdet );
                    UIManager.Instance.setDemirText(DemirAdet );
                    break;
                case FabrikaUretim.Enerji:
                    EnerjiSayi += UretimSayisi*enerjiCarpan ;
                    UIManager.Instance.setEnerjiText(EnerjiSayi);
                    break;
                default:
                    break;
            }
        }
        



    }
    
}
