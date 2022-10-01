# Unity Smooth Follow with Lerp

Demo: https://markulie.github.io/smoothfollow.html
<br>
Video: https://www.youtube.com/watch?v=Pyq96JsfiyA

```c#
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SphereCollider))]
public class SmoothFollow : MonoBehaviour
{
    public GameObject follower;
    public Vector3 followerOffset = new Vector3(0, 0, 0);
    public Slider sliderSpeed;
    public Toggle lookAt;
    public float speed;
    private Vector3 screenPoint;
    private Vector3 offset;

    private void Start()
    {
        follower.transform.position = transform.position + followerOffset;
    }

    private void Update()
    {
        speed = sliderSpeed.value;
        follower.transform.position = Vector3.Lerp(follower.transform.position, transform.position + followerOffset, speed);
        if (lookAt.isOn) follower.transform.LookAt(transform.position);
    }

    private void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
```


<p align="center">
  <img width="820" height="600" src="https://github.com/markaelie/SmoothFollow-Unity/blob/master/DemoScreenshot.png?raw=true">
</p>
