﻿using UnityEngine;

public class Ad : MonoBehaviour
{   //小雞
    [Header("跳躍高度")]
    [Range(1,5000)]
    [Tooltip("跳躍高度")]
    public int Jumpheight = 100;
    [Header("是否死亡")]
    [Tooltip("是否死亡")]
    public bool Whetheritisdead;
}