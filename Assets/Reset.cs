using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject btn;
    void Start()
    {
    }

    void Update()
    {

    }
    public void reset(){
        string str_path = "/GameBoard/ARButton";
        Console.WriteLine(boardChecker.count); 
    	if(boardChecker.isEnd)
    	{
    		boardChecker.count = 0;
    		boardChecker.board = new int[3,3]{ { -1,-1,-1 }, { -1,-1,-1 }, { -1,-1,-1 } };;
    		boardChecker.isEnd = false;
    		boardChecker.hideMsg();
            for(int i = 1; i <= 9; i++){
                btn = GameObject.Find(str_path+i);
                btn.GetComponent<Renderer>().material.color = Color.clear;
    	   }
    	}
    }
}
