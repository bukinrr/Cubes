using System;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Text timeText, countPokeText, resetButtonText;
    [SerializeField] private Text countTime, countPoke ;
    [SerializeField] private Construction figure;
    private double _variableTime;
    private int _variableCrush;

    private void Awake()
    {
        timeText.text = "Времени прошло";
        countPokeText.text = "Столкновений:";
        resetButtonText.text = "Сбросить счетчики";
    }

    internal void ShowTime()
    {
        _variableTime += Time.deltaTime;
        countTime.text = Math.Round(_variableTime).ToString();
    }

    internal void ShowCountCrush()
    {
        _variableCrush = figure.CountPoke;
        countPoke.text = _variableCrush.ToString();
    }

    private void ResetCount()
    {   
        _variableTime = 0;
        figure.CountPoke = 0;
    }
}