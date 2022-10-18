using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrroshairScript : MonoBehaviour
{
    [SerializeField] private RectTransform crrosshair;

    public GameObject player;

    public float aimSize = 25f;
    public float idleSize = 50f;
    public float walkSize = 75f;
    public float runJumpSize = 125f;
    public float currentSize = 50f;
    public float speed = 10f;


}
