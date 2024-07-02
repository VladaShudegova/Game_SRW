using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using TMPro;

public class TimerMiniGame : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] TextMeshProUGUI TimerTextUI;
    [SerializeField] AudioSource audio;
     public int GameTime = 59; //время игры 
        int _currentTime = 0;//сколько прошло 

    void Awake()
    {
        TimerTextUI.text = "1:00";
    }
    void Start()
    {
        //audio = gameObject.GetComponent<AudioSource>();
        panel.SetActive(false); 
        Time.timeScale = 1; 
        InvokeRepeating("Timer", 0, 1); 
    }

  
    void Update()
    {
        
    }
    void Timer() 

    { 

        _currentTime++; 
        if(_currentTime > GameTime) 

        { 
           panel.SetActive(true); 
           //audio.Play();
            Time.timeScale = 0; 
        } 
        else 

        { 
            if(10 > (GameTime - _currentTime)){
                TimerTextUI.text = "0:0"+(GameTime - _currentTime).ToString();
            }
            else{
                TimerTextUI.text = "0:"+(GameTime - _currentTime).ToString(); 
            }
          
        } 

    } 

    
}
