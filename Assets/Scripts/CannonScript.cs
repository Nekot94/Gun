using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CannonScript : MonoBehaviour {

    [SerializeField] private Rigidbody bullet;
    [SerializeField] private Transform fireTransform;
    [SerializeField] private GameObject gun;
    [SerializeField] private Text angleText;
    [SerializeField] private Text forceText;



    private bool fired;
    private float nextFireTime;
    private float launchForce;




    public void SetAngle(float angle)
    {
        gun.transform.localEulerAngles = new Vector3(angle, 0, 0);
        angleText.text = "Угол: " + angle.ToString();
    }

    public void SetForce(float force)
    {
        launchForce = force;
        forceText.text = "Сила: " + force.ToString();
    }

    public void Fire(float fireRate)
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            fired = true;

            Rigidbody shellInstance =
                Instantiate(bullet, fireTransform.position, fireTransform.rotation) as Rigidbody;

            shellInstance.velocity = launchForce * fireTransform.forward;

            //m_ShootingAudio.clip = m_FireClip;
            //m_ShootingAudio.Play();

        }

    }
}
