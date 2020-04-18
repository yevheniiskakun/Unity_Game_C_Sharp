using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour
{
    GameObject start_button;
    void Start()
    {
        start_button = GameObject.Find("Start_Button");
    }
    
    public static bool start = false;

    void OnMouseDown(){
        start =  true;
        SceneManager.LoadScene("main");
    }

    void Update()
    {
        if (start == true)
        {
            start_button.SetActive(false);
        }
    }
}
