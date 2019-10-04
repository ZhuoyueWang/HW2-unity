using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runButton4 : MonoBehaviour, OnTouch3D
{
    public Text messageText;
    void Start()
    {
        boardChecker b = new boardChecker();
    }

    void Update()
    {

    }
    public void OnTouch()
    {
		if(boardChecker.isFilled(1,0))
		{
			boardChecker.count++;
            boardChecker.board[1,0] = boardChecker.count % 2 == 0? 0 : 1;
			gameObject.GetComponent<Renderer>().material.color = boardChecker.board[1,0] == 1? Color.red: Color.blue;

            if(boardChecker.anyoneWins(1,0))
            {
                Color textcolor = boardChecker.board[1,0] == 1? Color.red: Color.blue;
                boardChecker.isEnd = true;
                messageText.gameObject.SetActive(true);
                if(boardChecker.board[1,0] == 1){
                    messageText.text = "Red Wins";
                }
                else
                {
                   messageText.text = "Blue Wins";
                }
            }
            else
            {
                if (boardChecker.count == 9)
                {
                    boardChecker.isEnd = true;
                    messageText.gameObject.SetActive(true);
                    messageText.text = "Draw";
                }
            }
		}
    }
}
