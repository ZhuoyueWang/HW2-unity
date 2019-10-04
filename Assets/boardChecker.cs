using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boardChecker : MonoBehaviour
{
    public static int count = 0;
    public static int[,]board = new int[3,3]{ { -1,-1,-1 }, { -1,-1,-1 }, { -1,-1,-1 } };
    public static bool isEnd = false;

    void Start()
    {
    
    }

    void Update()
    {

    }
    public static bool isFilled(int x, int y)
    {
        if(board[x,y] != 1 && board[x,y] != 0)
            return true;
        else
            return false;
    }

    public static bool anyoneWins(int x, int y)
    {
        if(x == 0 && y == 0){
            if((board[0,0] ==board[0,1] &&board[0,1] ==board[0,2])||
                (board[0,0] ==board[1,0] &&board[1,0] ==board[2,0])||
                (board[0,0] ==board[1,1] &&board[1,1] ==board[2,2]))
                return true;
        } else if(x == 0 && y == 1){
            if((board[0,0] == board[0,1] && board[0,1] == board[0,2])||
                (board[0,1] == board[1,1] && board[1,1] == board[2,1]))
                return true;
        } else if(x == 0 && y == 2){
            if((board[0,0] == board[0,1] && board[0,1] == board[0,2])||
                (board[0,2] == board[1,2] && board[1,2] == board[2,2])||
                (board[0,2] == board[1,1] && board[1,1] == board[2,0]))
                return true;
        } else if(x == 1 && y == 0){
            if((board[0,0] == board[1,0] && board[1,0] == board[2,0])||
                (board[1,0] == board[1,1] && board[1,1] == board[1,2]))
                return true;
        } else if(x == 1 && y == 1){
            if((board[0,0] == board[1,1] && board[1,1] == board[2,2])||
                (board[0,2] == board[1,1] && board[1,1] == board[2,0])||
                (board[1,0] == board[1,1] && board[1,1] == board[1,2])||
                (board[0,1] == board[1,1] && board[1,1] == board[2,1]))
                return true;
        } else if (x==1 && y==2){
            if((board[0,2] == board[1,2] && board[1,2] == board[2,2])||
                (board[1,0] == board[1,1] && board[1,1] == board[1,2]))
                return true;
        } else if (x== 2 && y == 0){
    		if((board[0,0] == board[1,0] && board[1,0] == board[2,0])||
			(board[2,0] == board[2,1] && board[2,1] == board[2,2])||
			(board[2,0] == board[1,1] && board[1,1] == board[0,2]))
                return true;
        } else if (x == 2 && y == 1){
            if((board[2,0] == board[2,1] && board[2,1] == board[2,2])||
			(board[0,1] == board[1,1] && board[1,1] == board[2,1]))
                return true;
        } else if (x==2 && y==2){
            if((board[2,0] == board[2,1] && board[2,1] == board[2,2])||
                (board[0,2] == board[1,2] && board[1,2] == board[2,2])||
                (board[0,0] == board[1,1] && board[1,1] == board[2,2]))
                return true;
        } else{
            return false;
        }
        return false;
    }

    public static void hideMsg()
    {

    }
}
