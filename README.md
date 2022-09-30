# Unity Smooth Follow with Lerp

Demo: https://markaelie.github.io/smoothfollow
<br>
Video: https://www.youtube.com/watch?v=Pyq96JsfiyA

```c#
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
```


<p align="center">
  <img width="820" height="600" src="https://github.com/markaelie/SmoothFollow-Unity/blob/master/DemoScreenshot.png?raw=true">
</p>
