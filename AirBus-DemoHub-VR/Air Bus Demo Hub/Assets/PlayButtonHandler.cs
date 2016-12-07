using UnityEngine;
using System.Collections;

public class PlayButtonHandler : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with play button");
        if(!string.IsNullOrEmpty(other.tag))
        {
            Debug.Log("collider tag:"+other.tag);

        }


        if (other.tag == "right_index")
        {
            Debug.Log("Collision was with index finger");

            GetComponentInParent<HandMenuControl>().TogglePlayback();


        }
    }
}
