using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop_up : MonoBehaviour
{
    public GameObject speech;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            speech.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            speech.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
