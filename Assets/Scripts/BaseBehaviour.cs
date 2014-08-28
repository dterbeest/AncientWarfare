using UnityEngine;
using System.Collections;

public class BaseBehaviour : MonoBehaviour 
{
  protected bool _paused = false;
  private Transform __transform;
  protected Transform _transform 
  { 
    get 
    { 
      if (__transform == null) {
        __transform = transform;
      }
      return __transform; 
    }
  }
  public virtual void Awake() {}
  public virtual void Start() {}
  public virtual void Update() {}
  public virtual void OnGUI() {}
  public virtual void OnEnable() {}
  public virtual void OnDisable() {}
  public virtual void OnMouseEnter() {}
  public virtual void OnMouseOver() {}
  public virtual void OnMouseExit() {}
  public virtual void OnMouseDown() {}
  public virtual void OnMouseUp() {}
  public virtual void OnCollisionEnter(Collision collision) {}
  public virtual void OnCollisionStay(Collision collision) {}
  public virtual void OnCollisionExit(Collision collision) {}
  public virtual void OnTriggerEnter(Collider other) {}
  public virtual void OnTriggerStay(Collider other) {}
  public virtual void OnTriggerExit(Collider other) {}

  public virtual void OnPause() 
  {
    _paused = true;
  }
  public virtual void OnUnpause() 
  {
    _paused = false;
  }
}
