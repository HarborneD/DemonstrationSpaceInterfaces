using UnityEngine;
using System.Collections;
using System;

public class PointTvControl : MonoBehaviour {

    public int tv_id;

    public bool making_selection;

    public Transform index_bone;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(making_selection)
        {
            ChannelSelect();
        }
	}

    public void SetSelecting(bool selecting)
    {
        making_selection = selecting;

        if(!selecting)
        {
            tv_id = 0;
        }
    }

    public void ChannelSelect()
    {
        Vector3 fwd = index_bone.TransformDirection(Vector3.forward);
        
        RaycastHit hit;

        float max_distance = 100;

        Debug.DrawLine(index_bone.position, fwd * 100, Color.red, 120);

        if (Physics.Raycast(index_bone.position, fwd,out hit, max_distance))
        {
            TvControl tv = hit.collider.GetComponentInParent<TvControl>();

            if(tv !=null)
            {
                this.tv_id = tv.tv_id;
                Debug.Log("There is something in front of the object!Tv id set to:" + this.tv_id.ToString());

            }
            Debug.Log("There is something in front of the object!");
        }

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
