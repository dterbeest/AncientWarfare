/// Tim Tryzbiak, ootii, LLC
using System;
using UnityEngine;

namespace com.ootii.Base
{
    /// <summary>
    /// Provides a simple foundation for all of our objects
    /// </summary>
    [Serializable]
    public class BaseScriptableObject : ScriptableObject, IBaseObject
    {
        /// <summary>
        /// Semi-unique ID for the object. This should be unique
        /// across all objects
        /// </summary>
        [HideInInspector]
        public string _ID = "";
        public string ID
        {
            get { return _ID; }

            set
            {
                _ID = value;

                // Ensure our next ID is higher
                int lID = 0;
                if (int.TryParse(_ID, out lID))
                {
                    if (BaseObject.NextID <= lID)
                    {
                        BaseObject.NextID = lID + 1;
                    }
                }
            }
        }

        /// <summary>
        /// If a value exists, that value represents a 
        /// unique id or key for the object
        /// </summary>
        [HideInInspector]
        public string _GUID = "";
        public string GUID
        {
            get { return _GUID; }
            set { _GUID = ""; }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseScriptableObject()
        {
            _ID = BaseObject.NextID.ToString();

            // Increment the next unique ID
            BaseObject.NextID++;
        }

        /// <summary>
        /// ID constructor
        /// </summary>
        public BaseScriptableObject(string rID)
        {
            ID = rID;
        }

        /// <summary>
        /// Generates a unique ID for the object
        /// </summary>
        public void GenerateGUID()
        {
            _GUID = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Raised after the object has been deserialized. It allows
        /// for any initialization that may need to happen
        /// </summary>
        public virtual void OnDeserialized()
        {
        }
    }
}

