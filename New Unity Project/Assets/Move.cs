using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float slowDownFactor = 0.85f;
    public static string slowLog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        slowLog = Time.timeScale.ToString();
        print(slowLog);
    }

}
