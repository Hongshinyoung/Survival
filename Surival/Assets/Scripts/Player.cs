using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    // Start is called before the first frame update

    private void Awake()
    {
        CharacterController.Instance.Player = this;
        controller = GetComponent<PlayerController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
