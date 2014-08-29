// Tim Tryzbiak - ootii, LLC

using System;
using System.Collections.Generic;
using UnityEngine;
using com.ootii.Cameras;
using com.ootii.Helpers;
using com.ootii.Input;
using com.ootii.Utilities.Debug;

namespace com.ootii.AI.Controllers
{
    /// <summary>
    /// Character controller built specifically for the
    /// Adventure Camera Rig. 
    /// </summary>
    public class AdventureController : Controller
    {
        /// <summary>
        /// Keeps us from having to reallocate over and over
        /// </summary>
        private static Vector3 sVector3A = new Vector3();

        /// <summary>
        /// Offset from the controller's root position that the camera
        /// is attempting to follow. Typically this is the head or eye height.
        /// </summary>
        public Vector3 _CameraRigOffset = Vector3.zero;
        public Vector3 CameraRigOffset
        {
            get { return _CameraRigOffset; }
            set { _CameraRigOffset = value; }
        }

        /// <summary>
        /// Lerp factor for determining how quickly the camera follows
        /// the avatar as it goes up (typically in a jump)
        /// </summary>
        public float _CameraRigLerp = 0.1f;
        public float CameraRigLerp
        {
            get { return _CameraRigLerp; }
            set { _CameraRigLerp = value; }
        }

        /// <summary>
        /// This is the position that the camera is attempting to move
        /// towards. It's the default position of the camera.
        /// </summary>
        protected Vector3 mCameraRigAnchor = Vector3.zero;
        public override Vector3 CameraRigAnchor
        {
            get
            {
                Vector3 lAnchor = transform.position + _CameraRigOffset;

                // The lerp factor provides a smooth jump up with a harder fall
                float lLerpFactor = (mCameraRigAnchor.y < lAnchor.y ? _CameraRigLerp : 1.0f);

                mCameraRigAnchor.x = lAnchor.x;
                mCameraRigAnchor.y = Mathf.Lerp(mCameraRigAnchor.y, lAnchor.y, lLerpFactor);
                mCameraRigAnchor.z = lAnchor.z;

                return mCameraRigAnchor;
            }
        }

        /// <summary>
        /// Radius of the collider surrounding the controller
        /// </summary>
        public override float ColliderRadius
        {
            get { return mCharController.radius; }
        }

        /// <summary>
        /// Determines if we apply gravity to the controller
        /// </summary>
        public bool _UseGravity = true;
        public bool UseGravity
        {
            get { return _UseGravity; }
            set { _UseGravity = value; }
        }

        /// <summary>
        /// Determines if the controller can go into the stance
        /// </summary>
        public bool _MeleeStanceEnabled = true;
        public bool MeleeStanceEnabled
        {
            get { return _MeleeStanceEnabled; }
            set { MeleeStanceEnabled = value; }
        }

        /// <summary>
        /// Determines if the controller can go into the stance
        /// </summary>
        public bool _TargetingStanceEnabled = true;
        public bool TargetingStanceEnabled
        {
            get { return _TargetingStanceEnabled; }
            set { _TargetingStanceEnabled = value; }
        }

        /// <summary>
        /// Degrees per second to rotate the player when in the
        /// targeting stance
        /// </summary>
        public float _TargetingStanceRotationSpeed = 90f;
        public float TargetingStanceRotationSpeed
        {
            get { return _TargetingStanceRotationSpeed; }
            set { _TargetingStanceRotationSpeed = value; }
        }

        /// <summary>
        /// Max speed multiplier to apply when in the targeting
        /// stance
        /// </summary>
        [HideInInspector]
        public float _TargetingStanceMovementSpeedMultiplier = 1.0f;
        public float TargetingStanceMovementSpeedMultiplier
        {
            get { return _TargetingStanceMovementSpeedMultiplier; }
            set { _TargetingStanceMovementSpeedMultiplier = value; }
        }

        /// <summary>
        /// The current stance of the player
        /// </summary>
        [HideInInspector]
        protected int mStance = EnumControllerMode.TRAVERSAL;
        public int Stance
        {
            get { return mStance; }
            set { mStance = value; }
        }

        /// <summary>
        /// Animator that the controller works with
        /// </summary>
        [HideInInspector]
        protected Animator mAnimator = null;
        public Animator Animator
        {
            get { return mAnimator; }
        }

        /// <summary>
        /// The current state of the controller including speed, direction, etc.
        /// </summary>
        protected ControllerState mState = new ControllerState();
        public ControllerState State
        {
            get { return mState; }
            set { mState = value; }
        }

        /// <summary>
        /// The previous state of the controller including speed, direction, etc.
        /// </summary>
        protected ControllerState mPrevState = new ControllerState();
        public ControllerState PrevState
        {
            get { return mPrevState; }
            set { mPrevState = value; }
        }

        /// <summary>
        /// Angles at which we limit forward rotation
        /// </summary>
        protected float mForwardHeadingLimit = 80f;
        public float ForwardHeadingLimit
        {
            get { return mForwardHeadingLimit; }
            set { mForwardHeadingLimit = value; }
        }

