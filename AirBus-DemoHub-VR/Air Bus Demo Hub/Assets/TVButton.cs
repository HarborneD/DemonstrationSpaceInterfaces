using UnityEngine;
using System.Collections;

public class TVButton : MonoBehaviour {

    public int screen_number;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with button: "+screen_number.ToString());

        if (other.tag == "right_index")
        {
            Debug.Log("Collision was with index finger");

            HandMenuControl control_handler = GetComponentInParent<HandMenuControl>();
            control_handler.SetTV(screen_number);

            Renderer rend = GetComponent<Renderer>();
            control_handler.SetCurrentTVRenderer(rend);
        }
    }
}
