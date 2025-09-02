using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCamaleon : MonoBehaviour
{
    //Public Attributes
    public float speed = 0f;
    public Material[] material;
    //Private Attributes
    private Renderer _rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement Keys
            //X Axis
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.left * Input.GetAxis("Horizontal") * Time.deltaTime * speed * -1);

            //Z Axis
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.forward * Time.deltaTime * speed * -1);

        //Color Changing Keys
        _rend = GetComponent<Renderer>();
        if (Input.GetKeyUp(KeyCode.Alpha1))
            _rend.material = material[0];
        if (Input.GetKeyUp(KeyCode.Alpha2))
            _rend.material = material[1];
        if (Input.GetKeyUp(KeyCode.Alpha3))
            _rend.material = material[2];
        if (Input.GetKeyUp(KeyCode.Alpha4))
            _rend.material = material[3];

    }
}
