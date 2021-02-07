using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    public void reproducirGuitarra()
    {
        audioS.clip = clips[0];
        audioS.Play();
        Debug.Log("suena guitarra");
    }

    public void reproducirPiano()
    {
        audioS.clip = clips[1];
        audioS.Play();
        Debug.Log("suena piano");
    }

    public void reproducirTrompeta()
    {
        audioS.clip = clips[2];
        audioS.Play();
        Debug.Log("suena trompeta");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
