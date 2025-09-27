using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{
    [SerializeField] float height;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector2((int)Random.Range(-12, 12), (int)Random.Range(-5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += height * Mathf.Sin(Mathf.PI * 2 * Time.time / speed) * Vector3.up;
    }
}
