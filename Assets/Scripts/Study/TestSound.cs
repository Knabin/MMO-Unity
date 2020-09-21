using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public AudioClip clip;
    public AudioClip clip2;

    int i = 0;

    private void OnTriggerEnter(Collider other)
    {
        i++;

        if(i % 2 == 0)
        Managers.Sound.Play(clip, Define.Sound.Bgm);
        else
        Managers.Sound.Play(clip2, Define.Sound.Bgm);
    }
}
