using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    private GameObject spawnobject;
    [SerializeField]
    public GameObject Spawnpoint;
    [SerializeField]
    public GameObject block;
    [SerializeField]
    private float speed = 10;
    private float colddown;



    // Start is called before the first frame update
    void Start()
    {
        colddown = 0f;

    }
    // Update is called once per frame
    void Update()
    {
        if (colddown > 0)
        {
            colddown -= Time.deltaTime;
        }
        create();
        if (spawnobject != null)
        {
            spawnobject.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
    public void create()
    {
        if (cancreate)
        {
            spawnobject = Instantiate(block, Spawnpoint.transform.position, Quaternion.identity);

            colddown = 2f;
        }
    }

    public bool cancreate
    {
        get
        {
            return colddown <= 0f;
        }
    }


}
