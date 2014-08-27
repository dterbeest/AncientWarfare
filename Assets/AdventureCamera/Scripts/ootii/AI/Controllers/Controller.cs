using UnityEngine;
using System.Collections.Generic;
using com.ootii.Base;
using com.ootii.Cameras;
using com.ootii.Helpers;
using com.ootii.Input;
using com.ootii.Utilities.Debug;

namespace com.ootii.AI.Controllers
{
    /// <summary>
    /// A controller is used to manage the movement and behavior of
    /// a character. Typically this is the character being controlled by
    /// the player, but that's not always the case.
    /// </summary>
    public class Controller : BaseMonoObject
    {
        /// <summary>
        /// Camera rig holding the camera that represents the 
        /// view from this controller
        /// </summary>
        public CameraRig _CameraRig;
        public virtual CameraRig CameraRig
        {
            get { return _CameraRig; }
        }

        /// <summary>
        /// This is the position that the camera is attempting to move
        /// towards. It's the default position of the camera and typically
        /// represents the avatar's head.
        /// </summary>
        public virtual Vector3 CameraRigAnchor
        {
            get { return Vector3.zero; }
        }

        /// <summary>
        /// Radius of the collider surrounding the controller
        /// </summary>
        public virtual float ColliderRadius
        {
            get { return 0f; }
        }

        /// <summary>
        /// Used to rotate the avatar in the direction of the camera. When in 
        /// first-person mode, the camera needs to do this at the end of the
        /// LateUpdate() or the avatar rotation will be behind the camera and
        /// we get wobbling effects
        /// </summary>
        public virtual void FaceCameraForward()
        {
            // Don't lerp or smooth. Otherwise we get wobbling
            float lAngle = NumberHelper.GetHorizontalAngle(transform.forward, _CameraRig.transform.forward);
            transform.Rotate(transform.up, lAngle);
        }
    }
}
