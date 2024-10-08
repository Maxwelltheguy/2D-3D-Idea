using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DimensionController : MonoBehaviour
{
    //Create the variables
    public bool isThreeDimension = true;
    [SerializeField] GameObject twoDimensionStuff;
    [SerializeField] GameObject threeDimensionStuff;
    [SerializeField] Transform threeDimensionalCharacter;
    [SerializeField] Transform twoDimensionalCharacter;

    void Start()
    {
        
    }

    void Update()
    {
        if (isThreeDimension == true)
        {
            twoDimensionStuff.SetActive(false);
            threeDimensionStuff.SetActive(true);
            twoDimensionalCharacter.position = new Vector3(threeDimensionalCharacter.position.x, threeDimensionalCharacter.position.y, threeDimensionalCharacter.position.z);
        }
        else
        {
            twoDimensionStuff.SetActive(true);
            threeDimensionStuff.SetActive(false);
            threeDimensionalCharacter.position = new Vector3(twoDimensionalCharacter.position.x, twoDimensionalCharacter.position.y, twoDimensionalCharacter.position.z);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isThreeDimension == true)
            {
                isThreeDimension = false;
            }
            else
            {
                isThreeDimension = true;
            }
        }
    }
}
