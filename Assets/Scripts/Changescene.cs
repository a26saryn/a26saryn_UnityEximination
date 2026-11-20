using UnityEngine;
using UnityEngine.SceneManagement;


public class Changescene : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Door")
        {
            SceneManager.LoadScene("Scenes/Scene2");
        }
    }
}