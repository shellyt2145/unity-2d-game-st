using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;


    private int _totalDankWeed;
    private int _collectedDankWeed;

    public TextMeshProUGUI DankWeedCount;


    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _totalDankWeed = FindObjectsOfType<Collectible>().Length;
        DisplayDankWeedCount();

    }

    void DisplayDankWeedCount()
    {
        DankWeedCount.SetText(_totalDankWeed + " / " + _collectedDankWeed);
    }

    public void Handledankweedcollected()
    {
        _collectedDankWeed++;
        DisplayDankWeedCount();
        if(_collectedDankWeed == _totalDankWeed)
        {
            YouWinMenu.Instance.Show();
            SoundManager.Instance.PlayyouWinSound();
        }

        else
        {
            SoundManager.Instance.PlayCoinCollectSound();
        }
        

    }
  
  
}
