using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    float delayNum = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            GetComponent<DustTrails>().disableSlide();
            GetComponent<PlayerController>().disableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delayNum);
        }    
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