        /// <summary>
        /// Angles at which we limit backward rotation
        /// </summary>
        protected float mBackwardsHeadingLimit = 50f;
        public float BackwardsHeadingLimit
        {
            get { return mBackwardsHeadingLimit; }
            set { mBackwardsHeadingLimit = value; }
        }

        /// <summary>
        /// Current animator state
        /// </summary>
        protected AnimatorStateInfo mStateInfo;

        /// <summary>
        /// Current animator transition
        /// </summary>
        protected AnimatorTransitionInfo mTransitionInfo;

        /// <summary>
        /// This state is used to gather the current state information. We don't set it
        /// in the 'mState' property until we've cleaned it up and are done with it. This
        /// property is meant to be temporary.
        /// </summary>
        protected ControllerState mTempState = new ControllerState();

        /// <summary>
        /// The speed value when the trend started. This way we can
        /// measure overall acceleration or deceleration
        /// </summary>
        private float mSpeedTrendStart = 0f;

        /// <summary>
        /// The current speed trend decreasing, static, increasing (-1, 0, or 1)
        /// </summary>
        private int mSpeedTrendDirection = EnumSpeedTrend.CONSTANT;

        /// <summary>
        /// Add a delay before we update the mecanim parameters. This way we can
        /// give a chance for things like speed to settle.
        /// </summary>
        private float mMecanimUpdateDelay = 0f;

        /// <summary>
        /// Track the last stance so we can go back to it
        /// </summary>
        private int mPrevStance = EnumControllerMode.TRAVERSAL;

        /// <summary>
        /// Track the last camera mode so we can go back to it
        /// </summary>
        private int mPrevRigMode = EnumCameraMode.THIRD_PERSON_FOLLOW;

        /// <summary>
        /// Angle we'll use to rotate the player through code
        /// </summary>
        private float mYAxisRotationAngle = 0;

        /// <summary>
        /// Unity character controller that is our base
        /// </summary>
        private CharacterController mCharController = null;
        public CharacterController CharController
        {
            get { return mCharController; }
        }

        /// <summary>
        /// Velocity created by the root motion of animation
        /// </summary>
        private Vector3 mRootMotionVelocity = Vector3.zero;

        /// <summary>
        /// Rotational velocity created by the root motion of animation
        /// </summary>
        private Quaternion mRootMotionAngularVelocity = Quaternion.identity;

        /// <summary>
        /// Accumulated velocity due to gravity's acceleration
        /// </summary>
        private Vector3 mGravitationalVelocity = Vector3.zero;

        /// <summary>
        /// State ids representing "locomotion"
        /// </summary>
        protected int mForwardIdle2WalkStateID = 0;
        protected int mForwardIdle2JogStateID = 0;
        protected int mForwardIdle2RunStateID = 0;
        protected int mForwardWalkStateID = 0;
        protected int mForwardJogStateID = 0;
        protected int mForwardRunStateID = 0;
        protected int mForwardWalk2IdleStateID = 0;
        protected int mForwardJog2IdleStateID = 0;
        protected int mForwardRun2IdleStateID = 0;
        protected int mForwardRun2BJogStateID = 0;

        protected int mForwardRun2RunLeft135TransitionID = 0;
        protected int mForwardRunLeft135StateID = 0;
        protected int mForwardRunLeft1352RunTransitionID = 0;
        protected int mForwardRun2RunLeft180TransitionID = 0;
        protected int mForwardRunLeft180StateID = 0;
        protected int mForwardRunLeft1802RunTransitionID = 0;
        protected int mForwardRun2RunRight135TransitionID = 0;
        protected int mForwardRunRight135StateID = 0;
        protected int mForwardRunRight1352RunTransitionID = 0;
        protected int mForwardRun2RunRight180TransitionID = 0;
        protected int mForwardRunRight180StateID = 0;
        protected int mForwardRunRight1802RunTransitionID = 0;

        protected int mBackwardsIdle2WalkStateID = 0;
        protected int mBackwardsIdle2JogStateID = 0;
        protected int mBackwardsWalkStateID = 0;
        protected int mBackwardsJogStateID = 0;
        protected int mBackwardsWalk2IdleStateID = 0;
        protected int mBackwardsJog2IdleStateID = 0;

        protected int mSidewaysIdle2WalkLeftStateID = 0;
        protected int mSidewaysWalkLeftStateID = 0;
        protected int mSidewaysWalkLeft2IdleStateID = 0;
        protected int mSidewaysIdle2WalkRightStateID = 0;
        protected int mSidewaysWalkRightStateID = 0;
        protected int mSidewaysWalkRight2IdleStateID = 0;

