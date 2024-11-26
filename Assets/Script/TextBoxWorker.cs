using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextBoxWorker : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputField;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable() // runs every time object is enabled
    {
        // EventSystem.current.SetSelectedGameObject(inputField.gameObject, null); //put where textbox appears 
        // inputField.OnPointerClick(null);
    }
}
