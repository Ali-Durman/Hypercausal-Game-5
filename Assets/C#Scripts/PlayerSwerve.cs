using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwerve : MonoBehaviour
{
    [SerializeField] private float MaxSwerveAmount = 0.5f;
    [SerializeField] private float SwerveSpeed = 0.5f;
    private float LastFingerPosX;
    private float MoveFactorX;
    public float MoveFac => MoveFactorX;
    public float MinX;
    public float MaxX;
    public static PlayerSwerve Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            MoveFactorX = Input.mousePosition.x - LastFingerPosX;
            LastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            MoveFactorX = 0f;
        }

        float swerveamount = Time.deltaTime * SwerveSpeed * MoveFac;
        swerveamount = Mathf.Clamp(value: swerveamount, min: -MaxSwerveAmount, max: MaxSwerveAmount);
        transform.Translate(swerveamount, 0, 0);

        float xPos = Mathf.Clamp(value: transform.position.x, min: MinX, max: MaxX);
        transform.position = new Vector3(xPos,transform.position.y,transform.position.z);
    }
}
