using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    
    void OnCollisionEnter2D(Collision2D other)  // Temas gerceklestigi anda (On Collision Enter) bunu yap.
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticles.Play();
        }
    }

    
    void OnCollisionExit2D(Collision2D other)  // Temastan ayrildigin anda (On Collision Exit) bunu yap.
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticles.Stop();
        }
    }
}
