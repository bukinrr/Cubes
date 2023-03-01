using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Construction figureOne;
    [SerializeField] private Construction figureTwo;
    private UI _ui;

    private void Awake()
    {
        _ui = FindObjectOfType<UI>();
    }

    private void Update()
    {
        _ui.ShowTime();
        _ui.ShowCountCrush();
    }

    private void FixedUpdate()
    {
        figureOne.AttractionTarget();
        figureTwo.AttractionTarget();
    }
}