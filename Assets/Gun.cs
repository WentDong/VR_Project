using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public bool rocket = false;
    public float fireSpeed = 40;

    public GameObject soundObject;
    public AudioClip clip;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    private void FireBullet(ActivateEventArgs arg)
    {
        if (clip!=null){
            soundObject.GetComponent<AudioSource>().PlayOneShot(clip);
        }

        GameObject spawnBullet = Instantiate(bullet,spawnPoint.position,spawnPoint.rotation);
        if (!rocket){
            spawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        }
        Destroy(spawnBullet, 50);
    }
}