        /// <summary>
        /// Called right before the first frame update
        /// </summary>
        public void Start()
        {
            // Grab the character controller we are tied to
            mCharController = GetComponent<CharacterController>();

            // Load the animator and grab all the state info
            mAnimator = GetComponent<Animator>();

            mForwardIdle2WalkStateID = Animator.StringToHash("Forward-SM.Idle2Walk");
            mForwardIdle2JogStateID = Animator.StringToHash("Forward-SM.Idle2Jog");
            mForwardIdle2RunStateID = Animator.StringToHash("Forward-SM.Idle2Run");
            mForwardWalkStateID = Animator.StringToHash("Forward-SM.WalkForward");
            mForwardJogStateID = Animator.StringToHash("Forward-SM.JogForward");
            mForwardRunStateID = Animator.StringToHash("Forward-SM.RunForward");
            mForwardWalk2IdleStateID = Animator.StringToHash("Forward-SM.Walk2Idle");
            mForwardJog2IdleStateID = Animator.StringToHash("Forward-SM.Jog2Idle");
            mForwardRun2IdleStateID = Animator.StringToHash("Forward-SM.Run2Idle");

            mForwardRun2RunLeft135TransitionID = Animator.StringToHash("Forward-SM.RunForward -> Forward-SM.RunLeft135");
            mForwardRunLeft135StateID = Animator.StringToHash("Forward-SM.RunLeft135");
            mForwardRunLeft1352RunTransitionID = Animator.StringToHash("Forward-SM.RunLeft135 -> Forward-SM.RunForward");
            mForwardRun2RunLeft180TransitionID = Animator.StringToHash("Forward-SM.RunForward -> Forward-SM.RunLeft180");
            mForwardRunLeft180StateID = Animator.StringToHash("Forward-SM.RunLeft180");
            mForwardRunLeft1802RunTransitionID = Animator.StringToHash("Forward-SM.RunLeft180 -> Forward-SM.RunForward");
            mForwardRun2RunRight135TransitionID = Animator.StringToHash("Forward-SM.RunForward -> Forward-SM.RunRight135");
            mForwardRunRight135StateID = Animator.StringToHash("Forward-SM.RunRight135");
            mForwardRunRight1352RunTransitionID = Animator.StringToHash("Forward-SM.RunRight135 -> Forward-SM.RunForward");
            mForwardRun2RunRight180TransitionID = Animator.StringToHash("Forward-SM.RunForward -> Forward-SM.RunRight180");
            mForwardRunRight180StateID = Animator.StringToHash("Forward-SM.RunRight180");
            mForwardRunRight1802RunTransitionID = Animator.StringToHash("Forward-SM.RunRight180 -> Forward-SM.RunForward");

            mBackwardsIdle2WalkStateID = Animator.StringToHash("Backwards-SM.Idle2BWalk");
            mBackwardsIdle2JogStateID = Animator.StringToHash("Backwards-SM.Idle2BJog");
            mBackwardsWalkStateID = Animator.StringToHash("Backwards-SM.WalkBackwards");
            mBackwardsJogStateID = Animator.StringToHash("Backwards-SM.JogBackwards");
            mBackwardsWalk2IdleStateID = Animator.StringToHash("Backwards-SM.BWalk2Idle");
            mBackwardsJog2IdleStateID = Animator.StringToHash("Backwards-SM.BJog2Idle");
            mSidewaysIdle2WalkLeftStateID = Animator.StringToHash("Strafe-Left-SM.Idle2SWalk");
            mSidewaysWalkLeftStateID = Animator.StringToHash("Strafe-Left-SM.SWalkLeft");
            mSidewaysWalkLeft2IdleStateID = Animator.StringToHash("Strafe-Left-SM.SWalk2Idle");
            mSidewaysIdle2WalkRightStateID = Animator.StringToHash("Strafe-Right-SM.Idle2SWalk");
            mSidewaysWalkRightStateID = Animator.StringToHash("Strafe-Right-SM.SWalkRight");
            mSidewaysWalkRight2IdleStateID = Animator.StringToHash("Strafe-Right-SM.SWalk2Idle");
        }

