using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttondirections : MonoBehaviour
{
    public Pacman pacman;

    public void QuitGame()
    {
        // x 12 / 13 y -14  / -16

        if (pacman.transform.position.x > 12 && pacman.transform.position.x < 13 && pacman.transform.position.y < -14 && pacman.transform.position.y > -16)
        {
            if(pacman.movement.direction == Vector2.down)
            {
                Application.Quit();
                print("Oyundan çiktik");
            }
        }
    }
    public void UpDirect()
    {
        pacman.movement.SetDirection(Vector2.up);
    }
    public void DownDirect()
    {
        pacman.movement.SetDirection(Vector2.down);
    }
    public void RightDirect()
    {
        pacman.movement.SetDirection(Vector2.right);
    }
    public void LeftDirect()
    {
        pacman.movement.SetDirection(Vector2.left);
    }

}
