using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	public void reiniciarJogo()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);	// você pode tar colocando 0, 1 ou 2 aqui pra ser mais direto, mas isso evita uns bugs
	}   
       
	public void iniciaJogo()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 	// você pode tar colocando 0, 1 ou 2 aqui pra ser mais direto, mas isso evita uns bugs
	}

	public void sair()
	{
		Application.Quit();
	}

	public void menu()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);	// você pode tar colocando 0, 1 ou 2 aqui pra ser mais direto, mas isso evita uns bugs
	}
}
