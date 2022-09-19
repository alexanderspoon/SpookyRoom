using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{

    public GameObject mainLight; 
    public GameObject creature; 
    public GameObject jumpScare; 

    bool scare = false;

    public AudioClip crows;
    public AudioClip light;
    public AudioClip jumpScareSound;

    public float volume = 1;

    void Awake() {
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("playLightSound", 20f);
        Invoke("Disable", 20f);
        Invoke("Enable", 20.1f);
        Invoke("Disable", 20.2f);
        Invoke("playCrowSound", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (scare) {
            jumpScare.transform.Translate(Vector3.forward * 12 * Time.deltaTime);
        }
    }
    public void JumpScareInitializer() {
        Invoke("JumpScare", 15f);
    }
    public void playLightSound() {
        AudioSource.PlayClipAtPoint(light, transform.position, volume);
    }
    public void playCrowSound() {
        AudioSource.PlayClipAtPoint(crows, transform.position, volume);
    }
    public void Disable() {
        mainLight.SetActive(false);
    }
    public void Enable() {
        mainLight.SetActive(true);
        creature.SetActive(true);
    }
    public void JumpScare() {
        jumpScare.SetActive(true);
        AudioSource.PlayClipAtPoint(jumpScareSound, jumpScare.transform.position, volume);
        scare = true;
    }
}
