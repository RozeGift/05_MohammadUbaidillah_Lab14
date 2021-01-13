using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereRed : MonoBehaviour
{
    public GameObject RedText;
    private int redCounter;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            redCounter++;
            RedText.GetComponent<Text>().text = "Red: " + redCounter;
            audioSource.Play();
        }
    }
}
