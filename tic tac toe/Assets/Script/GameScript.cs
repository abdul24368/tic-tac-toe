using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int spriteindex = -1;
    public int PlayerTurn()
    {
        spriteindex++;
        return spriteindex % 2;
    }
}
