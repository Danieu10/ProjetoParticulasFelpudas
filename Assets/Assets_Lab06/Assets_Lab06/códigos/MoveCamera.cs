using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 deslocamento;
    
    public Vector3 concerta = new Vector3 (0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
        deslocamento = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + deslocamento+concerta;
    }
}
