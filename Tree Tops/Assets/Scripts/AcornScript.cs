using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AcornScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI AcornText;
    [SerializeField] PlayerScript player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AcornText.text = player.AcornsCollected.ToString();
    }
}
