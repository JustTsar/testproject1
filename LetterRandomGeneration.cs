using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterRandomGeneration : MonoBehaviour
{
    [SerializeField] private TMP_Text[] _blocksForLetter;
    [SerializeField] private GameObject[] _blocksPosition;
    private Vector3 _randomPosition;
    private int _randomIndex;
    private void Start()
    {
        RandomGeneration();
    }

    public void RandomGeneration()
    {
        char[] randomLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        for (int i = 0; i < _blocksForLetter.Length; i++)
        {
            _blocksForLetter[i].text = randomLetter[Random.Range(0, randomLetter.Length)].ToString();
        }
    }   

    public void Mix()
    {
        for (int i = 0; i < _blocksPosition.Length; i++)
        {
            _randomPosition = _blocksPosition[i].transform.position;
            _randomIndex = Random.Range(0, _blocksPosition.Length);
            _blocksPosition[i].transform.position = _blocksPosition[_randomIndex].transform.position;
            _blocksPosition[_randomIndex].transform.position = _randomPosition;
        }

    }
}


