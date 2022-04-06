using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Nave
    private Rigidbody2D rb;
    private Collider2D collider;
    public float speed = 2.8f; 
    private float actualSpeed;
    private float aceleracionFrenada =0.0f;
    private bool frenar = false; 

    //Bullet
    public GameObject bulletPrefab;
    public float fireRate = 0.4f;
    public float canFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && actualSpeed <= 0){
            actualSpeed = -speed;
            transform.localScale = new Vector3 (1, 1, 1);
        } else if (Input.GetKey(KeyCode.RightArrow) && actualSpeed >=0){
            actualSpeed = speed; 
            
        } else if (actualSpeed != 0){
            frenar = true;

            if(actualSpeed > 0){
            actualSpeed -= aceleracionFrenada * Time.deltaTime;
            } else {
                actualSpeed += aceleracionFrenada * Time.deltaTime;
            }
            if(Mathf.Abs(actualSpeed) < 0.01f) {
                    frenar = false;                
                    actualSpeed = 0;
                }
            
        }

        transform.Translate(Vector3.right * actualSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)){
            //spawnbullet
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            canFire = Time.time + fireRate;
        } 
            

    }

}