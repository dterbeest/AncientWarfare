/// Tim Tryzbiak, ootii, LLC
using System;
using System.Collections;
using System.Collections.Generic;
//using System.IO;
using UnityEngine;

namespace com.ootii.Utilities.Debug
{
	/// <summary>
	/// Provides functionality for debugging in the game. This allows us to
	/// write to the screen, console, or file
	/// </summary>
	public class Log : MonoBehaviour
	{		
		/// <summary>
		/// Inspector property
		/// Prefixes each line with the game time
		/// </summary>
		public bool _PrefixTime = true;
		
		/// <summary>
		/// Inspector property
		/// Determins if the "Write()" call writes to the console
		/// </summary>
		public bool _IsConsoleEnabled = true;
		
		/// <summary>
		/// Inspector property
		/// Determins if the "Write()" call writes to the screen
		/// </summary>
		public bool _IsScreenEnabled = true;
		
		/// <summary>
		/// Sets the size of the font when written to the screen.
		/// </summary>
		public int _ScreenFontSize = 12;
		
		/// <summary>
		/// Sets the color of the font in the screen
		/// </summary>
		public Color _ScreenForeColor = Color.black;
		
		/// <summary>
		/// Inspector property
		/// Determins if the "Write()" call writes to the file
		/// </summary>
		public bool _IsFileEnabled = false;
		
		/// <summary>
		/// Inspector property
		/// The file path and name to create when logging to the disk. Using
		/// ".\\Log.txt" creates a text file in the root folder of your project
		/// called Log.txt.
		/// </summary>
		public string _FilePath = ".\\Log.txt";
		
		/// <summary>
		/// Determines if we flush the file on every write. If not, we'll
		/// do it every frame.
		/// </summary>
		public bool _FileFlushPerWrite = false;
		
		/// <summary>
		/// Start this instance.
		/// </summary>
		public IEnumerator Start()
		{
			Log.FilePath = _FilePath;
			Log.FontSize = _ScreenFontSize;
			Log.ForeColor = _ScreenForeColor;
			Log.LineHeight = _ScreenFontSize + 6;
			Log.PrefixTime = _PrefixTime;
			Log.IsFileEnabled = _IsFileEnabled;
			Log.IsScreenEnabled = _IsScreenEnabled;
			Log.IsConsoleEnabled = _IsConsoleEnabled;
			Log.FileFlushPerWrite = _FileFlushPerWrite;
			
			while(true)
			{
				// Wait until we reach the end of the frame
				// and then flush the log. This way we can 
				// refresh the UI while in the frame.
				yield return new WaitForEndOfFrame();
				Log.Clear();
			}
		}
		
		/// <summary>
		/// Raised when destroyed
		/// </summary>
		public void OnDestroy() 
		{
			Log.Close();
		}
		
		/// <summary>
		/// Raised when the GUI needs to be drawn
		/// </summary>
		public void OnGUI()
		{
			Log.Render();
		}
		
		/// <summary>
		/// The file path and name to create when logging to the disk. Using
		/// ".\\Log.txt" creates a text file in the root folder of your project
		/// called Log.txt.
		/// </summary>
		private static string mFilePath = ".\\Log.txt";
		public static string FilePath
		{
			get { return mFilePath; }
			set { mFilePath = value; }
		}
		
		/// <summary>
		/// Prefixes each line with the game time
		/// </summary>
		private static bool mPrefixTime = true;
		public static bool PrefixTime
		{
			get { return mPrefixTime; }
			set { mPrefixTime = value; }
		}
		
		/// <summary>
		/// The height of the each line when written to screen.
		/// </summary>
		private static int mLineHeight = 18;
		public static int LineHeight
		{
			get { return mLineHeight; }
			set { mLineHeight = value; }
		}
		
		/// <summary>
		/// Determins if the "Write()" call writes to the file
		/// </summary>
		private static bool mIsFileEnabled = false;
		public static bool IsFileEnabled
		{
			get { return mIsFileEnabled; }
			set { mIsFileEnabled = value; }
		}
		
		/// <summary>
		/// Determins if the "Write()" call writes to the screen
		/// </summary>
		private static bool mIsScreenEnabled = true;
		public static bool IsScreenEnabled
		{
			get { return mIsScreenEnabled; }
			set { mIsScreenEnabled = value; }
		}
		
		/// <summary>
		/// Determins if the "Write()" call writes to the console
		/// </summary>
		private static bool mIsConsoleEnabled = true;
		public static bool IsConsoleEnabled
		{
			get { return mIsConsoleEnabled; }
			set { mIsConsoleEnabled = value; }
		}
		
		/// <summary>
		/// Determines if we flush the file buffer to disk each write
		/// or once per frame
		/// </summary>
		private static bool mFileFlushPerWrite = true;
		public static bool FileFlushPerWrite
		{
			get { return mFileFlushPerWrite; }
			set { mFileFlushPerWrite = value; }
		}
		
		/// <summary>
		/// Sets the size of the font in the screen
		/// </summary>
		private static int mFontSize = 12;
		public static int FontSize
		{
			get { return mFontSize; }
			set { mFontSize = value; }
		}
		
