using UnityEngine;
using System.Collections;

public enum MoveTypes
{
  LeftRight,        //0
  RightLeft,        //1
  DownUp,           //2
  UpDown,           //3
  LowLeftUpRight,   //4
  LowRightUpLeft,   //5
  UpRightLowLeft,   //6
  UpLeftLowRight,   //7
  CentreStab        //8
}

public enum BlockAttackType
{
  Block,
  Attack
}


public class CombatAnimator : BaseBehaviour 
{
	#region Fields
  private Animator _animator;
  #endregion

  #region Properties
  #endregion

  #region Private Methods
  #endregion

  #region Public Methods
  public void StartMove(MoveTypes moveType, BlockAttackType blockAttackType)
  {
    Debug.Log("starting " + blockAttackType.ToString() + " move " + moveType.ToString());
    if (!_animator) {
      Debug.LogError("No animator!");
      _animator = GetComponent<Animator>();
      return;
    }
    _animator.SetInteger("AttackState", (int)moveType);
  }
  #endregion

  #region BaseBehaviour Methods
  public override void Start() {
    _animator = GetComponent<Animator>();
    if (!_animator) {
      Debug.LogError("No animator!");
    }
  }
  #endregion
}
