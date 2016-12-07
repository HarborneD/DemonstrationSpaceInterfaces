using UnityEngine;
using System.Collections;
using System;

public class GestureLogging : MonoBehaviour {

    public bool palm_up = false;

    public int channel_track;

	// Use this for initialization
	void Awake () {
    }
	
	// Update is called once per frame
	void Update () {
	   
	}

    public void VideoControl()
    {
        
        Debug.Log("Video Control Active!! - "+ this.tag[0]);
    }

    public  void ChannelSelect(int channel)
    {   if(channel>0)
        {
            Debug.Log("Gesture for channel:" + channel.ToString());
        }
        this.channel_track = channel;
    }

    public void PalmLog(bool palm)
    {
        if(palm)
        {
            Debug.Log("Palm Up!!");

        }
        palm_up = palm;
    }
    
    public void TogglePlayback()
    {
        Debug.Log("Pinch!");

        if (channel_track > 0)
        {
            int channel = channel_track + 3 * Convert.ToInt16(palm_up);
            Debug.Log("Playback toggle for channel:" + channel.ToString());

            var tv_object = GameObject.Find("TV "+ channel.ToString());
            if(tv_object != null)
            {
                tv_object.GetComponent<TvControl>().TogglePlayback();
            }
            
        }
    }

    
}
