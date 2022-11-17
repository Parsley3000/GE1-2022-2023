using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAi : MonoBehaviour
{
    [SerializeField] float turretRange = 13f;
    [SerializeField] float turretRotationSpeed = 5f;
    // Start is called before the first frame update

    private Transform playerTransform;
    private Gun currentGun;
    private float fireRate;
    private float fireRateDelta;

    private void Start()
    {
        playerTransform = FindObjectOfType<TankController>().transform;
        currentGun = GetComponentInChildren<Gun>();
        fireRate = currentGun.getRateOfFire();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 playerGroundPos = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);

        if (Vector3.Distance(transform.position, playerGroundPos) > turretRange)
        {
            return;
        }

        Vector3 playerDirection = playerGroundPos - transform.position;
        float turretRotationStep = turretRotationSpeed * Time.deltaTime;
        Vector3 newLookDirection = Vector3.RotateTowards(transform.forward, playerDirection, turretRotationStep, 0f);

        transform.rotation = Quaternion.LookRotation(newLookDirection);

        fireRateDelta-=Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            currentGun.Fire();
            fireRateDelta = fireRate;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, turretRange);
    }
}
