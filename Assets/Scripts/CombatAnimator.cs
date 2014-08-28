using UnityEngine;
using System.Collections;

public enum MoveTypes
{
  LeftRight,
  RightLeft,
  DownUp,
  UpDown,
  LowLeftUpRight,
  LowRightUpLeft,
  UpRightLowLeft,
  UpLeftLowRight,
  CentreStab
}

public enum BlockAttackType
{
  Block,
  Attack
}


public class CombatAnimator : BaseBehaviour 
{
	#region Fields
  #endregion

  #region Properties
  #endregion

  #region Private Methods
  #endregion

  #region Public Methods
  public void StartMove(MoveTypes moveType, BlockAttackType blockAttackType)
  {
    Debug.Log("starting " + blockAttackType.ToString() + " move " + moveType.ToString());
  }
  #endregion

  #region BaseBehaviour Methods
  #endregion
}