		/// <summary>
		/// Sets the color of the font in the screen
		/// </summary>
		private static Color mForeColor = Color.black;
		public static Color ForeColor
		{
			get { return mForeColor; }
			set { mForeColor = value; }
		}
		
		/// <summary>
		/// Lines of text to store and render
		/// </summary>
		private static List<LogText> mLines = new List<LogText>();
		
		/// <summary>
		/// Tracks the last line we added
		/// </summary>
		private static int mNextLine = 10;
		
		/// <summary>
		/// The rectangle to draw each line
		/// </summary>
		private static Rect mLineRect = new Rect();
		
		/// <summary>
		/// Streamwriter to write to a file
		/// </summary>
//		private static StreamWriter mWriter = null;
		
		/// <summary>
		/// Write to the logs that have been enabled
		/// </summary>
		/// <param name="rText">R text.</param>
		public static void Write(string rText)
		{
			if (mIsFileEnabled) { FileWrite(rText); }
			if (mIsScreenEnabled) { ScreenWrite(rText); }
			if (mIsConsoleEnabled) { ConsoleWrite(rText); }
		}
		
		/// <summary>
		/// Write out to the file. If the file isn't open, we'll
		/// create it an open it.
		/// </summary>
		/// <param name="rText">R text.</param>
		public static void FileWrite(string rText)
		{
//			if (mPrefixTime) { rText = "[" + Time.time.ToString("0000.000") + "] " + rText; }
//			
//			if (mWriter == null)
//			{
//				mWriter = File.CreateText(FilePath);
//			}
//			
//			mWriter.WriteLine(rText);
//			if (mFileFlushPerWrite) { mWriter.Flush(); }
		}
		
		/// <summary>
		/// Write to both the debug output and screen
		/// </summary>
		/// <param name="rText">R text.</param>
		public static void ConsoleScreenWrite(string rText)
		{
			ConsoleWrite(rText);
			ScreenWrite(rText);
		}
		
		/// <summary>
		/// Write to both the debug output and screen
		/// </summary>
		/// <param name="rText">R text.</param>
		/// <param name="rLine">Line index to write on. Internally we use (rLine * mLineHeight)</param>
		public static void ConsoleScreenWrite(string rText, int rLine)
		{
			ConsoleWrite(rText);
			ScreenWrite(rText, rLine);
		}
		
		/// <summary>
		/// Logs information to the console
		/// </summary>
		public static void ConsoleWrite(string rText)
		{
			if (mPrefixTime) { rText = "[" + Time.time.ToString("0000.000") + "] " + rText; }
			UnityEngine.Debug.Log(rText);
		}
		
		/// <summary>
		/// Writes text to the screen
		/// </summary>
		/// <param name="rText">Text to write</param>
		public static void ScreenWrite(string rText)
		{
			ScreenWrite(rText, 10, mNextLine);
			mNextLine += mLineHeight;
		}
		
		/// <summary>
		/// Writes text to the screen
		/// </summary>
		/// <param name="rText">Text to write</param>
		/// <param name="rLine">Line index to write on. Internally we use (rLine * mLineHeight)</param>
		public static void ScreenWrite(string rText, int rLine)
		{
			ScreenWrite(rText, 10, rLine * mLineHeight);
		}
		
		/// <summary>
		/// Writes text to the screen
		/// </summary>
		/// <param name="rText">Text to write</param>
		/// <param name="rX">X start of left character</param>
		/// <param name="rY">Y start of the left character</param>
		public static void ScreenWrite(string rText, int rX, int rY)
		{
			if (mPrefixTime) { rText = "[" + Time.time.ToString("0000.000") + "] " + rText; }
			
			LogText lLine = LogText.Allocate(rText, rX, rY);
			mLines.Add(lLine);
		}
		
		/// <summary>
		/// Called every frame to enable rendering of GUI items
		/// to the screeen
		/// </summary>
		public static void Render() 
		{
			GUIStyle lStyle = new GUIStyle();
			lStyle.alignment = TextAnchor.UpperLeft;
			lStyle.normal.textColor = Color.white;
			lStyle.fontSize = mFontSize;
			
			//GUI.color = Color.white;
			GUI.contentColor = mForeColor;
			GUI.backgroundColor = Color.green;
			
			// Write out the lines of text
			for (int i = 0; i < mLines.Count; i++)
			{
				LogText lLine = mLines[i];
				
				mLineRect.x = lLine.X;
				mLineRect.y = lLine.Y;
				mLineRect.width = 900;
				mLineRect.height = mLineHeight;
				
				GUI.Label(mLineRect, lLine.Text, lStyle);
			}
		}
		
		/// <summary>
		/// Called by the co-routine after rendering happens
		/// so that we can clean up our objects
		/// </summary>
		public static void Clear()
		{
			mNextLine = 10;
			
			for (int i = 0; i < mLines.Count; i++)
			{
				LogText.Release(mLines[i]);
			}
			
			mLines.Clear();
			
			// Flush the external log if needed
//			if (mWriter != null) { mWriter.Flush(); }
		}
		
		/// <summary>
		/// Close the external log if needed
		/// </summary>
		public static void Close()
		{
//			if (mWriter != null)
//			{
//				mWriter.Flush();
//				mWriter.Close();
//				mWriter = null;
//			}
		}
	}
}

