using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
{
    AudioSource audioSource;

    [HideInInspector]
    public Hand m_ActiveHand = null;
    
    public void Update(){
        audioSource = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Floor"){
            audioSource.Play();
        }
    }
}
