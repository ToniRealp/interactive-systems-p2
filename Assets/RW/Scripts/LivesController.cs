using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{
    private int remainingLives = 3;

    public List<GameObject> sheepLives = new List<GameObject>(3);


    private void OnEnable()
    {
        EventManager.OnSheepDrop.AddListener(UpdateLives);
    }

    private void OnDisable()
    {
        EventManager.OnSheepDrop.RemoveListener(UpdateLives);
    }
    private void UpdateLives()
    {
        remainingLives -= 1;
        sheepLives[remainingLives].SetActive(false);
        
    }
}
