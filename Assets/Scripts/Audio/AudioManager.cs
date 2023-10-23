using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    GameObject player;
    public AudioSource win;

    bool playedWinSound = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Interactions>().winScreenActivated == true && playedWinSound == false)
        {
            playedWinSound = true;
            win.Play();
        }
    }
}
