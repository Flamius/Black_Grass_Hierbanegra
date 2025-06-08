using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStart()
    {
        StartCoroutine (SceneUp());  
    }
    public void SceneDown()
    {
        index -= 1;
        SceneManager.LoadScene(index);
    }
    public IEnumerator SceneUp()
    {
        float delay = 0.35f;
        yield return new WaitForSeconds(delay);
        index += 1;
        SceneManager.LoadScene(index);
    }
    public void ExitGame()
    {
        Debug.Log("You closed the game");
        Application.Quit();
    }

}
