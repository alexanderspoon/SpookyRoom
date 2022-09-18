using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour
{
    Renderer m_Renderer;

    public GameObject spawner;

    // Use this for initialization
    void Start()
    {
        spawner = GameObject.Find("Spawn Ellertson");
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Renderer.isVisible) {
            Invoke("DestroyObject", 2);
        }
    }

    public void DestroyObject() {
        Destroy(this.gameObject);
        spawner.GetComponent<Spawn>().Spawning();
    }
}
