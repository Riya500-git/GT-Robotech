using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class TestConnection : MonoBehaviour {

    SerialPort data_stream = new SerialPort("COM4", 19200);
    public string receivedstring;
    public GameObject test_data;
    public Rigidbody rb;
    public float sensitivity = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        data_stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        receivedstring = data_stream.ReadLine();
        //split the data between ','
        string[] datas = receivedstring.Split(',');
        rb.AddForce(0, 0, float.Parse(datas[0]) * sensitivity * Time.deltaTime, ForceMode.VelocityChange);
        rb.AddForce(float.Parse(datas[1]) * sensitivity * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

    }
}
