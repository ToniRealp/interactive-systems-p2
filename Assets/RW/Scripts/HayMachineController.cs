using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayMachineController : MonoBehaviour
{
    public int movementSpeed = 10;
    public int boostSpeed = 20;
    public int horizontalBoundary = 22;
    public GameObject hayBalePrefab;
    public Transform haySpawnPoint;
    public float shootInterval;
    private float shootTimer;

    void Update()
    {
        UpdateMovement();
        UpdateShooting();
    }

    private void UpdateMovement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        int speed = Input.GetButton("Boost") ? boostSpeed : movementSpeed;

        if (horizontalInput < 0 && transform.position.x > -horizontalBoundary)
        {
            transform.Translate(transform.right * (-speed * Time.deltaTime));
        }
        else if(horizontalInput > 0 && transform.position.x < horizontalBoundary)
        {
            transform.Translate(transform.right * (speed * Time.deltaTime));
        }
    }
    
    private void UpdateShooting() {
        shootTimer -= Input.GetButton("Boost") ? Time.deltaTime * 2 : Time.deltaTime;
        if (shootTimer <= 0 && Input.GetKey(KeyCode.Space)) {
            shootTimer = shootInterval;
            ShootHay();
        }
    }


    private void ShootHay()
    {
        Instantiate(hayBalePrefab, haySpawnPoint.position, Quaternion.identity);
    }
}
