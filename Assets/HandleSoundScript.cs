using UnityEngine;
using System.Collections;

public class HandleSoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.SetResolution(412, 732, false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlaySound(AudioSource audio)
    {
        if (!audio.isPlaying)
            audio.Play();
        else
            audio.Stop();
    }
}
