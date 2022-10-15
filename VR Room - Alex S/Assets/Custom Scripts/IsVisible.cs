using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour
{
    Renderer m_Renderer;
    public GameObject eventHandler;

    public bool seen = false;

    // Use this for initialization
    void Start()
    {
        m_Renderer = GetComponentInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Renderer.isVisible && !seen) {
            Invoke("Disappear", 4);
            seen = true;
        }
    }

    public void Disappear() {
        eventHandler.GetComponent<Event>().Disappear();
    }

    public void DestroyObject() {
        Destroy(this.gameObject);
    }
}
