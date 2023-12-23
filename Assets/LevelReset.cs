using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    public void GameOver()
    {
        player.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(collision.gameObject.tag);
            GameOver();
        }
    }
}
