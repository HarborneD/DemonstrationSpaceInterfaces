using UnityEngine;
using System.Collections;

public class TvControl : MonoBehaviour {
    public int tv_id;
    public bool is_playing = false;

	// Use this for initialization
	void start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void TogglePlayback()
    {
        if(is_playing)
        {
            StopLoadedMoive();
        }
        else
        {
            PlayLoadedMoive();
        }
    }

    void PlayLoadedMoive()
    {
        is_playing = true;
        Debug.logger.Log("Play movie on screen: " + this.tv_id.ToString());
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
        this.GetComponent<AudioSource>().Play();
    }

    void StopLoadedMoive()
    {
        is_playing = false;
        Debug.logger.Log("Stop movie on screen: "+this.tv_id.ToString());
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Stop();
        this.GetComponent<AudioSource>().Stop();
    }

}
