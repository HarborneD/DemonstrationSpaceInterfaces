using UnityEngine;
using System.Collections;

public class HandMenuControl : MonoBehaviour {
    public int tv_id;
    GameObject menu;
    Renderer current_tv_renderer;

    // Use this for initialization
    void awake() {
        Debug.Log("Starting");

        menu = GameObject.Find("MenuParent");
        ToggleMenu(false);
    }
	
	// Update is called once per frame
	void Update () {
	    if(menu == null)
        {
            menu = GameObject.Find("Menu");
            ToggleMenu(false);
        }
	}


    public void ToggleMenu(bool menu_on)
    {
        Debug.Log("Menu On");
        if(menu!=null)
        {
            menu.SetActive(menu_on);
        }
        
    }

    public void SetTV(int screen_number)
    {
        tv_id = screen_number;
        Debug.Log("TV: "+screen_number.ToString());
    }

    public void SetCurrentTVRenderer(Renderer rend)
    {
        if(current_tv_renderer != null)
        {
            current_tv_renderer.material.color = Color.white;
        }

        current_tv_renderer = rend;
        current_tv_renderer.material.color = Color.red;
    }


    public void TogglePlayback()
    {
        Debug.Log("Pinch!");

        if (tv_id > 0)
        {
            
            var tv_object = GameObject.Find("TV " + tv_id.ToString());
            if (tv_object != null)
            {
                tv_object.GetComponent<TvControl>().TogglePlayback();
            }

        }
    }
}