        /// <summary>
        /// Called once per frame to update objects. This happens after FixedUpdate().
        /// Reactions to calculations should be handled here.
        /// </summary>
        public void Update()
        {
            if (mAnimator == null) 
            { 
                mAnimator = GetComponent<Animator>();
                return; 
            }

            // Store the state we're in
            mStateInfo = mAnimator.GetCurrentAnimatorStateInfo(0);
            mTransitionInfo = mAnimator.GetAnimatorTransitionInfo(0);

            // Determine the stance we're in
            if (InputManager.IsAiming)
            {
                if (mStance != EnumControllerMode.COMBAT_RANGED)
                {
                    mPrevStance = mStance;
                    mStance = EnumControllerMode.COMBAT_RANGED;

                    mPrevRigMode = _CameraRig.Mode;

                    // Start the transition process
                    _CameraRig.TransitionToMode(EnumCameraMode.FIRST_PERSON);
                }
            }
            else if (mStance == EnumControllerMode.COMBAT_RANGED)
            {
                mStance = mPrevStance;

                _CameraRig.TransitionToMode(mPrevRigMode);
            }
            else if (InputManager.IsChangingStance)
            {
                mPrevStance = mStance;
                if (mStance == EnumControllerMode.TRAVERSAL)
                {
                    mStance = EnumControllerMode.COMBAT_MELEE;
                }
                else if (mStance == EnumControllerMode.COMBAT_MELEE)
                {
                    mStance = EnumControllerMode.TRAVERSAL;
                }
            }

            // Grab the direction and speed of the input relative to our current heading
            StickToWorldspace(this.transform, _CameraRig.transform, ref mTempState);

            // Ensure some of the other values are set correctly
            mTempState.Acceleration = mState.Acceleration;
            mTempState.InitialHeading = mState.InitialHeading;

            // Ranged movement allows for slow forward, backwards, and strafing
            if (mStance == EnumControllerMode.COMBAT_RANGED)
            {
                Log.ScreenWrite("AdventureController.Update - Controller Mode: COMBAT_RANGED", 2);

                _CameraRig.Mode = EnumCameraMode.FIRST_PERSON;

                mTempState.Speed *= _TargetingStanceMovementSpeedMultiplier;

                // Change our heading if needed
                if (mTempState.Speed == 0)
                {
                    if (IsInBackwardsState)
                    {
                        mTempState.InitialHeading = EnumControllerHeading.BACKWARD;
                    }
                    else
                    {
                        mTempState.InitialHeading = EnumControllerHeading.FORWARD;
                    }
                }
                else if (mTempState.Speed != 0 && mState.Speed == 0)
                {
                    float lInitialAngle = Mathf.Abs(mTempState.FromCameraAngle);
                    if (lInitialAngle < mForwardHeadingLimit) { mTempState.InitialHeading = EnumControllerHeading.FORWARD; }
                    else if (lInitialAngle > 180f - mBackwardsHeadingLimit) { mTempState.InitialHeading = EnumControllerHeading.BACKWARD; }
                    else { mTempState.InitialHeading = EnumControllerHeading.SIDEWAYS; }
                }

                // Ensure we're always facing forward
                mYAxisRotationAngle = NumberHelper.GetHorizontalAngle(transform.forward, _CameraRig.transform.forward);
                mTempState.FromAvatarAngle = 0f;
            }
            // Combat movement allows for forward, backwards, strafing, and pivoting
            else if (mStance == EnumControllerMode.COMBAT_MELEE)
            {
                Log.ScreenWrite("AdventureController.Update - Controller Mode: COMBAT_MELEE", 2);

                // Determine our initial heading
                if (mTempState.Speed == 0)
                {
                    if (IsInBackwardsState)
                    {
                        mTempState.InitialHeading = EnumControllerHeading.BACKWARD;
                    }
                    else
                    {
                        mTempState.InitialHeading = EnumControllerHeading.FORWARD;
                    }
                }
                else if (mTempState.Speed != 0 && mState.Speed == 0)
                {
                    float lInitialAngle = Mathf.Abs(mTempState.FromCameraAngle);
                    if (lInitialAngle < mForwardHeadingLimit) { mTempState.InitialHeading = EnumControllerHeading.FORWARD; }
                    else if (lInitialAngle > 180f - mBackwardsHeadingLimit) { mTempState.InitialHeading = EnumControllerHeading.BACKWARD; }
                    else { mTempState.InitialHeading = EnumControllerHeading.SIDEWAYS; }
                }

                // Ensure if we've been heading forward that we don't allow the
                // avatar to rotate back facing the player
                if (mTempState.InitialHeading == EnumControllerHeading.FORWARD)
                {
                    _CameraRig.Mode = EnumCameraMode.THIRD_PERSON_FOLLOW;

                    // Force the input to make us go forwards
                    if (mTempState.Speed > 0.1f && (mTempState.FromCameraAngle < -90 || mTempState.FromCameraAngle > 90))
                    {
                        mTempState.InputY = 1;
                    }

                    // If no forward rotation is allowed, this is easy
                    if (mForwardHeadingLimit == 0f)
                    {
                        mTempState.FromAvatarAngle = 0f;
                    }
                    // Respect the foward rotation limits
                    else
                    {
                        // Test if our rotation reaches the max from the camera. We use the camera since
                        // the avatar itself rotates and this limit is relative.
                        if (mTempState.FromCameraAngle < -mForwardHeadingLimit) { mTempState.FromCameraAngle = -mForwardHeadingLimit; }
                        else if (mTempState.FromCameraAngle > mForwardHeadingLimit) { mTempState.FromCameraAngle = mForwardHeadingLimit; }

                        // If we have reached a limit, we need to adjust the avatar angle
                        if (Mathf.Abs(mTempState.FromCameraAngle) == mForwardHeadingLimit)
                        {
                            // Flip the angle if we're crossing over the axis
                            if (Mathf.Sign(mTempState.FromCameraAngle) != Mathf.Sign(mState.FromCameraAngle))
                            {
                                mTempState.FromCameraAngle = -mTempState.FromCameraAngle;
                            }

                            // Only allow the avatar to rotate the heading limit, taking into account the angular
                            // difference between the camera and the avatar
                            mTempState.FromAvatarAngle = mTempState.FromCameraAngle + NumberHelper.GetHorizontalAngle(transform.forward, _CameraRig.transform.forward);
                        }
                    }
                }
                else if (mTempState.InitialHeading == EnumControllerHeading.BACKWARD)
                {
                    _CameraRig.Mode = EnumCameraMode.THIRD_PERSON_FIXED;

                    // Force the input to make us go backwards
                    if (mTempState.Speed > 0.1f && (mTempState.FromCameraAngle > -90 && mTempState.FromCameraAngle < 90))
                    {
                        mTempState.InputY = -1;
                    }

                    // Ensure we don't go beyond our boundry
                    if (mBackwardsHeadingLimit != 0f)
                    {
                        float lBackwardsHeadingLimit = 180f - mBackwardsHeadingLimit;

                        // Test if our rotation reaches the max from the camera. We use the camera since
                        // the avatar itself rotates and this limit is relative.
                        if (mTempState.FromCameraAngle <= 0 && mTempState.FromCameraAngle > -lBackwardsHeadingLimit) { mTempState.FromCameraAngle = -lBackwardsHeadingLimit; }
                        else if (mTempState.FromCameraAngle >= 0 && mTempState.FromCameraAngle < lBackwardsHeadingLimit) { mTempState.FromCameraAngle = lBackwardsHeadingLimit; }

                        // If we have reached a limit, we need to adjust the avatar angle
                        if (Mathf.Abs(mTempState.FromCameraAngle) == lBackwardsHeadingLimit)
                        {
                            // Only allow the avatar to rotate the heading limit, taking into account the angular
                            // difference between the camera and the avatar
                            mTempState.FromAvatarAngle = mTempState.FromCameraAngle + NumberHelper.GetHorizontalAngle(transform.forward, _CameraRig.transform.forward);
                        }

                        // Since we're moving backwards, we need to flip the movement angle.
                        // If we're not moving and simply finishing an animation, we don't
                        // want to rotate at all.
                        if (mTempState.Speed == 0)
                        {
                            mTempState.FromAvatarAngle = 0f;
                        }
                        else if (mTempState.FromAvatarAngle <= 0)
                        {
                            mTempState.FromAvatarAngle += 180f;
                        }
                        else if (mTempState.FromAvatarAngle > 0)
                        {
                            mTempState.FromAvatarAngle -= 180f;
                        }
                    }
                }
                else if (mTempState.InitialHeading == EnumControllerHeading.SIDEWAYS)
                {
                    _CameraRig.Mode = EnumCameraMode.THIRD_PERSON_FIXED;

                    // Move out of the sidestep if needed
                    if (mTempState.InputY > 0.1)
                    {
                        mTempState.InitialHeading = EnumControllerHeading.FORWARD;
                    }
                    else if (mTempState.InputY < -0.1)
                    {
                        mTempState.InitialHeading = EnumControllerHeading.BACKWARD;
                    }

                    // We need to be able to rotate our avatar so it's facing
                    // in the direction of the camera
                    if (mTempState.InitialHeading == EnumControllerHeading.SIDEWAYS)
                    {
                        mTempState.FromCameraAngle = 0f;
                        mTempState.FromAvatarAngle = mTempState.FromCameraAngle + NumberHelper.GetHorizontalAngle(transform.forward, _CameraRig.transform.forward);
                    }
                }
            }
            else
            {
                Log.ScreenWrite("AdventureController.Update - Controller Mode: EXPLORATION", 2);
            }

            // Determine the acceleration. We test this agains the 'last-last' speed so
            // that we are averaging out one frame.
            //mLastAcceleration = mAcceleration;
            mPrevState.Acceleration = mState.Acceleration;

            // Determine the trend so we can figure out acceleration
            if (mTempState.Speed == mState.Speed)
            {
                if (mSpeedTrendDirection != EnumSpeedTrend.CONSTANT)
                {
                    mSpeedTrendDirection = EnumSpeedTrend.CONSTANT;
                }
            }
            else if (mTempState.Speed < mState.Speed)
            {
                if (mSpeedTrendDirection != EnumSpeedTrend.DECELERATE)
                {
                    mSpeedTrendDirection = EnumSpeedTrend.DECELERATE;
                    if (mMecanimUpdateDelay <= 0f) { mMecanimUpdateDelay = 0.2f; }
                }

                // Acceleration needs to stay consistant for mecanim
                mTempState.Acceleration = mTempState.Speed - mSpeedTrendStart;
            }
            else if (mTempState.Speed > mState.Speed)
            {
                if (mSpeedTrendDirection != EnumSpeedTrend.ACCELERATE)
                {
                    mSpeedTrendDirection = EnumSpeedTrend.ACCELERATE;
                    if (mMecanimUpdateDelay <= 0f) { mMecanimUpdateDelay = 0.2f; }
                }

                // Acceleration needs to stay consistant for mecanim
                mTempState.Acceleration = mTempState.Speed - mSpeedTrendStart;
            }

            // Shuffle the states to keep us from having to reallocated
            ControllerState lTempState = mPrevState;
            mPrevState = mState;
            mState = mTempState;
            mTempState = lTempState;

            // Apply the movement and rotation
            ApplyMovement();
            ApplyRotation();

            // Delay a bit before we update the speed if we're accelerating
            // or decelerating.
            mMecanimUpdateDelay -= Time.deltaTime;
            if (mMecanimUpdateDelay <= 0f)
            {
                mAnimator.SetFloat("Speed", mState.Speed); //, 0.05f, Time.deltaTime);

                mSpeedTrendStart = mState.Speed;
            }

            // Update the direction relative to the avatar
            mAnimator.SetFloat("Avatar Direction", mState.FromAvatarAngle);

            // At this point, we never use angular speed. Rotation is done
            // in the ApplyRotation() function. Angular speed currently only effects
            // locomotion.
            mAnimator.SetFloat("Angular Speed", 0f);

            // The stance determins if we're in exploration or combat mode.
            mAnimator.SetInteger("Stance", mStance);

            // The direction from the camera
            mAnimator.SetFloat("Camera Direction", mState.FromCameraAngle); //, 0.05f, Time.deltaTime);

            // The raw input from the UI
            mAnimator.SetFloat("Input X", mState.InputX); //, 0.25f, Time.deltaTime);
            mAnimator.SetFloat("Input Y", mState.InputY); //, 0.25f, Time.deltaTime);

            // Finally print out info for player
            Log.ScreenWrite("Time:" + Time.deltaTime.ToString("000.000") + " Avatar" + StringHelper.ToString(transform.position) + " Camera" + StringHelper.ToString(_CameraRig.transform.position) + "", 0);
            Log.ScreenWrite("WASD / Left Stick = Movement", 6);
            Log.ScreenWrite("Mouse / Right Stick = View", 7);
            Log.ScreenWrite("Mouse Right Click / Left Trigger = Aim", 8);
            Log.ScreenWrite("T = Switch between Exploration and Combat movement", 9);
        }

