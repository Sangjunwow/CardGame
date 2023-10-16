using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//치트, UI, 랭킹, 게임오버
public class GameManager : MonoBehaviour
{
    public static GameManager Inst { get; private set; }
    private void Awake() => Inst = this;

    private void Start()
    {
        StartGame();    
    }


    private void Update()
    {
#if UNITY_EDITOR
        InputCheatKey();
#endif

    }

    private void InputCheatKey()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
            TurnManager.OnAddCard?.Invoke(true);
        if (Input.GetKeyDown(KeyCode.Keypad2))
            TurnManager.OnAddCard?.Invoke(false);
    }
    private void StartGame()
    {
        StartCoroutine(TurnManager.Inst.StartGameCo());
    }
}
