using UnityEngine;
using System.Collections;

public class GameServices : BaseBehaviour 
{
  #region Singleton
  private static GameServices _instance;
  public static GameServices Instance 
  {
    get
    {
      if (_instance == null) 
      {
        _instance = GetManager<GameServices>("GameServices");
      }
      return _instance;
    }
  }
  #endregion

	#region Fields
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
  #endregion

  #region Public Methods
  #endregion

  #region BaseBehaviour Methods
  #endregion
}
