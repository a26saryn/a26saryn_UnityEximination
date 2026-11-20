using UnityEngine;

public class StarPick : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //StarManager.instance.AddCoin():
            Destroy(gameObject);
        }
    }
}
