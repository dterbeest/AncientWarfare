using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.ootii.Base
{
    /// <summary>
    /// provides a simple interface for all all
    /// base object that exposes identifiers
    /// </summary>
    public interface IBaseObject
    {
        /// <summary>
        /// Semi-unique ID for the object. This should be unique
        /// across all objects, but is not required
        /// </summary>
        string ID { get; set; }

        /// <summary>
        /// If a value exists, that value represents a 
        /// unique id or key for the object
        /// </summary>
        string GUID { get; set; }

        /// <summary>
        /// Generates a unique ID for the object
        /// </summary>
        void GenerateGUID();

        /// <summary>
        /// Raised after the object has been deserialized. It allows
        /// for any initialization that may need to happen
        /// </summary>
        void OnDeserialized();
    }
}
