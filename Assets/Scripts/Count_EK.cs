using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_EK : MonoBehaviour
{
    [SerializeField] GameObject[] Enemy;
    [SerializeField] public int number;
    //[SerializeField] public int co;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //co = Enemy.Length/12;
        number = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
