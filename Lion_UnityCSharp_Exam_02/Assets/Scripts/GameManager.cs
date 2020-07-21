using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string nextScene;
    public string lastScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(nextScene);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene(lastScene);
        }
        if (Input.GetKeyDown(KeyCode.P) && nextScene == "")
        {
            print("已經沒有下一頁囉~");
        }
        if (Input.GetKeyDown(KeyCode.O) && lastScene == "")
        {
            print("已經沒有上一頁囉~");
        }
    }
}
