using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundNoise : MonoBehaviour
{
    public AudioSource Background;
    void Start()
    {
        Background.Play();
    }
}
