  using UnityEngine;
  using System.Collections;
  
  public class UrlButton : MonoBehaviour
  {
      public void OpenURL()
      {
          Application.OpenURL("https://github.com/markaelie");
      }
  }