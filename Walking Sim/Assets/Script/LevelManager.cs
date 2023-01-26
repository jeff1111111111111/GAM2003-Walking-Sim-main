using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Transform lastGoodCheckpoint;

    public Canvas infoBar;
    public Canvas messageBox;

    public Text messageTextonScreen;
    public Text statusText;
    public float timeOnScreen = 2.5f;

    private float timeComplete = 0;

    void Update()
    {
        if (timeComplete < Time.time)
        {
            messageBox.gameObject.SetActive(false);
        }
    }

    public void ShowMessage(string currentMessage)
    {
        messageTextonScreen.text = currentMessage;
        messageBox.gameObject.SetActive(true);
        timeComplete = Time.time + timeOnScreen;
    }
}
