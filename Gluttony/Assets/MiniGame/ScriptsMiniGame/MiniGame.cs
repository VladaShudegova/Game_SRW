using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MiniGame : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera _virtualCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartGame()
    {
        _virtualCamera.enabled = true;
    }
}