        /// <summary>
        /// Determines the actual position of the avatar based on root motion,
        /// gravity, and any custom velocity.
        /// </summary>
        public void ApplyMovement()
        {
            // Using Move doesn't apply gravity. We need to do this on our own.
            // Velocity caused by gravity increases due to gravitational acceleration.
            // We'll accumulate that velocity here.
            if (mCharController.isGrounded)
            {
                mGravitationalVelocity = (Physics.gravity * Time.deltaTime);
            }
            else
            {
                mGravitationalVelocity += (Physics.gravity * Time.deltaTime);
            }

            // Velocity from root motion is applied, but can be modified first
            Vector3 lVelocity = (transform.rotation * mRootMotionVelocity);

            // Apply the accumulation of the gravitational velocity
            if (_UseGravity) { lVelocity += mGravitationalVelocity; }

            // Use the new velocity to move the avatar. We're going to counter-act
            // the controller's gravity so we can manage it ourselves
            mCharController.Move(lVelocity * Time.deltaTime);
        }

        /// <summary>
        /// Determines the rotation of the avatar based on root motion,
        /// input direction, and any custom rotation.
        /// </summary>
        public void ApplyRotation()
        {
            // First apply the root motion rotation. Before we apply it, we need
            // to move it from a velocity to a rotation delta
            Quaternion lRMRotation = mRootMotionAngularVelocity;
            lRMRotation.x *= Time.deltaTime;
            lRMRotation.y *= Time.deltaTime;
            lRMRotation.z *= Time.deltaTime;
            lRMRotation.w *= Time.deltaTime;
            transform.rotation *= lRMRotation;

            // When in targeting mode, we move slower pivot in place
            if (InputManager.IsAiming)
            {
                // This is actually overkill as the camera will force the rotation
                // of the avatar at the end of it's LateUpdate()
                float lAngularSpeed = Mathf.Lerp(0, mYAxisRotationAngle * 5.0f, 1.0f);
                transform.Rotate(transform.up, lAngularSpeed * Time.deltaTime);
            }
            // In any other mode, we have more freedome to rotate the avatar
            // outside the direction of the camera
            else
            {
                // If we're moving forward, rotate the avatar to face in the direction of the camera.
                if (IsInForwardState)
                {
                    if (mForwardHeadingLimit == 0)
                    {
                        Vector3 lForward = _CameraRig.transform.forward;
                        lForward.y = 0;
                        lForward.Normalize();
                    }
                    else
                    {
                        // Ensure we're not in a pivot. The pivot will do the rotating. The exception is when
                        // we're coming out of a pivot.
                        if (!IsInPivotTransitionState)
                        {
                            if (_CameraRig.IsOrbiting && mState.InputY > 0.5f)
                            {
                                // If the player is orbiting and moving forward,
                                // force the avatar towards the direction of the stick
                                transform.Rotate(transform.up, mState.FromAvatarAngle);
                            }
                            else
                            {
                                // Augment the root motion rotation by adding some rotation if the player is moving to the right and the
                                // avatar is turning right or if the player is moving to the left and the avatar is turning left.
                                float lAngularSpeed = Mathf.Lerp(0, mState.FromAvatarAngle * 5f, 0.7f);
                                transform.Rotate(transform.up, lAngularSpeed * Time.deltaTime);
                            }
                        }
                    }
                }

                // If we're moving backwards, we may need to rotate to face the camera
                if (IsInBackwardsState)
                {
                    if (mBackwardsHeadingLimit == 0)
                    {
                        Vector3 lForward = _CameraRig.transform.forward;
                        lForward.y = 0;
                        lForward.Normalize();
                    }
                    else
                    {
                        if (_CameraRig.IsOrbiting && mState.InputY < -0.5f)
                        {
                            transform.Rotate(transform.up, mState.FromAvatarAngle);
                        }
                        else
                        {
                            float lAngularSpeed = Mathf.Lerp(0f, mState.FromAvatarAngle * 2f, 0.7f);
                            transform.Rotate(transform.up, lAngularSpeed * Time.deltaTime);
                        }
                    }
                }

                // If we're moving sideways, we may need to rotate to face the camera
                if (IsInStrafeState)
                {
                    if (_CameraRig.IsOrbiting)
                    {
                        transform.Rotate(transform.up, mState.FromAvatarAngle);
                    }
                    else
                    {
                        float lAngularSpeed = Mathf.Lerp(0f, mState.FromAvatarAngle, 0.7f);
                        transform.Rotate(transform.up, lAngularSpeed * Time.deltaTime);
                    }
                }
            }
        }

