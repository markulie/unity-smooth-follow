  using UnityEngine;
  using System.Collections;
  
  public class UrlButton : MonoBehaviour
  {
    public string url;

      public void OpenURL()
      {
          Application.OpenURL(url);
      }
  }