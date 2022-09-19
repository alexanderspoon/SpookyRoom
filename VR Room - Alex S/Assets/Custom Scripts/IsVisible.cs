using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour
{
    Renderer m_Renderer;

    bool moving = false;
    float speed = 10f;

    public GameObject eventHandler;


    // Use this for initialization
    void Start()
    {
        m_Renderer = GetComponentInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Renderer.isVisible) {
            Invoke("moveOver", 1);
        }

        if (moving) {
            transform.Translate(new Vector3 (-7, 0, -1) * speed * Time.deltaTime);
        }
    }

    public void moveOver() {
        moving = true;
        eventHandler.GetComponent<Event>().JumpScareInitializer();
        Invoke("DestroyObject", 1);
    }

    public void DestroyObject() {
        Destroy(this.gameObject);
    }
}
