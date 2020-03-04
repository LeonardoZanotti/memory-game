using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreTexto, tentativasTexto;
    
    void Start() 
    {
    	scoreTexto.text = "Score: " + PlayerPrefs.GetInt("score");
    	tentativasTexto.text = "Tentativas: " + PlayerPrefs.GetInt("tentativas");
    } 	
}
