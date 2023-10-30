using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    GameObject player;
    public AudioSource win;
    [SerializeField] private Slider _slider;
    [SerializeField] private Button _button;


    bool playedWinSound = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        if (!PlayerPrefs.HasKey("musicvolume"))
        {
            PlayerPrefs.SetFloat("musicvolume", 1);
            Load();
        } else
        {
            Load();
        }
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
    
    public void ChangeVolume()
    {
        AudioListener.volume = _slider.value;
    }

    private void Load()
    {
        _slider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", _slider.value);
    }
    
    public void Mute()
    {
        AudioListener.volume = 0;
    }
}
