using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnButtonPress : MonoBehaviour
{
    [SerializeField] KeyCode buttonToPress = KeyCode.E;
    [SerializeField] bool enableAnObject = false;
    [SerializeField] GameObject objectToEnable;


    //Gets the selected input and checks if it is pressed to enable and destroy objects
    private void Update()
    {
        if (Input.GetKeyDown(buttonToPress))
        {
            if (enableAnObject == true)
            {
                objectToEnable.SetActive(true);
            }

            Destroy(gameObject);

        }
    }
}
