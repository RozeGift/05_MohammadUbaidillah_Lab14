using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpherePurple : MonoBehaviour
{
    public GameObject PurpleText;
    private int PurpleCounter;

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
            PurpleCounter++;
            PurpleText.GetComponent<Text>().text = "Purple: " + PurpleCounter;
            audioSource.Play();
        }
    }
}
