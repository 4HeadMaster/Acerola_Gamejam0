using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TowersScript [] towers;

    public GlobScript glob;


    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        ResetState();
    }

    private void ResetState ()
    {
        this.glob.ResetState();
    }
}
