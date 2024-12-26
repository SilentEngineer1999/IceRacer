using System;
using UnityEngine;

public class DustTrails : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrails;
    bool canSlide = true;

    // void OnCollisionEnter2D(Collision2D other) {
    //     if (other.gameObject.tag == "Ground")
    //     {
    //         if (canSlide)
    //         {
    //             dustTrails.Play();
    //         }    
    //     }        
    // }

    void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "Ground")
        {
            if (canSlide)
            {
                dustTrails.Play();
            } 
        } 
    }

    public void disableSlide()
    {
        canSlide = false;
    }

    void OnCollisionExit2D(Collision2D other) {
             Invoke("onLeftGround", 0.2f);
    }

    void onLeftGround()
    {
        dustTrails.Stop();
    }
}