        /// <summary>
        /// Called to apply root motion manually. The existance of this
        /// stops the application of any existing root motion since we're
        /// essencially overriding the function. 
        /// 
        /// This function is called right after FixedUpdate() whenever
        /// FixedUpdate() is called. It is not called if FixedUpdate() is not
        /// called.
        /// </summary>
        private void OnAnimatorMove()
        {
            // Store the root motion as a velocity per second. We also
            // want to keep it relative to the avatar's forward vector (for now)
            mRootMotionVelocity = Quaternion.Inverse(transform.rotation) * (mAnimator.deltaPosition / Time.fixedDeltaTime);

            // Store the rotation as a velocity per second.
            mRootMotionAngularVelocity = mAnimator.deltaRotation;
            mRootMotionAngularVelocity.x /= Time.fixedDeltaTime;
            mRootMotionAngularVelocity.y /= Time.fixedDeltaTime;
            mRootMotionAngularVelocity.z /= Time.fixedDeltaTime;
            mRootMotionAngularVelocity.w /= Time.fixedDeltaTime;
        }

        /// <summary>
        /// Test to see if we're currently in the locomotion state
        /// </summary>
        public bool IsInForwardState
        {
            get
            {
                if (mStateInfo.nameHash == mForwardIdle2WalkStateID ||
                    mStateInfo.nameHash == mForwardIdle2JogStateID ||
                    mStateInfo.nameHash == mForwardIdle2RunStateID ||
                    mStateInfo.nameHash == mForwardWalkStateID ||
                    mStateInfo.nameHash == mForwardJogStateID ||
                    mStateInfo.nameHash == mForwardRunStateID ||
                    mStateInfo.nameHash == mForwardWalk2IdleStateID ||
                    mStateInfo.nameHash == mForwardJog2IdleStateID ||
                    mStateInfo.nameHash == mForwardRun2IdleStateID ||
                    mStateInfo.nameHash == mForwardRun2BJogStateID
                    )
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Test to see if we're currently in the locomotion state
        /// </summary>
        public bool IsInBackwardsState
        {
            get
            {
                if (mStateInfo.nameHash == mBackwardsIdle2WalkStateID ||
                    mStateInfo.nameHash == mBackwardsIdle2JogStateID ||
                    mStateInfo.nameHash == mBackwardsWalkStateID ||
                    mStateInfo.nameHash == mBackwardsJogStateID ||
                    mStateInfo.nameHash == mBackwardsWalk2IdleStateID ||
                    mStateInfo.nameHash == mBackwardsJog2IdleStateID
                    )
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Test to see if we're currently in the locomotion state
        /// </summary>
        public bool IsInStrafeState
        {
            get
            {
                if (mStateInfo.nameHash == mSidewaysIdle2WalkLeftStateID ||
                    mStateInfo.nameHash == mSidewaysWalkLeftStateID ||
                    mStateInfo.nameHash == mSidewaysWalkLeft2IdleStateID ||
                    mStateInfo.nameHash == mSidewaysIdle2WalkRightStateID ||
                    mStateInfo.nameHash == mSidewaysWalkRightStateID ||
                    mStateInfo.nameHash == mSidewaysWalkRight2IdleStateID
                    )
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Test to see if we're currently pivoting
        /// </summary>
        public bool IsInPivotState
        {
            get
            {
                if (mStateInfo.nameHash == mForwardRunLeft135StateID ||
                    mStateInfo.nameHash == mForwardRunLeft180StateID ||
                    mStateInfo.nameHash == mForwardRunRight135StateID ||
                    mStateInfo.nameHash == mForwardRunRight180StateID
                    )
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Test to see if we're currently pivoting
        /// </summary>
        public bool IsInPivotTransitionState
        {
            get
            {
                if (mTransitionInfo.nameHash == mForwardRun2RunLeft135TransitionID ||
                    mStateInfo.nameHash == mForwardRunLeft135StateID ||
                    mTransitionInfo.nameHash == mForwardRunLeft1352RunTransitionID ||
                    mTransitionInfo.nameHash == mForwardRun2RunLeft180TransitionID ||
                    mStateInfo.nameHash == mForwardRunLeft180StateID ||
                    mTransitionInfo.nameHash == mForwardRunLeft1802RunTransitionID ||
                    mTransitionInfo.nameHash == mForwardRun2RunRight135TransitionID ||
                    mStateInfo.nameHash == mForwardRunRight135StateID ||
                    mTransitionInfo.nameHash == mForwardRunRight1352RunTransitionID ||
                    mTransitionInfo.nameHash == mForwardRun2RunRight180TransitionID ||
                    mStateInfo.nameHash == mForwardRunRight180StateID ||
                    mTransitionInfo.nameHash == mForwardRunRight1802RunTransitionID
                    )
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Test to see if we're currently infront of the camera
        /// </summary>
        public bool IsInForwardPivotState
        {
            get
            {
                if (mStateInfo.nameHash == mForwardRunLeft180StateID ||
                    mStateInfo.nameHash == mForwardRunRight180StateID
                    )
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Test to see if we're currently infront of the camera
        /// </summary>
        public bool IsInSidePivotState
        {
            get
            {
                if (mTransitionInfo.nameHash == mForwardRun2RunLeft135TransitionID ||
                    mStateInfo.nameHash == mForwardRunLeft135StateID ||
                    mTransitionInfo.nameHash == mForwardRunLeft1352RunTransitionID ||
                    mTransitionInfo.nameHash == mForwardRun2RunRight135TransitionID ||
                    mStateInfo.nameHash == mForwardRunRight135StateID ||
                    mTransitionInfo.nameHash == mForwardRunRight1352RunTransitionID
                    )
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// This function is used to convert the game control stick value to
        /// speed and direction values for the player.
        /// </summary>
        protected void StickToWorldspace(Transform rController, Transform rCamera, ref ControllerState rState)
        {
            // Grab the movement, but create a bit of a dead zone
            float lHInput = InputManager.MovementX;
            float lVInput = InputManager.MovementY;

            // Get out early if we can simply this
            if (lVInput == 0f && lHInput == 0f)
            {
                rState.Speed = 0f;
                rState.FromAvatarAngle = 0f;
                rState.InputX = 0f;
                rState.InputY = 0f;

                return;
            }

            // Determine the relative speed
            rState.Speed = Mathf.Sqrt((lHInput * lHInput) + (lVInput * lVInput));

            // Create a simple vector off of our stick input and get the speed
            sVector3A.x = lHInput;
            sVector3A.y = 0f;
            sVector3A.z = lVInput;

            // Direction of the avatar
            Vector3 lControllerForward = rController.forward;
            lControllerForward.y = 0f;
            lControllerForward.Normalize();

            // Direction of the camera
            Vector3 lCameraForward = rCamera.forward;
            lCameraForward.y = 0f;
            lCameraForward.Normalize();

            // Create a quaternion that gets us from our world-forward to our camera direction.
            // FromToRotation creates a quaternion using the shortest method which can sometimes
            // flip the angle. LookRotation will attempt to keep the "up" direction "up".
            //Quaternion rToCamera = Quaternion.FromToRotation(Vector3.forward, Vector3.Normalize(lCameraForward));
            Quaternion rToCamera = Quaternion.LookRotation(lCameraForward);

            // Transform joystick from world space to camera space. Now the input is relative
            // to how the camera is facing.
            Vector3 lMoveDirection = rToCamera * sVector3A;

            rState.FromCameraAngle = NumberHelper.GetHorizontalAngle(lCameraForward, lMoveDirection);
            rState.FromAvatarAngle = NumberHelper.GetHorizontalAngle(lControllerForward, lMoveDirection);

            // Set the direction of the movement in ranges of -1 to 1
            rState.InputX = lHInput;
            rState.InputY = lVInput;

            //Debug.DrawRay(new Vector3(rController.position.x, rController.position.y + 2f, rController.position.z), lControllerForward, Color.gray);
            //Debug.DrawRay(new Vector3(rController.position.x, rController.position.y + 2f, rController.position.z), lMoveDirection, Color.green);
        }
    }
}

