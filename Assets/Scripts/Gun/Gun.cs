using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private projectile projectile;
    [SerializeField] private float damage;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private AudioClip fireSound;
     
    public void Fire()
    {
        //EXECUTAR ANIMAÇÕES, SONS E EFEITOS DE TIRO DA ARMA
        Instantiate(projectile, bulletSpawn.position, bulletSpawn.rotation);
    }
}
