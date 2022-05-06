using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Seçiniz...");
        items.Add("101");
        items.Add("102");
        items.Add("103");

        foreach(var item in items){
            dropdown.options.Add(new Dropdown.OptionData(){text = item});
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
