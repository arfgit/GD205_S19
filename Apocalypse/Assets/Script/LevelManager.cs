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


    
}
