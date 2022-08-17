 
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class SceneControl : MonoBehaviour
{

    private UIElement uiReplay;
    private UIElement uiQuit;
    private string nameSceneToReplay = "SampleScene";


    private void Awake()
    {
        uiReplay = GameObject.Find("replay").GetComponent<UIElement>();
        uiQuit = GameObject.Find("quit").GetComponent<UIElement>();

        uiReplay.onHandClick.AddListener((UnityAction)=> { SceneManager.LoadScene(nameSceneToReplay); });
        uiQuit.onHandClick.AddListener((UnityAction)=> { Application.Quit(); });
    }


}
