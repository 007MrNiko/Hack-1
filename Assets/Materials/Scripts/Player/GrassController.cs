using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassController : MonoBehaviour
{
    [SerializeField] public AudioClip Sound;
    private Animator anim;
    private AudioSource source;

    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            source.clip = Sound;
            source.Play();
            anim.SetTrigger("Move");
        }
    }
}
