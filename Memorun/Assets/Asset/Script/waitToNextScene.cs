using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitToNextScene : MonoBehaviour
{
    public int second;
    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(NewGame());
    }

    IEnumerator NewGame()
    {
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene(newGameScene);
    }
}
