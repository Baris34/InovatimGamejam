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
    private int GezegenKapasite; // kaos�le ba�la 
    [SerializeField]
    private float timer;
    [SerializeField]
    private int UretilenHammadde;
    [SerializeField]
    private int UretimSayisi;
    
    int sayici = 0;


    public enum RawMaterialType
    {
        K�m�r,
        Bak�r,
        Demir
    }
    public enum FabrikaUretim
    {
        Hepsi,
        K�m�rBak�r,
        K�m�rDemir,
        Bak�rDemir,
        K�m�r,
        Bak�r,
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

                case FabrikaUretim.Bak�r:
                        BakirAdet += UretimSayisi * bakirCarpan;
                    
                    break;
                case FabrikaUretim.Demir:
                        DemirAdet += UretimSayisi * demirCarpan;
                    
                    break;
                case FabrikaUretim.K�m�r:
                    KomurAdet += UretimSayisi * komurCarpan;
                    break;
                case FabrikaUretim.Bak�rDemir:
                    BakirAdet += UretimSayisi * bakirCarpan;
                    DemirAdet += UretimSayisi * demirCarpan;
                    break;
                case FabrikaUretim.K�m�rBak�r:
                    KomurAdet += UretimSayisi * komurCarpan;
                    BakirAdet += UretimSayisi * bakirCarpan;
                    break;
                case FabrikaUretim.K�m�rDemir:
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
