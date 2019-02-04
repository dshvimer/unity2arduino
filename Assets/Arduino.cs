using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Arduino : MonoBehaviour {

    const string PORTNAME = "/dev/tty.usbmodem14511";
    SerialPort stream;
    // Use this for initialization
    void Start()
    {
        stream = new SerialPort(PORTNAME, 57600, Parity.None, 8, StopBits.One);
        stream.Open();

    }
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        print("yo");
        stream.WriteLine("yo");
        stream.BaseStream.Flush();
    }
}
