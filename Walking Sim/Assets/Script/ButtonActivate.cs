using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour
{
    public bool bl_activate = false;
    public GameObject objectToActivate;

    private bool bl_canActivate = false;
    private LevelManager currentLevelManager;

    void Start()
    {
        GameObject go = GameObject.Find("LevelManager");
        currentLevelManager = go.GetComponent<LevelManager>();
    }

    void Update()
    {
        if (Input.GetKeyUp("e") && bl_canActivate)
        {
            bl_canActivate = !bl_activate;
            objectToActivate.SetActive(!bl_activate);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bl_canActivate = true;
            currentLevelManager.ShowMessage("Press E to touch the stone");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bl_canActivate = false;
        }
    }
}
