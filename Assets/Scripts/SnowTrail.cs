using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowTrailEffect;

    //could use an if that checks for ground using other.gameObject.tag, but since there's no other objects
    //if my world to collide with, not necessary.
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Currently touching the snow!");
        snowTrailEffect.Play();
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("Currently getting some gnarly air!!!");
        snowTrailEffect.Stop();
    }

}
