using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnButtonPress : MonoBehaviour
{
    [SerializeField] KeyCode buttonToPress;

    private void Update()
    {
        if (Input.GetKeyDown(buttonToPress))
        {
            Destroy(gameObject);
        }
    }
}
