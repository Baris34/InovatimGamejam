using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICodeScene_PlanetManager : MonoBehaviour
{
    public bool acikMi=false;

    private RawMaterialType Hammadde;
    public FabrikaUretim uretimState;

    public int KomurAdet;
    public int BakirAdet;
    public int DemirAdet;
    [SerializeField]
    private int GezegenKapasite; // kaosüle baðla 
    [SerializeField]
    private float timer;
    [SerializeField]
    private int UretilenHammadde;
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
        KömürBakýr,
        KömürDemir,
        BakýrDemir,
        Kömür,
        Bakýr,
        Demir
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
        int komurCarpan = (int)(Random.Range(1, 5));
        int bakirCarpan = (int)(Random.Range(1, 3));
        int demirCarpan = (int)(Random.Range(1, 3));
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

                case FabrikaUretim.Bakýr:
                        BakirAdet += UretimSayisi * bakirCarpan;
                    
                    break;
                case FabrikaUretim.Demir:
                        DemirAdet += UretimSayisi * demirCarpan;
                    
                    break;
                case FabrikaUretim.Kömür:
                    KomurAdet += UretimSayisi * komurCarpan;
                    break;
                case FabrikaUretim.BakýrDemir:
                    BakirAdet += UretimSayisi * bakirCarpan;
                    DemirAdet += UretimSayisi * demirCarpan;
                    break;
                case FabrikaUretim.KömürBakýr:
                    KomurAdet += UretimSayisi * komurCarpan;
                    BakirAdet += UretimSayisi * bakirCarpan;
                    break;
                case FabrikaUretim.KömürDemir:
                    KomurAdet += UretimSayisi * komurCarpan;
                    DemirAdet += UretimSayisi * demirCarpan;
                    break;
                case FabrikaUretim.Hepsi:
                    KomurAdet += UretimSayisi * komurCarpan;
                    BakirAdet += UretimSayisi * bakirCarpan;
                    DemirAdet += UretimSayisi * demirCarpan;
                    break;
                default:
                    break;
            }
        }
        



    }
    
}
