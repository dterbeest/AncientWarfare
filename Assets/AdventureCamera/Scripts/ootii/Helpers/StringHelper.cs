/// Tim Tryzbiak, ootii, LLC
using System;
using UnityEngine;

namespace com.ootii.Helpers
{
	/// <summary>
	/// Static functions to help us
	/// </summary>
	public class StringHelper
	{
		/// <summary>
		/// Converts the data to a string value
		/// </summary>
		/// <returns>The string.</returns>
		/// <param name="rInput">Value to convert</param>
		public static string ToString(Vector3 rInput)
		{
			return "[" + rInput.x.ToString(" 0.000;-0.000; 0.000") + "," + rInput.y.ToString(" 0.000;-0.000; 0.000") + "," + rInput.z.ToString(" 0.000;-0.000; 0.000") + "]";
		}
	}
}

