﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

	public void scenario1()
	{
		SceneManager.LoadScene ("escenariouno");
	}

	public void scenario2()
	{
		SceneManager.LoadScene ("escenariodos");
	}

	public void scenario3()
	{
		SceneManager.LoadScene ("escenariotres");
	}


}
