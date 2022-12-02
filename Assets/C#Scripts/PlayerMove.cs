using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public bool isMoving;
    public Animator anim;
    public static PlayerMove Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        if (!isMoving) return;
        transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
}
