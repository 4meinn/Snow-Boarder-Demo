using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;  // Gecikmeyi Unity uzerinden ayarlayabilmek icin SerializeField olarak tanimladik. 
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);  // Invoke kullanarak gecikme sagladik. Gecikmenin ne kadar olmasi gerektigine loadDelay ifadesini tanimladik.
            
        }
    }

    void ReloadScene()
    {
        {
            SceneManager.LoadScene(0);  // Buradaki Statement'i Invoke'a gostermek icin Method icerisinde ayirdik.
        }
    }
}
