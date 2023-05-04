using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] private float bulletVelocity;
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private float bulletLifeTime;


    private void Start()
    {
        StartCoroutine(LifeSpan());
       
    }
    void Update()
    {
        transform.Translate(Vector3.forward * bulletVelocity * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
    private IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(bulletLifeTime);
        Destroy(this.gameObject);
    }
}
