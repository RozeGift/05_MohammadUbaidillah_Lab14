using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapsuleYellow : MonoBehaviour
{
    public GameObject YellowText;
    private int YellowCounter;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            YellowCounter++;
            YellowText.GetComponent<Text>().text = "Yellow: " + YellowCounter;
            audioSource.Play();
        }
    }
}
