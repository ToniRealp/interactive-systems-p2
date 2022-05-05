using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager 
{
    public struct OnSheepHitInfo
    {
        public int sheepScore;

        public OnSheepHitInfo(int sheepScore)
        {
            this.sheepScore = sheepScore;
        }
    }
    
    public static readonly UnityEvent<OnSheepHitInfo> OnSheepHit = new UnityEvent<OnSheepHitInfo>();
    public static readonly UnityEvent OnSheepDrop = new UnityEvent();
    
}
