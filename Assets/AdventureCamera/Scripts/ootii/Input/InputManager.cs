using System;
using System.Collections.Generic;
using UnityEngine;
using com.ootii.Utilities.Debug;

namespace com.ootii.Input
{
    /// <summary>
    /// Wraps game input so that we can process it
    /// before applying it to game objects.
    /// </summary>
    public class InputManager
    {
        /// <summary>
        /// Determines how quickly the mouse movement updates
        /// </summary>
        private static float mMouseSensativity = 5f;
        public static float MouseSensativity
        {
            get { return mMouseSensativity; }
            set { mMouseSensativity = value; }
        }

        /// <summary>
        /// Determines if we're going to use the xbox controller or not
        /// </summary>
        private static bool mUseXboxController = false;
        public static bool UseXboxController
        {
            get { return mUseXboxController; }
            set { mUseXboxController = value; }
        }

        /// <summary>
        /// Keep track of the old values for smoothing
        /// </summary>
        private static float mOldViewX = 0f;
        private static float mOldViewY = 0f;

        /// <summary>
        /// Determines if it's time to change the player's stance
        /// </summary>
        /// <value><c>true</c> if is changing stance; otherwise, <c>false</c>.</value>
        public static bool IsChangingStance
        {
            get
            {
                // T
                return UnityEngine.Input.GetKeyDown(KeyCode.T);
            }
        }

        /// <summary>
        /// Determine if the player is activating the aiming feature
        /// </summary>
        /// <value><c>true</c> if is aiming; otherwise, <c>false</c>.</value>
        public static bool IsAiming
        {
            get
            {
                bool lIsAiming = false;

                if (mUseXboxController) { lIsAiming = (UnityEngine.Input.GetAxis("LeftTrigger") == 1); }
                if (!lIsAiming) { lIsAiming = UnityEngine.Input.GetMouseButton(1); }

                return lIsAiming;
            }
        }

        /// <summary>
        /// Determines if we're allows to free view with the mouse or right-stick
        /// </summary>
        /// <value><c>true</c> if is free viewing; otherwise, <c>false</c>.</value>
        public static bool IsFreeViewing
        {
            get { return true; }
        }

        /// <summary>
        /// Speed of movement in the range of -1 (full backwards) to 1 (full forward)
        /// </summary>
        /// <value>The speed in the range of -1 to 1</value>
        public static float Speed
        {
            get
            {
                float lMovementX = MovementX;
                float lMovementY = MovementY;
                return Mathf.Sqrt((lMovementX * lMovementX) + (lMovementY * lMovementY));
            }
        }

        /// <summary>
        /// Horizontal movement in the range of -1 (left) to 1 (right)
        /// </summary>
        /// <value>The movement in the range of -1 to 1</value>
        public static float MovementX
        {
            get
            {
                return UnityEngine.Input.GetAxis("Horizontal");
            }
        }

        /// <summary>
        /// Vertical movement in the range of -1 (down) to 1 (up)
        /// </summary>
        /// <value>The movement in the range of -1 to 1</value>
        public static float MovementY
        {
            get
            {
                return UnityEngine.Input.GetAxis("Vertical");
            }
        }

        /// <summary>
        /// Horizontal view change in the range of -1 (left) to 1 (right)
        /// </summary>
        /// <value>The view in the range of -1 to 1</value>
        public static float ViewX
        {
            get
            {
                float lView = 0f;

                if (mUseXboxController)
                {
                    lView = UnityEngine.Input.GetAxisRaw("RightStickX");
                }

                if (lView == 0f)
                {
                    lView = UnityEngine.Input.GetAxis("Mouse X") * mMouseSensativity;
                    if (lView < -mMouseSensativity) { lView = -mMouseSensativity; }
                    else if (lView > mMouseSensativity) { lView = mMouseSensativity; }
                }

                lView = Mathf.Lerp(mOldViewX, lView, 0.9f);
                mOldViewX = lView;

                return lView;
            }
        }

        /// <summary>
        /// Vertical view change in the range of -1 (left) to 1 (right)
        /// </summary>
        /// <value>The view in the range of -1 to 1</value>
        public static float ViewY
        {
            get
            {
                float lView = 0f;

                if (mUseXboxController)
                {
                    lView = UnityEngine.Input.GetAxisRaw("RightStickY");
                }

                if (lView == 0f)
                {
                    lView = UnityEngine.Input.GetAxis("Mouse Y") * mMouseSensativity;
                    if (lView < -mMouseSensativity) { lView = -mMouseSensativity; }
                    else if (lView > mMouseSensativity) { lView = mMouseSensativity; }
                }

                lView = Mathf.Lerp(mOldViewY, lView, 0.9f);
                mOldViewY = lView;

                return lView;
            }
        }
    }
}

