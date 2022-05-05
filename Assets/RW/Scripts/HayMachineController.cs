using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HayMachineController : MonoBehaviour
{
    public int movementSpeed = 10;
    public int boostSpeed = 20;
    public int horizontalBoundary = 22;
    public GameObject hayBalePrefab;
    public Transform haySpawnPoint;
    public float shootInterval;
    private float shootTimer;
    public GameObject boostSliderGameObject;
    private Slider boostSlider;
    [SerializeField] private float boostLeft = 100;
    private float boostModifier = 50;

    private void Start()
    {
        boostSlider = boostSliderGameObject.GetComponent<Slider>();
    }

    void Update()
    {
        UpdateMovement();
        UpdateShooting();
        UpdateBoost();
    }

    private void UpdateMovement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        
        int speed = Input.GetButton("Boost") && boostLeft > 0 ? boostSpeed : movementSpeed;

        if (horizontalInput < 0 && transform.position.x > -horizontalBoundary)
        {
            transform.Translate(transform.right * (-speed * Time.deltaTime));
        }
        else if(horizontalInput > 0 && transform.position.x < horizontalBoundary)
        {
            transform.Translate(transform.right * (speed * Time.deltaTime));
        }
    }

    private void UpdateBoost()
    {
        if (!Input.GetButton("Boost") && boostLeft >= 100 || Input.GetButton("Boost") && boostLeft <= 0)
        {
            return;
        }
        boostLeft = Input.GetButton("Boost") ? boostLeft - Time.deltaTime * boostModifier: boostLeft + Time.deltaTime *boostModifier;
        boostSlider.value = boostLeft;
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
