using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCube : MonoBehaviour
{
    //Public Attributes
    public float speed = 0f;
    //Private Attributes
    public float minScale = 0.1f;
    public float maxScale = 9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Sphere"))
        {
            collision.gameObject.SetActive(false);
            float escala = Random.Range(minScale, maxScale);
            transform.localScale = new Vector3(escala, escala, escala);
        }
    }

    void Update()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.right * Time.deltaTime * speed * -1);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * Time.deltaTime * speed * -1);

    }
}
