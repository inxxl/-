using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vasicvariablese : MonoBehaviour
{

	public int gold = 0; 
	public float hp = 100.0f;
	public string playrname = "홍길동";
	private bool isAlive = true;

    void Start()
    {
        Debug.Log("게임 시작");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("게임 진행중"); 
    }
}
