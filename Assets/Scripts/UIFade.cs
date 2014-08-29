using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIFade : BaseBehaviour 
{
	#region Fields
  public Image image;

  private float _fadeTime = 1;
  private bool _fadingOut = false;
  private bool _fadingIn = false;
  #endregion

  #region Properties
  #endregion

  #region Private Methods
  #endregion

  #region Public Methods
  public void StartFadeOut(float fadeTime)
  {
    Debug.LogWarning("starting fade @" + Time.time.ToString());
    _fadeTime = fadeTime;
    _fadingOut = true;
  }
  #endregion

  #region BaseBehaviour Methods
  public override void Update() 
  {
    Color c = image.color;
    if (_fadingOut)
    {
      c.a = Mathf.Lerp(c.a, 0, _fadeTime * Time.deltaTime);
      if (c.a < 2)
      {
        _fadingOut = false;
        c.a = 0;
        Debug.LogWarning("fade done @" + Time.time.ToString());
      }
    }
    if (_fadingIn)
    {
      c.a = Mathf.Lerp(c.a, 255, _fadeTime * Time.deltaTime);
      if (c.a > 253)
      {
        _fadingIn = false;
        c.a = 255;
      }
    }
    image.color = c;
  }
  #endregion
}
