using AtomServer.Domain;
using UnityEngine;
using AtomClient;

public class Test : MonoBehaviour
{
    void Start()
    {
        Class1 class1 = new Class1();
        Client atomClient = new Client();
        Debug.Log(atomClient.Init());
    }

    void Update()
    {
        
    }
}
