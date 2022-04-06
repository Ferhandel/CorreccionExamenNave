using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private Vector3 leftBottomShipPosition = new Vector3(-2.2f, 1.8f, 0f);
    public GameObject enemyPrefab;
    private GameObject[] enemies;
    float distance = 0.65f;
    //Numero de enemigos máximo.
    //private int enemyMaxNumber = 8;
    //distancia entre enemigos
    private float enemyDistance = 1.8f;
    private float enemyCoordY = 0;
    
    void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        if (enemyPrefab == null){
            Debug.Log("Aviso: no está establecido el prefab del enemigo");
        }
        SpawnEnemy();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy(){
        for(int i=0; i<10; i++){
            Instantiate(enemyPrefab,leftBottomShipPosition + Vector3.right * distance * i, Quaternion.identity);
            Instantiate(enemyPrefab,leftBottomShipPosition + Vector3.up * distance + Vector3.right * distance * i, Quaternion.identity);
        } 
    }
}
