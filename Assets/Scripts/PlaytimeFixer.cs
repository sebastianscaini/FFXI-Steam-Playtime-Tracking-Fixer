using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class PlaytimeFixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Application.dataPath + @"\SquareEnix\PlayOnlineViewer\pol.exe");
        Process p = new Process();
        p.StartInfo.FileName = System.IO.Directory.GetParent(Application.dataPath) + @"\SquareEnix\PlayOnlineViewer\pol.exe";
        p.Start();
        //System.Diagnostics.Process.Start(Application.dataPath + @"\SquareEnix\PlayOnlineViewer\pol.exe");
    }
}
