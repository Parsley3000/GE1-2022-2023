using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("target"))
        {
            GameController.score++;
            Destroy(other.gameObject); //destory brick
            Destroy(gameObject); //destory projectile
        }
    }
}
