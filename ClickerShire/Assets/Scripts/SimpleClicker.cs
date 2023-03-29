using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SimpleClicker : MonoBehaviour
{
    private int highestCount = 0;
    private int count = 0;
    private float time = -5;
    public Text text;
    public Text text1;
    private void UpdateUI()
    {
        text.text = "Count: " + count;
        text1.text = "Highest score: " + highestCount;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 0.2f) EndTheGame();
    }
    public void Click()
    {
        count++;
        time = 0;
        UpdateUI();
    }
    private void EndTheGame()
    {
        if (count > highestCount) highestCount = count;
        time = -5;
        count = 0;
        UpdateUI();
    }
}
