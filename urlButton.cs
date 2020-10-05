  using UnityEngine;
  using System.Collections;
  
  public class urlButton : MonoBehaviour
  {
      public void OpenURL()
      {
          Application.OpenURL("https://github.com/markaelie");
      }
  }