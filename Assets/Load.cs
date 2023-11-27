using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class Load : MonoBehaviour
{
    public string fileName = "testsaveing";
    public string folderName = "the test12";
    public Healthhandler healthhandler;



    public void Loaddata()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream SaveFile = File.Open(folderName + "/" + fileName + ".bin", FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite);
        

        healthhandler = (Healthhandler)formatter.Deserialize(SaveFile);

        print(healthhandler.healthsys);

        print(healthhandler.healthsys);

        print(healthhandler.healthsys);

        SaveFile.Close();
    }
}
