using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SmoothFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
    public float speed;
    public bool lookAt;
    public Slider sliderSpeed;

    void Start()
    {
        transform.position = player.transform.position + offset;
    }

    public void SetSpeed()
    {
        speed = sliderSpeed.value;
        Debug.Log("Speed = " + speed);
    }

    void Update()
    {
        speed = sliderSpeed.value;
        if (lookAt) transform.LookAt(player.transform.position);
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, speed);
    }
}