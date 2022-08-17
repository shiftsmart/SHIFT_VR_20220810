using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class spawnBasketball : MonoBehaviour
{
    [SerializeField, Header("�x�y�w�s��")]
    private GameObject goBasketball;
    private UIElement btnSpawnBasketball;
    private Transform traPlayer;


    private void Awake()
    {
        traPlayer = GameObject.Find("Player").transform;

        btnSpawnBasketball = GameObject.Find("�ͦ��x�y").GetComponent<UIElement>();

        btnSpawnBasketball.onHandClick.AddListener((x)=>
        {
            Vector3 posBall = traPlayer.position + traPlayer.forward * 0.8f + traPlayer.up;
            Instantiate(goBasketball, posBall, Quaternion.identity);
        });
    }

}
