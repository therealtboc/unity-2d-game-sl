using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int _totalHearts;
    private int _collectedHearts;

    public TextMeshProUGUI heartCount;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _totalHearts = FindObjectsOfType<Coin>().Length;     //Not viable for larger implementations, think about calling from arrays
        DisplayHeartCount();
    }

    void DisplayHeartCount()
    {
        heartCount.SetText(_collectedHearts + " / " + _totalHearts);
        if(_collectedHearts == _totalHearts)
        {
            heartCount.SetText("All Hearts Collected!");
        }
    }

    public void HandleHeartCollected()
    {
        _collectedHearts++;
        DisplayHeartCount();
        if(_collectedHearts == _totalHearts)
        {
            //print("YOU DID IT!");
            SoundManager.Instance.PlayAllHeartCollectSound();
            YouWinMenu.Instance.Show();
        }
        //Play sound clip as assigned in SoundManager.cs
        SoundManager.Instance.PlayHeartCollectSound();
    }

   
    public void HandleAllHeartCollected()
    {
        _collectedHearts = _totalHearts;
        DisplayHeartCount();
        if (_collectedHearts == _totalHearts)
        {
            //print("YOU DID IT!");
            SoundManager.Instance.PlayAllHeartCollectSound();
            YouWinMenu.Instance.Show();
        }
        //Play sound clip as assigned in SoundManager.cs
        SoundManager.Instance.PlayHeartCollectSound();
    }
}
