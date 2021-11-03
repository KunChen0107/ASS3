using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject manager;
    Button button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        scene=SceneManager.GetActiveScene();
        if(scene.buildIndex==1)
        {
            button=GameObject.FindWithTag("QuitButton").GetComponent<Button>();
            button.onClick.AddListener(QuitGame);
            // health=GameObject.FindWithTag("PlayerHealthBar").GetComponent<Image>();
            // player=GameObject.FindWithTag("Player").transform;
        }
        
    }
     public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
         GameObject.DontDestroyOnLoad(manager);
        SceneManager.sceneLoaded+=OnSceneLoaded;
    }
    public void QuitGame()
    {
       SceneManager.LoadScene(0);
    }
}
