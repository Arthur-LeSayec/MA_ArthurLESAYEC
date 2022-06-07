using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    private static float moveSpeed= 8f;

    private static float fireRate = 0.5f;

    public static float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }

    public static float FireRate { get => fireRate; set => fireRate = value; }


    private void Awake()
    {
        if (instance== null)
        {
            instance = this;
        }
    }


    void Update()
    {
        
    }
    public static void FireRateChange(float rate)
    {
        fireRate -= rate;
    }
    public static void MoveSpeedChange(float speed)
    {
        moveSpeed += speed;
    }


}
