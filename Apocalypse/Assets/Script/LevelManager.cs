using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
 	public void Apocalypse(){

		SceneManager.LoadScene("Apocalypse");
	}

    public void Board(){
        SceneManager.LoadScene("Board");


    }

    public void Room(){
        SceneManager.LoadScene("Room");

    }

    public void Menu(){

        SceneManager.LoadScene("Menu");

    }
    public void GameOver(){

        SceneManager.LoadScene("GameOver");

    }

    public void GameOverCarv(){
        SceneManager.LoadScene("GameOverCarv");


    }

    public void ShootCarv(){
        SceneManager.LoadScene("ShootCarv");

    }
    public void CrazyFans(){
        SceneManager.LoadScene("CrazyFans");

    }

     public void CrazyFansMenu(){
        SceneManager.LoadScene("CrazyFansMenu");

    }

     public void CrazyFansControls(){
        SceneManager.LoadScene("CrazyFansControls");

    }

    
}
