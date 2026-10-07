using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] string myName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello " + myName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
