using UnityEngine;
using System.Collections;

public class GameServices : MonoBehaviour 
{
  #region Singleton
  private static GameServices _instance;
  public static GameServices Instance 
  {
    get
    {
      if (_instance == null) 
      {
        _instance = GetManager<GameServices>("GameServices") as GameServices;
      }
      return _instance;
    }
  }
  #endregion

	#region Fields
  private bool _paused = false;
  private float _orgTimeScale;
  #endregion

  #region Properties
  #endregion

  #region Private Methods
  private static T GetManager<T>(string objName) where T: Component
  {
    GameObject go = GameObject.Find(objName);
    if (go == null)
    {
      go = new GameObject(objName);
    }
    T t = go.GetComponent(typeof(T)) as T;
    if (t==null)
    {
      t = go.AddComponent(typeof(T)) as T;
    }
    return t;
  }

  private void Pause() 
  {
    _paused = !_paused;
    if (_paused)
    {
      _orgTimeScale = Time.timeScale;
      Time.timeScale = 0;
      BaseBehaviour[] bs = GameObject.FindObjectsOfType(typeof(BaseBehaviour)) as BaseBehaviour[];
      foreach (BaseBehaviour bb in bs)
      {
        bb.OnPause();
      }
    } 
    else
    {
      Time.timeScale = _orgTimeScale;
      BaseBehaviour[] bs = GameObject.FindObjectsOfType(typeof(BaseBehaviour)) as BaseBehaviour[];
      foreach (BaseBehaviour bb in bs) 
      {
        bb.OnUnpause();
      }
    }
  }
  #endregion

  #region Public Methods
  #endregion

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape)) 
    {
      Pause();
    }
  }
}
