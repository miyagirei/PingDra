using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    void Start()
    {
        GameObject randomItem = itemPrefabs[Random.Range(0, itemPrefabs.Length)]; //リストにあるprefabsをランダムに選びます

        Vector3 pos = transform.position;

        Instantiate(randomItem, new Vector3(pos.x, pos.y + 0.5f, pos.z), Quaternion.identity);  //配置
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
