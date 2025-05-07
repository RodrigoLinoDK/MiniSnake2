using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gameManager = GameObject.Find
            ("GameManager").GetComponent<GameManager>();
            gameManager.GameOver();
        }
    }
    // Start is called before the first frame update
}
