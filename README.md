# Smooth Follow with Lerp for Unity

```c#
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
```

<p align="center">
  <img width="820" height="auto" src="https://github.com/markulie/SmoothFollow-Unity/blob/master/DemoScreenshot.png?raw=true">
</p>
