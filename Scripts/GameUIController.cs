using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    //public static bool firstGnomAlive = true;
    //public static bool secondGnomAlive = true;
    //public static bool thirdGnomAlive = true;

    public GameObject AliveLife1G;
	public GameObject AliveLife2G;
	public GameObject AliveLife3G;

	public GameObject[] MenuUI = new GameObject[2];
	public GameObject[] PlayUI = new GameObject[7];

    

	void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        OnOff(MenuUI, false);
		OnOff(PlayUI, true);
	}

    public void OnOff(GameObject[] nameArray, bool action)
    {
        for (int i = 0; i < nameArray.Length; i++)
        {
			foreach (GameObject GroupsUI in nameArray)
			{
				//int i = 0;
				nameArray[i].SetActive(action);
				//i++;
			}
		}
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
			OnOff(MenuUI, true);
			OnOff(PlayUI, false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			FirstGnomDed();
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			SecondGnomDed();
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			ThirdGnomDed();
		}
	}

    public void BackToGame()
    {
		Cursor.lockState = CursorLockMode.Locked;
		OnOff(MenuUI, false);
		OnOff(PlayUI, true);
	}

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void FirstGnomDed()
    {
        //AliveLife1G.SetActive(false);
		Destroy(AliveLife1G);
    }
	public void SecondGnomDed()
	{
		Destroy(AliveLife2G);
	}
	public void ThirdGnomDed()
	{
		Destroy(AliveLife3G);
	}



}
