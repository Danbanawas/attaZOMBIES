using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycastgun : MonoBehaviour
{
    public Camera PlayerCamera;
    public Transform Laserorigin;
    public float Gunrange = 50f;
    public float fireRate = 0.2f;
    public float laserDuration = 0.05f;

    LineRenderer Laserline;
    float firetimer;
    public AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    Zcounter zcount;


    private void Awake()
    {
        Laserline = GetComponent<LineRenderer>();
        audioSource=GetComponent<AudioSource>();
    }

    void Start()
    {
        zcount = GameObject.Find("kco").GetComponent<Zcounter>();

    }


    void Update()
    {
        firetimer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && firetimer > fireRate)
        {
            firetimer = 0;
            Laserline.SetPosition(0, Laserorigin.position);
            Vector3 rayOrigin = PlayerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0, 0));
            RaycastHit hit;
            
            audioSource.PlayOneShot(audioClip);
            if (Physics.Raycast(rayOrigin, PlayerCamera.transform.forward, out hit, Gunrange))
            {
                Laserline.SetPosition(1, hit.point);
               
                Destroy(hit.transform.gameObject);
                zcount.addkill();
              

            }
            else
            {
                Laserline.SetPosition(1, rayOrigin + (PlayerCamera.transform.forward * Gunrange));
            }
            StartCoroutine(ShootLaser());

        }

    }
    IEnumerator ShootLaser()
    {
        Laserline.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        Laserline.enabled = false;
    }
}
