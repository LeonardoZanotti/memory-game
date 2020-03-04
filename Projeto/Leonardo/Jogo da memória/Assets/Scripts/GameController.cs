using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject original;
    public Sprite[] imgs;
    public Carta primeira, segunda;
    public TextMeshProUGUI scoreTexto, tentativasTexto;
    public int score, tentativas;
    // Start is called before the first frame update
    void Start()
    {
        int[] ids = {0, 0, 1, 1, 2, 2, 3, 3};
        ids = ShuffleArray(ids);
        original.GetComponent<Carta>().changeSprite(ids[0], imgs[ids[0]]);
        for (int i = 1; i < 4; i++)
        {
            GameObject novaCarta = Instantiate(original);
            novaCarta.GetComponent<Carta>().changeSprite(ids[i], imgs[ids[i]]);
            novaCarta.transform.position = new Vector3(original.transform.position.x+(i*4), original.transform.position.y, original.transform.position.z);
        }
        for (int i = 0; i < 4; i++)
        {
            GameObject novaCarta = Instantiate(original);
            novaCarta.GetComponent<Carta>().changeSprite(ids[i+4], imgs[ids[i+4]]);
            novaCarta.transform.position = new Vector3(original.transform.position.x+(i*4), original.transform.position.y+6, original.transform.position.z);
        }
    }

    private int[] ShuffleArray(int[] ids)
    {
        int[] shuffled = ids;
        for (int i = 0; i < shuffled.Length; i++)
        {
            int tmp = shuffled[i];
            int r = Random.Range(i, shuffled.Length);
            shuffled[i] = shuffled[r];
            shuffled[r] = tmp;            
        }
        return shuffled;
    }

    public void revelaCarta(Carta carta)
    {
        if(primeira == null)
        {
            primeira = carta;
        }
        else
        {
            segunda = carta;
            tentativas++;
            tentativasTexto.text = "Tentativas: " + tentativas;
            StartCoroutine(verificaPar());
        }
    }

    public IEnumerator verificaPar()
    {
        if(primeira.getID() == segunda.getID())
        {
            score++;
            scoreTexto.text = "Score: " + score;
            yield return new WaitForSeconds(1f);
            
            if(score == 4)
            {
                PlayerPrefs.SetInt("tentativas", tentativas);   // Cria a string "tentativas" com valor tentativas
                PlayerPrefs.SetInt("score", score);         // Cria a string "score" com valor score
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);      // Carregar a cena 1 (Game Over)
            }
        }
        else
        {
            yield return new WaitForSeconds(2f);
            primeira.virar();
            segunda.virar();
        }
        primeira = null;
        segunda = null;
    }

    public Carta getSegunda()
    {
        return segunda;     // isso aqui é tipo, se você clicar dnv msm com a carta ainda virada, vai retornar a carta que ta virada mesmo pra tu n ser zuao
    }
}
