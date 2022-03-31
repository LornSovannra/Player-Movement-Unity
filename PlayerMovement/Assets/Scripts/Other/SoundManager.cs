using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip collect;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        collect = Resources.Load<AudioClip>("CollectItemwav");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSource.PlayOneShot(collect);
    }
}
