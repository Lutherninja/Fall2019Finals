using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource mainMusic;
    void Start()
    {
        mainMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
