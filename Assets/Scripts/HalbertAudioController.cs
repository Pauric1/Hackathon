using UnityEngine;

public class HalbertAudioController : MonoBehaviour
{

    public AudioSource walkingAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayWalkingAudio(bool walking)
    {
        if (walking && !walkingAudio.isPlaying)
        {
            walkingAudio.Play();
        }

        if (!walking)
        {
            walkingAudio.Stop();
        }
    }
}
