using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreController : MonoBehaviour
{
    private int score = 0;
    private TextMeshProUGUI _textMeshPro;

    private void Start()
    {
        _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
        _textMeshPro.text = score.ToString();
    }

    private void OnEnable()
    {
        EventManager.OnSheepHit.AddListener(UpdateScore);
    }

    private void OnDisable()
    {
        EventManager.OnSheepHit.RemoveListener(UpdateScore);
    }

    private void UpdateScore(EventManager.OnSheepHitInfo sheepHitInfo)
    {
        score += sheepHitInfo.sheepScore;
        _textMeshPro.text = score.ToString();
    }
}
