using UnityEngine;



public class EnemySpawner : MonoBehaviour
{
    public GameObject Player2;
    void Start()
    {
        Instantiate(Player2, transform.position, Quaternion.identity);


    }


}
