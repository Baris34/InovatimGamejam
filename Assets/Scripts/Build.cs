using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        
        if (gameObject.tag=="MadenTutucu")
        {
            GameManager.Instance.GameStateManager(GameManager.GameState.Playing);
        Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
        children[1].gameObject.SetActive(true);
            children[2].gameObject.SetActive(false);
            
        }
        if (gameObject.tag == "Deniz")
        {
            
            Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
            children[1].gameObject.SetActive(true);
            
        }
        if (gameObject.tag == "Kum")
        {
            Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
            children[1].gameObject.SetActive(true);
        }
        if (gameObject.tag == "Rüzgar")
        {
            Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
            children[1].gameObject.SetActive(true);
        }
    }




}
