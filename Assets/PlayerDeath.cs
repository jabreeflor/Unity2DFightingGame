using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]Transform spawnPoint;
    [SerializeField] Transform spawnPoint2;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            col.transform.position = spawnPoint.position;
            GameControlScript.health -= 1;
        }else if (col.transform.CompareTag("Player2"))
        {
            col.transform.position = spawnPoint2.position;
            GameControlScript.player2Health -= 1;
        }
    }
}
