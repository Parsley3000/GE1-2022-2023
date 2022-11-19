using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody projectile;
    // Update is called once per frame
    void Update()
    {
        //projectile creation and launch
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody cloned_Projectile;
            cloned_Projectile = Instantiate(projectile, transform.position, transform.rotation);
            cloned_Projectile.velocity = transform.TransformDirection(Vector3.forward * 100f);
            Destroy(cloned_Projectile.gameObject, 1.5f); //1.5f is time projectile lastest in game
        }

        //player movement left and right
        //3.0f is the player speed
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;

        transform.Translate(x, 0f, 0f);
    }
}
