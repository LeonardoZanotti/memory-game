using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    private int i = 0;                      // Apenas aqui você pode alterar
    public int j = 0;                       // Dá pra alterar direto no Unity
    [SerializeField] private int n = 0;     // Também dá pra alterar no Unity
    int count;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá, Mundo");
        Debug.Log(4);
        Debug.Log(j);
        Debug.Log(i);
        Debug.Log(n);
    }

    // Update is called once per frame
    void Update()   // Chamado o número de vezes que tá no FPS, 60 fps = 60 updates
    {
        i = i++;
        j = j++;
        Debug.Log("Olá update" + count++);
        // Debug.Log(j);
        // Debug.Log(i);
    }
}
