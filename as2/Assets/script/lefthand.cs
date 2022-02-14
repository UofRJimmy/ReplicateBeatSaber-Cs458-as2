using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lefthand : MonoBehaviour
{
    private string sceneName;
    private AudioSource effect;
    // Start is called before the first frame update
    void Start()
    {
        effect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {



    }
    // switch the scence to number 0 sence
    void ChangeSceneone()
    {
        SceneManager.LoadScene(1);
        sceneName = SceneManager.GetActiveScene().name;
    }
    void ChangeScenetwo()
    {
        SceneManager.LoadScene(2);
        sceneName = SceneManager.GetActiveScene().name;
    }
    void ChangeScenezero()
    {
        SceneManager.LoadScene(0);
        sceneName = SceneManager.GetActiveScene().name;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Destroy(collision.gameObject);
            ChangeSceneone();
        }
        if (collision.gameObject.layer == 9)
        {
            Destroy(collision.gameObject);
            ChangeScenetwo();
        }
        if (collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
            ChangeScenezero();
        }
        if (collision.gameObject.layer == 11)
        {
            effect.Play();
            Destroy(collision.gameObject);
          
        }
       
    }


}


