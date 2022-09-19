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
        Invoke("playCrowSound", 10f);

        Invoke("playLightSound", 20f);
        Invoke("Disable", 20f);
        Invoke("Enable", 20.1f);
        Invoke("Disable", 20.2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scare) {
            jumpScare.transform.Translate(Vector3.forward * 12 * Time.deltaTime);
        }
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

    public void RemoveCreature() {
        creature.GetComponent<IsVisible>().DestroyObject();
        Invoke("JumpScare", 15f);
    }
    public void Disappear() {
        Invoke("playLightSound", 1f);
        Invoke("Enable", 1f);
        Invoke("Disable", 1.1f);
        Invoke("RemoveCreature", 1.1f);
    }
}
