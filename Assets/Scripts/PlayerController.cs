using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] GameObject _gameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Time.timeScale = 0;

            _gameOver.SetActive(true);
        }
    }

    public void GameOver()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

        _gameOver.SetActive(false);
    }

}
