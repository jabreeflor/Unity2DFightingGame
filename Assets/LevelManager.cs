using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform respawnPoint;
    public Transform respawnPoint2;
    public GameObject playerPrefab;
    public GameObject playerPrefab2;
    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        Instantiate(playerPrefab2, respawnPoint2.position, Quaternion.identity);
    }
    

}
