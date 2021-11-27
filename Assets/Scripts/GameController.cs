using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int score = 0;
    public GameObject asteroid;
    public GameObject player;
    public GameObject restartMenu;

    private void Start()
    {
        CreatePlayer();
        PopulateAsteroids();
    }

    public static void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void ActivateRestartMenu()
    {
        restartMenu.SetActive(true);
        
    }

    public void DeactivateRestartMenu()
    {
        restartMenu.SetActive(false);
        score = 0;
    }

    private void CreatePlayer()
    {
        Instantiate(player);
    }

    private void PopulateAsteroids()
    {
        Vector2 position;
        for (int i = 0; i < 10; i++)
        {
            position = new Vector2(Random.Range(-9.4f, 9.4f), Random.Range(-5.4f, 5.4f));
            Instantiate(asteroid, position, Quaternion.identity);
        }
        
    }
}
