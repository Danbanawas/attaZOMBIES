using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;


public class AnothaSave : MonoBehaviour
{
    public string filename = "testsaveing";
    public string foldername = "the test12";
    public Healthhandler healthhandler;

    public void saveTofile()
    {
        if(!Directory.Exists(foldername))
            Directory.CreateDirectory(foldername);
        BinaryFormatter formatter = new BinaryFormatter();  
        FileStream saveFile =File.Create(foldername+"/"+filename+".bin");
       formatter.Serialize(saveFile, healthhandler);
        saveFile.Close();
        print(Directory.GetCurrentDirectory().ToString());
            
    }
 

}
