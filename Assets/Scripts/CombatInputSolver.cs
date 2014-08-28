using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CombatAnimator))]
public class CombatInputSolver : BaseBehaviour 
{
	#region Fields
  private Vector3 _startingPos;
  private Vector3 _endPos;
  private CombatAnimator _combatAnimator;
  private BlockAttackType _currentAttackType;

  public float horizontalMargin = 1;      //decides how much horizontal movement will be ignored
  public float verticalMargin = 1;        //decides how much vertical movement will be ignored
  #endregion

  #region Properties
  #endregion

  #region Private Methods
  private void StartSolve()
  {
    _startingPos = Input.mousePosition;
  }
  private void FinalizeSolve() 
  {
    _endPos = Input.mousePosition;
    Vector3 dir = _endPos - _startingPos;
    MoveTypes mType;
    float negHM = -horizontalMargin;
    float negVM = -verticalMargin;
    bool movedRight = (dir.x > horizontalMargin);
    bool movedLeft = (dir.x < negHM);
    bool movedDown = (dir.y < negVM);
    bool movedUp = (dir.y > verticalMargin);
    if (movedRight) {
      if (movedUp) {
        mType = MoveTypes.LowLeftUpRight;
      } else if (movedDown) {
        mType = MoveTypes.UpLeftLowRight;
      } else {
        mType = MoveTypes.LeftRight;
      }
    } else if (movedLeft) {
      if (movedUp) {
        mType = MoveTypes.LowRightUpLeft;
      } else if (movedDown) {
        mType = MoveTypes.UpRightLowLeft;
      } else {
        mType = MoveTypes.RightLeft;
      }
    } else if (movedUp) {
      mType = MoveTypes.DownUp;
    } else if (movedDown) {
      mType = MoveTypes.UpDown;
    } else {
      mType = MoveTypes.CentreStab;
    }
    Debug.Log(mType.ToString() + " : " + dir.ToString());
    _combatAnimator.StartMove(mType, _currentAttackType);
  }
  #endregion

  #region Public Methods
  #endregion

  #region BaseBehaviour Methods
  public override void Start() 
  {
    _combatAnimator = GetComponent<CombatAnimator>();
  }
  public override void Update() 
  {
    if (Input.GetMouseButtonDown(0))
    {
      _currentAttackType = BlockAttackType.Attack;
      StartSolve();
    }
    if (Input.GetMouseButtonUp(0))
    {
      FinalizeSolve();
    }
    if (Input.GetMouseButtonDown(1))
    {
      _currentAttackType = BlockAttackType.Block;
      StartSolve();
    }
    if (Input.GetMouseButtonUp(1))
    {
      FinalizeSolve();
    }

  }
  #endregion
}
