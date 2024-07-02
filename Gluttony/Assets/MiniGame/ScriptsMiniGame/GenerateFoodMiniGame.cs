using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFoodMiniGame : MonoBehaviour
{
   [SerializeField] GameObject[] prefabFoods;
   [SerializeField] GameObject player;
   [SerializeField] Transform spawnPointMin;
   [SerializeField] Transform spawnPointMax;

    
  
    void Start()
    {
        Invoke("Generate", 0.2f);
    }

   
    void Update()
    {
       
    }

    void Generate(){
        int index; 
        if(Random.Range(0, 6) < 2){
            index = Random.Range(0, 2);
        }
        else{
            index = Random.Range(2, prefabFoods.Length);
        }
        float time = Random.Range(0, 1.5f);
        Invoke("Generate", time);
        Instantiate(prefabFoods[index],new Vector3(Random.Range(spawnPointMin.position.x,spawnPointMax.position.x), spawnPointMax.position.y, spawnPointMax.position.z ), Quaternion.identity); // new Vector3(player.transform.position.x, gameObject.transform.position.y, player.transform.position.z), Quaternion.identity); //
       
    }
}
