using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistolita : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab, shootPoint;

    public void Shoot()
    {
        Instantiate(bulletPrefab, shootPoint.transform.position, Quaternion.identity);
    }    
}
