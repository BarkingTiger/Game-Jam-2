using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
class ShowTextButton : MonoBehaviour
{
    public GameObject spawn;
    public GameObject prefab;
    private bool spawned = false;
    private bool showText = false;

    //test vector
    Vector3 pos = Vector3.forward;
    //tets rotation
    Quaternion rot = Quaternion.Euler(0, 0, 0);

    // Create a bool to say whether to show the button or not
     
    void OnMouseDown()
    {
        if(!showText)
            showText = true;
        // If you clicked the object, set showText to true
        if(!spawned) {
            spawned = true;
        }
    }
     
    void OnGUI()
    {
        if(showText)
        {
            // If you've clicked the object, show this button
            if(GUI.Button(new Rect(100,100,100,20), "Click To Close"))
                // If you click this button, set showText to false
                showText = false;
        }

        
        //may need to make more of these scripts to update location and object spawned
        if(spawned) {
            spawn = (GameObject)Instantiate(prefab, pos, rot);
            spawn.AddComponent<PlayerInteraction>();
        }
    }
}