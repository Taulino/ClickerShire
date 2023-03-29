using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StayAlive : MonoBehaviour

{
    public int ClickCounter = 0;
    public Text myText;
     //public Animator myAnimator;
    public Button myButton;
    public RectTransform myRectTransform;

   void Awake()
    {
        //myAnimator = GetComponent<Animator>();
        myButton = GetComponent<Button>();
        myText = GetComponent<Text>();

    }

    void Start()
    {
        
    }
    

  
    void Update()
    {
        myButton.onClick.AddListener(TaskOnClick);
    }
    public void  TaskOnClick()
    {
        myRectTransform.position = new Vector3(Random.Range(-2.1f,2.5f), Random.Range(-4.5f,4.5f),0);
        ClickCounter += 1;
    }

}
