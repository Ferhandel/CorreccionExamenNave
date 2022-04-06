using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if(bulletPrefab == null){
            Debug.Log("bulletPrefab no está establecido figura ;)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Probabilidad de 0 entre 1.000
        if(Random.value <= 0.001f){
            Shot();
        }
    }

    private void Shot(){

    }
}
