using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    private string sceneName;
    
    public AudioSource song;
    // Start is called before the first frame update
    void Start()
    {
        playmusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // switch the scence to number 0 sence

    private void playmusic()
    {
        song.Play();
    }

}


