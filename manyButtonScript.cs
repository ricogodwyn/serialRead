using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class manyButtonScript : MonoBehaviour
{
    SerialPort serialPort = new SerialPort("COM13", 9600);
    // Start is called before the first frame update
    void Start()
    {
        if (!serialPort.IsOpen)
        {
            serialPort.Open();
            serialPort.ReadTimeout = 1000;
            Debug.Log("ready");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (serialPort.IsOpen)
        {
            try
            {
                string data = serialPort.ReadLine();
                Debug.Log(data);
            }
            catch (System.Exception)
            {

            }
        }
    }
    void OnApplicationQuit()
    {
        if (serialPort.IsOpen)
        {
            serialPort.Close();
        }
    }
}
