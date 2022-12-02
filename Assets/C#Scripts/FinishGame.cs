using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public Animator Anim;
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            PlayerMove.Instance.isMoving = false;
            PlayerSwerve.Instance.enabled = false;
            Anim.SetTrigger("Finishidle");
        }
    }
}
