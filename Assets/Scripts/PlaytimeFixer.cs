using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaytimeFixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Diagnostics.Process.Start(Application.dataPath + @"SquareEnix\PlayOnlineViewer\pol.exe");
    }
}
