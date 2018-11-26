using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script for the animation and deletion of good food
[RequireComponent(typeof(AudioSource))]
public class goodFood : MonoBehaviour {

    AudioSource audiosource;
    // Use this for initialization
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0, 5.0f, 0);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            audiosource.Play();
            Destroy(gameObject, 1);
        }

    }
}
