using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EditorTexto : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI comecojogo;
    public static EditorTexto instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void apagatexto()
    {
        comecojogo.text = "";
    }

}
