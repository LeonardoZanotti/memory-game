using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    public GameObject cardBack;
    private int id;
    public GameController gc;

    private void OnMouseDown()
    {
        if (cardBack.activeSelf && gc.getSegunda() == null)
        {
            cardBack.SetActive(false);	// ocultar a carta
            gc.revelaCarta(this);		// 'this' referencia o próprio objeto
        }
        // else
        // {
        //    cardBack.SetActive(true);	// desocultar a carta
        // }
    }

    public void changeSprite(int id, Sprite img)     // Sprite é tipo uma variável para imagens, se você for ver, tem lá o Sprete Renderer, que é pra adicionar imagem
    {
        this.id = id;
        GetComponent<SpriteRenderer>().sprite = img;
    }

    public int getID()
    {
    	return id;
    }

    public void virar()
    {
    	cardBack.SetActive(true);
    }


}
