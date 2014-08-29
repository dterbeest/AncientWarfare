//Made by KirbyRawr from Overflowing Studios
//Please don't claim it as yourself.
//If you pirated it consider buying it (:
//Thanks

using UnityEngine;
using System.Collections;
using UnityEditor;
using UMA;
using System.Collections.Generic;

[CustomEditor(typeof(UMAModels))]
public class UMAModelsEditor : Editor
{
		//LOGO
		public Texture2D Logo =  Resources.Load("Logo",typeof(Texture2D)) as Texture2D ;	


		//GENERAL
		public SerializedProperty  Male;
		public SerializedProperty  Female;
		public SerializedProperty  SkinColor;
		public SerializedProperty SpawnPoint;

		//Male SLOTS
		public SerializedProperty  MaleHeadSLOT;
		public SerializedProperty  MaleHeadEyesSLOT;
		public SerializedProperty  MaleHeadMouthSLOT;
		public SerializedProperty  MaleHeadNoseSLOT;
		public SerializedProperty  MaleHeadEarsSLOT;
		public SlotData  MaleHeadNameSLOT;
		public SlotData  MaleHeadEyesNameSLOT;
		public SlotData  MaleHeadMouthNameSLOT;
		public SlotData  MaleHeadNoseNameSLOT;
		public SlotData  MaleHeadEarsNameSLOT;
		public SerializedProperty  MaleFaceSLOT;
		public SerializedProperty  MaleEyesSLOT;
		public SerializedProperty  MaleTorsoSLOT;
		public SerializedProperty  MaleHandsSLOT;
		public SerializedProperty  MaleInnerMouthSLOT;
		public SerializedProperty  MaleLegsSLOT;
		public SerializedProperty  MaleFeetSLOT;
		public SlotData  MaleFaceNameSLOT;
		public SlotData  MaleEyesNameSLOT;
		public SlotData  MaleTorsoNameSLOT;
		public SlotData  MaleHandsNameSLOT;
		public SlotData  MaleInnerMouthNameSLOT;
		public SlotData  MaleLegsNameSLOT;
		public SlotData  MaleFeetNameSLOT;

		//Female SLOTS
		public SerializedProperty FemaleHairSLOT;
		public SerializedProperty   FemaleHeadSLOT;
		public SerializedProperty   FemaleHeadEyesSLOT;
		public SerializedProperty  FemaleHeadMouthSLOT;
		public SerializedProperty  FemaleHeadNoseSLOT;
		public SerializedProperty  FemaleHeadEarsSLOT;
		public SlotData  FemaleHairNameSLOT;
		public SlotData  FemaleHeadNameSLOT;
		public SlotData  FemaleHeadEyesNameSLOT;
		public SlotData  FemaleHeadMouthNameSLOT;
		public SlotData  FemaleHeadNoseNameSLOT;
		public SlotData  FemaleHeadEarsNameSLOT;
		public SerializedProperty  FemaleFaceSLOT;
		public SerializedProperty  FemaleEyesSLOT;
		public SerializedProperty  FemaleTorsoSLOT;
		public SerializedProperty  FemaleHandsSLOT;
		public SerializedProperty  FemaleInnerMouthSLOT;
		public SerializedProperty  FemaleLegsSLOT;
		public SerializedProperty  FemaleFeetSLOT;
		public SlotData  FemaleFaceNameSLOT;
		public SlotData  FemaleEyesNameSLOT;
		public SlotData  FemaleTorsoNameSLOT;
		public SlotData  FemaleHandsNameSLOT;
		public SlotData  FemaleInnerMouthNameSLOT;
		public SlotData  FemaleLegsNameSLOT;
		public SlotData  FemaleFeetNameSLOT;

		//Male OVERLAYS
		public SerializedProperty  HairMale;
		public SerializedProperty  Beard;
		public SerializedProperty  Beard2;
		public SerializedProperty  EyebrowMale;
		public OverlayData  MaleHairNameOVERLAY;
		public OverlayData  MaleBeardNameOVERLAY;
		public OverlayData  MaleBeard2NameOVERLAY;
		public OverlayData  MaleEyebrowNameOVERLAY;
		public OverlayData  MaleFaceNameOVERLAY;
		public OverlayData  MaleHeadNameOVERLAY;
		public OverlayData  MaleEyesNameOVERLAY;
		public OverlayData  MaleMouthNameOVERLAY;
		public OverlayData  MaleEarsNameOVERLAY;
		public OverlayData  MaleTorsoNameOVERLAY;
		public OverlayData  MaleHandsNameOVERLAY;
		public OverlayData  MaleInnerMouthNameOVERLAY;
		public OverlayData  MaleLegsNameOVERLAY;
		public OverlayData  MaleFeetNameOVERLAY;
		public SerializedProperty hairMaleOverlayColor;
		public SerializedProperty beardMaleOverlayColor;
		public SerializedProperty beard2MaleOverlayColor;
		public SerializedProperty eyeBrowMaleOverlayColor;
		public SerializedProperty eyesMaleOverlayColor;
		public SerializedProperty innerMouthMaleOverlayColor;


		//Female OVERLAYS
		public SerializedProperty  FemaleEyebrow;
		public SerializedProperty  FemaleLipstick;
		public OverlayData  FemaleHairNameOVERLAY;
		public OverlayData  FemaleLipstickNameOVERLAY;
		public OverlayData  FemaleEyebrowNameOVERLAY;
		public OverlayData  FemaleFaceNameOVERLAY;
		public OverlayData  FemaleHeadNameOVERLAY;
		public OverlayData  FemaleEyesNameOVERLAY;
		public OverlayData  FemaleMouthNameOVERLAY;
		public OverlayData  FemaleEarsNameOVERLAY;
		public OverlayData  FemaleTorsoNameOVERLAY;
		public OverlayData  FemaleHandsNameOVERLAY;
		public OverlayData  FemaleInnerMouthNameOVERLAY;
		public OverlayData  FemaleLegsNameOVERLAY;
		public OverlayData  FemaleFeetNameOVERLAY;
		public SerializedProperty eyesFemaleOverlayColor;
		public SerializedProperty hairFemaleOverlayColor;
		public SerializedProperty eyeBrowFemaleOverlayColor;
		public SerializedProperty lipStickFemaleOverlayColor;
		public SerializedProperty innerMouthFemaleOverlayColor;

		//Male Clothes SLOTS
		public SerializedProperty  JeansMaleSLOT;
		public SlotData  JeansMaleNameSLOT;

		//Female Clothes SLOTS
		public SerializedProperty  TShirtFemaleSLOT;
		public SlotData  TShirtFemaleNameSLOT;

		//Male Clothes OVERLAYS
		public SerializedProperty  UnderwearMaleOVERLAY;
		public SerializedProperty  ShirtMaleOVERLAY;
		public OverlayData  JeansMaleNameOVERLAY;
		public OverlayData  UnderwearMaleNameOVERLAY;
		public OverlayData  ShirtMaleNameOVERLAY;
		public SerializedProperty  JeansMaleColorOVERLAY;
		public SerializedProperty  UnderwearMaleColorOVERLAY;
		public SerializedProperty  ShirtMaleColorOVERLAY;
	
		//Female Clothes OVERLAYS
		public SerializedProperty  TShirtFemaleOVERLAY;
		public SerializedProperty  JeansFemaleOVERLAY;
		public SerializedProperty  UnderwearFemaleOVERLAY;
		public OverlayData  JeansFemaleNameOVERLAY;
		public OverlayData  TShirtFemaleNameOVERLAY;
		public OverlayData  UnderwearFemaleNameOVERLAY;
		public SerializedProperty  JeansFemaleColorOVERLAY;
		public SerializedProperty  TShirtFemaleColorOVERLAY;
		public SerializedProperty  UnderwearFemaleColorOVERLAY;
	

		//OTHER THINGS 
		public SlotData Jeans;
		public UMAModels umaModels;
		public SlotLibrary slotLibrary;
		public OverlayLibrary overlayLibrary;
		private UMADnaHumanoid umaDna;
		public UMAData umaData;
		public UMADynamicAvatar umaDynamicAvatar;
		public static bool randomValues = true;

		//SHAPES VALUES
		private static float Height= 0.5f;
		private static float HeadWidth= 0.5f;
		private static  float NeckThickness= 0.5f;
		private static  float ArmLength= 0.5f;
		private static  float HandsSize= 0.5f;
		private static  float FeetSize= 0.5f;
		private static  float LegSeparation= 0.5f;
		private static  float UpperMuscle= 0.5f;
		private static  float LowerMuscle= 0.5f;
		private static  float UpperWeight= 0.5f;
		private static  float LowerWeight= 0.5f;
		private static  float LegsSize= 0.5f;
		private static  float EarsSize= 0.5f;
		private static  float EarsPosition= 0.5f;
		private static  float EarsRotation= 0.5f;
		private static  float NoseSize= 0.5f;
		private static  float NoseCurve= 0.5f;
		private static  float NoseWidth= 0.5f;
		private static  float NoseInclination= 0.5f;
		private static  float NosePosition= 0.5f;
		private static  float NosePronounced= 0.5f;
		private static  float NoseFlatten= 0.5f;
		private static  float ChinSize= 0.5f;
		private static  float ChinPronounced= 0.5f;
		private static  float ChinPosition= 0.5f;
		private static  float MandibleSize= 0.5f;
		private static  float JawsSize= 0.5f;
		private static  float JawsPosition= 0.5f;
		private static  float CheekSize= 0.5f;
		private static  float CheekPosition= 0.5f;
		private static  float LowCheekPronounced= 0.5f;
		private static  float LowCheekPosition= 0.5f;
		private static  float ForeheadSize= 0.5f;
		private static  float ForeheadPosition= 0.5f;
		private static  float EyeSize= 0.5f;
		private static  float EyeRotation= 0.5f;
		private static  float LipsSize= 0.5f;
		private static  float MouthSize= 0.5f;
		private static  float BreastSize= 0.5f;
		private static  float GluteusSize= 0.5f;
		private static  float ArmWidth= 0.5f;
		private static  float ForearmLength= 0.5f;
		private static  float ForearmWidth= 0.5f;
		private static  float Belly= 0.5f;
		private static  float Waist= 0.5f;

		//More other things
		private bool oneTime = true;
		private bool reset = false;
		private bool semiReset = false;
		private static string mode;
	

		//Structure
		static private bool General = true;
		static private bool Body;
		static private bool BodyMale;
		static private bool BodyMaleSlots = true;
		static private bool BodyMaleOverlays;
		static private bool BodyFemale;
		static private bool BodyFemaleSlots = true;
		static private bool BodyFemaleOverlays;
		static private bool Clothes;
		static private bool ClothesMale;
		static private bool ClothesMaleSlots = true;
		static private bool ClothesMaleOverlays;
		static private bool ClothesFemale;
		static private bool ClothesFemaleSlots = true;
		static private bool ClothesFemaleOverlays;
		static private bool Physical;
		static private bool Custom;
		static private bool CustomMale;
		static private bool CustomFemale;
		static private string stateLabel = "";

		//Male CUSTOM 
		public SerializedProperty  MaleCustomSLOT;
		public int MaleCustomSLOTNumber;
		public bool SlotMale;
		public SlotData slotDataMale;
		public bool OverlayMale;
		public OverlayData overlayDataMale;
		public Color  MaleCustomColor;

		//Female CUSTOM 
		public SerializedProperty  FemaleCustomSLOT;
		public int FemaleCustomSLOTNumber;
		public bool[] SlotFemale;
		public SlotData[] slotDataFemale;
		public bool[] OverlayFemale;
		public OverlayData[] overlayDataFemale;
		public Color  FemaleCustomColor;

		Vector2 scrollPos;
		Vector2 scrollPos2;


		void Awake ()
		{
				umaModels = GameObject.Find ("UMAModels").GetComponent<UMAModels> ();
				slotLibrary = GameObject.Find ("SlotLibrary").GetComponent<SlotLibrary> ();
				overlayLibrary = GameObject.Find("OverlayLibrary").GetComponent<OverlayLibrary> ();
				mode = EditorPrefs.GetString ("Mode");
				
				if (mode == "General") {
						General = true;
						Body = false;
						Clothes = false;
						Physical = false;
						Custom = false;
				}


				if (mode == "Body") {
						Body = true;
						Clothes = false;
						Physical = false;
						General = false;
						Custom = false;
				}

				if (mode == "Clothes") {
						Clothes = true;
						Body = false;
						Physical = false;
						General = false;
						Custom = false;
				}

				if (mode == "Physical") {
						Physical = true;
						Body = false;
						Clothes = false;
						General = false;
						Custom = false;
				}

				if (mode == "Custom") {
						General = false;
						Body = false;
						Clothes = false;
						Physical = false;
						Custom = true;
				}

				randomValues = EditorPrefs.GetBool ("RandomValues");
				Height = EditorPrefs.GetFloat ("Height");
				HeadWidth = EditorPrefs.GetFloat ("HeadWidth");
				NeckThickness = EditorPrefs.GetFloat ("NeckThickness");
				ArmLength = EditorPrefs.GetFloat ("ArmLength");
				HandsSize = EditorPrefs.GetFloat ("HandsSize");
				FeetSize = EditorPrefs.GetFloat ("FeetSize");
				LegSeparation = EditorPrefs.GetFloat ("LegSeparation");
				UpperMuscle = EditorPrefs.GetFloat ("UpperMuscle");
				LowerMuscle = EditorPrefs.GetFloat ("LowerMuscle");
				UpperWeight = EditorPrefs.GetFloat ("UpperWeight");
				LowerWeight = EditorPrefs.GetFloat ("LowerWeight");
				LegsSize = EditorPrefs.GetFloat ("LegsSize");
				EarsSize = EditorPrefs.GetFloat ("EarsSize");
				EarsPosition = EditorPrefs.GetFloat ("EarsPosition");
				EarsRotation = EditorPrefs.GetFloat ("EarsRotation");
				NoseSize = EditorPrefs.GetFloat ("NoseSize");
				NoseWidth = EditorPrefs.GetFloat ("NoseWidth");
				NoseInclination = EditorPrefs.GetFloat ("NoseInclination");
				NosePosition = EditorPrefs.GetFloat ("NosePosition");
				NosePronounced = EditorPrefs.GetFloat ("NosePronounced");
				NoseFlatten = EditorPrefs.GetFloat ("NoseFlatten");
				ChinSize = EditorPrefs.GetFloat ("ChinSize");
				ChinPronounced = EditorPrefs.GetFloat ("ChinPronounced");
				ChinPosition = EditorPrefs.GetFloat ("ChinPosition");
				MandibleSize = EditorPrefs.GetFloat ("MandibleSize");
				JawsSize = EditorPrefs.GetFloat ("JawsSize");
				JawsPosition = EditorPrefs.GetFloat ("JawsPosition");
				CheekSize = EditorPrefs.GetFloat ("CheekSize");
				CheekPosition = EditorPrefs.GetFloat ("CheekPosition");
				LowCheekPronounced = EditorPrefs.GetFloat ("LowCheekPronounced");
				LowCheekPosition = EditorPrefs.GetFloat ("LowCheekPosition");
				ForeheadSize = EditorPrefs.GetFloat ("ForeheadSize");
				ForeheadPosition = EditorPrefs.GetFloat ("ForeheadPosition");
				EyeSize = EditorPrefs.GetFloat ("EyeSize");
				EyeRotation = EditorPrefs.GetFloat ("EyeRotation");
				LipsSize = EditorPrefs.GetFloat ("LipsSize");
				MouthSize = EditorPrefs.GetFloat ("MouthSize");
				BreastSize = EditorPrefs.GetFloat ("BreastSize");
				GluteusSize = EditorPrefs.GetFloat ("GluteusSize");
				ArmWidth = EditorPrefs.GetFloat ("ArmWidth");
				ForearmLength = EditorPrefs.GetFloat ("ForearmLength");
				ForearmWidth = EditorPrefs.GetFloat ("ForearmWidth");
				Belly = EditorPrefs.GetFloat ("Belly");
				Waist = EditorPrefs.GetFloat ("Waist");
		}

		private void DropAreaGUI (Rect dropArea)
		{
		
				var evt = Event.current;
		
				if (evt.type == EventType.DragUpdated) {
						if (dropArea.Contains (evt.mousePosition)) {
								DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
						}
				}
		
				if (evt.type == EventType.DragPerform) {
						if (dropArea.Contains (evt.mousePosition)) {			
								DragAndDrop.AcceptDrag ();
				
								UnityEngine.Object[] draggedObjects = DragAndDrop.objectReferences as UnityEngine.Object[];
								if(draggedObjects.Length ==1){
										if(CustomMale){
											if (draggedObjects [0].GetType() == typeof(SlotData)) {
											SlotData slotD = draggedObjects[0] as SlotData;
											umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Add(null);
											umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count-2)].Slot = true;
											umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count-2)].slotData = draggedObjects[0] as SlotData;
											slotLibrary.AddSlot(slotD);
											umaModels.slotsNumberMale = umaModels.slotsNumberMale + 1;
											}
											else if (draggedObjects [0].GetType() == typeof(OverlayData)) {
											OverlayData overlayD = draggedObjects[0] as OverlayData;
											umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Add(null);
											umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count-2)].Overlay = true;
											umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count-2)].overlayData = draggedObjects[0] as OverlayData;
											overlayLibrary.AddOverlay(overlayD);
											umaModels.slotsNumberMale = umaModels.slotsNumberMale + 1;
											}
										}		
										if(CustomFemale){
											if (draggedObjects [0].GetType() == typeof(SlotData)) {
												SlotData slotD = draggedObjects[0] as SlotData;
												umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Add(null);
												umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count-2)].Slot = true;
												umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count-2)].slotData = draggedObjects[0] as SlotData;
												slotLibrary.AddSlot(slotD);
												umaModels.slotsNumberFemale = umaModels.slotsNumberFemale + 1;
											}
											else if (draggedObjects [0].GetType() == typeof(OverlayData)) {
												OverlayData overlayD = draggedObjects[0] as OverlayData;
												umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Add(null);
												umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count-2)].Overlay = true;
												umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count-2)].overlayData = draggedObjects[0] as OverlayData;
												overlayLibrary.AddOverlay(overlayD);
												umaModels.slotsNumberFemale = umaModels.slotsNumberFemale + 1;
											}
										}

										
										
										
								}
						}
				}
		}



		void OnEnable ()
		{

				Male = serializedObject.FindProperty ("modifiers.Male");  
				Female = serializedObject.FindProperty ("modifiers.Female");
				SkinColor = serializedObject.FindProperty ("modifiers.skinColor");
				SpawnPoint = serializedObject.FindProperty ("SpawnPoint");

				MaleCustomSLOT = serializedObject.FindProperty ("modifiers.testModels.customMeshesAndClothes.maleCustom.customList");
				FemaleCustomSLOT = serializedObject.FindProperty ("modifiers.testModels.customMeshesAndClothes.femaleCustom.customList");

				//Male SLOTS
				MaleHeadSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.head");
				MaleHeadEyesSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEyes");
				MaleHeadMouthSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMouth");
				MaleHeadNoseSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headNose");
				MaleHeadEarsSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEars");
				MaleHeadNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMaleSlot;
				MaleHeadEyesNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEyesMaleSlot;
				MaleHeadMouthNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMouthMaleSlot;
				MaleHeadNoseNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headNoseMaleSlot;
				MaleHeadEarsNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEarsMaleSlot;
		
				MaleFaceSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.face");
				MaleEyesSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.eyes");
				MaleTorsoSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.torso");
				MaleHandsSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.hands");
				MaleInnerMouthSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.innerMouth");
				MaleLegsSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.legs");
				MaleFeetSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.feet");
				MaleFaceNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.faceMaleSlot;
				MaleEyesNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.eyesMaleSlot;
				MaleTorsoNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.torsoMaleSlot;
				MaleHandsNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.handsMaleSlot;
				MaleInnerMouthNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.innerMouthMaleSlot;
				MaleLegsNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.legsMaleSlot;
				MaleFeetNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.feetMaleSlot;

				//Male OVERLAYS
				HairMale = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hair");
				Beard = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard");
				Beard2 = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2");
				EyebrowMale = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrow");

				hairMaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hairMaleOverlayColor");
				beardMaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beardMaleOverlayColor");
				beard2MaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2MaleOverlayColor");
				eyeBrowMaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrowMaleOverlayColor");
				eyesMaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlayColor");
				innerMouthMaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.innerMouthMaleOverlayColor");

				MaleHairNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hairMaleOverlay;
				MaleBeardNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beardMaleOverlay;
				MaleBeard2NameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2MaleOverlay;
				MaleEyebrowNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrowMaleOverlay;
				MaleFaceNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.faceMaleOverlay;
				MaleHeadNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.headMaleOverlay;
				MaleEyesNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlay;
				MaleMouthNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.mouthMaleOverlay;
				MaleEarsNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.earsMaleOverlay;
				MaleTorsoNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.torsoMaleOverlay;
				MaleHandsNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.handsMaleOverlay;
				MaleInnerMouthNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.innerMouthMaleOverlay;
				MaleLegsNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.legsMaleOverlay;
				MaleFeetNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.feetMaleOverlay;


				//Female SLOTS
				FemaleHairSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hair");
				FemaleHeadSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headFemale");
				FemaleHeadEyesSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEyesFemale");
				FemaleHeadMouthSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headMouthFemale");
				FemaleHeadNoseSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headNoseFemale");
				FemaleHeadEarsSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEarsFemale");
				FemaleHairNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hairFemaleSlot;
				FemaleHeadNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headFemaleSlot;
				FemaleHeadEyesNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEyesFemaleSlot;
				FemaleHeadMouthNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headMouthFemaleSlot;
				FemaleHeadNoseNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headNoseFemaleSlot;
				FemaleHeadEarsNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEarsFemaleSlot;
		
				FemaleFaceSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.face");
				FemaleEyesSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.eyes");
				FemaleTorsoSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.torso");
				FemaleHandsSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hands");
				FemaleInnerMouthSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.innerMouth");
				FemaleLegsSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.legs");
				FemaleFeetSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.feet");
				FemaleFaceNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.faceFemaleSlot;
				FemaleEyesNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.eyesFemaleSlot;
				FemaleTorsoNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.torsoFemaleSlot;
				FemaleHandsNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.handsFemaleSlot;
				FemaleInnerMouthNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.innerMouthFemaleSlot;
				FemaleLegsNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.legsFemaleSlot;
				FemaleFeetNameSLOT = umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.feetFemaleSlot;
		
				//Female OVERLAYS
				FemaleLipstick = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.lipStick");
				FemaleEyebrow = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrow");


				hairFemaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlayColor");
				lipStickFemaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.lipStickFemaleOverlayColor");
				eyeBrowFemaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlayColor");
				eyesFemaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlayColor");
				innerMouthFemaleOverlayColor = serializedObject.FindProperty ("modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.innerMouthFemaleOverlayColor");

				FemaleLipstickNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.lipStickFemaleOverlay;
				FemaleEyebrowNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlay;
				FemaleHairNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlay;
				FemaleHairNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlay;
				FemaleEyebrowNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlay;
				FemaleFaceNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.faceFemaleOverlay;
				FemaleHeadNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.headFemaleOverlay;
				FemaleEyesNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlay;
				FemaleMouthNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.mouthFemaleOverlay;
				FemaleEarsNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.earsFemaleOverlay;
				FemaleTorsoNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.torsoFemaleOverlay;
				FemaleHandsNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.handsFemaleOverlay;
				FemaleInnerMouthNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.innerMouthFemaleOverlay;
				FemaleLegsNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.legsFemaleOverlay;
				FemaleFeetNameOVERLAY = umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.feetFemaleOverlay;


				//Male Clothes SLOTS
				JeansMaleSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsClothes.maleSlotClothes.jeans");
				JeansMaleNameSLOT = umaModels.modifiers.testModels.slotsClothes.maleSlotClothes.jeansMaleSlot;
		
				//Female Clothes SLOTS
				TShirtFemaleSLOT = serializedObject.FindProperty ("modifiers.testModels.slotsClothes.femaleSlotClothes.tShirt");
				TShirtFemaleNameSLOT = umaModels.modifiers.testModels.slotsClothes.femaleSlotClothes.tShirtFemaleSlot;
		
				//Male Clothes OVERLAYS
				ShirtMaleOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.maleOverlayClothes.shirt");
				UnderwearMaleOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.maleOverlayClothes.underwear");

				JeansMaleNameOVERLAY = umaModels.modifiers.testModels.overlaysClothes.maleOverlayClothes.jeansMaleOverlay;
				UnderwearMaleNameOVERLAY = umaModels.modifiers.testModels.overlaysClothes.maleOverlayClothes.underwearMaleOverlay;
				ShirtMaleNameOVERLAY = umaModels.modifiers.testModels.overlaysClothes.maleOverlayClothes.shirtMaleOverlay;

				JeansMaleColorOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.maleOverlayClothes.jeansMaleOverlayColor");
				UnderwearMaleColorOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.maleOverlayClothes.underwearMaleOverlayColor");
				ShirtMaleColorOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.maleOverlayClothes.shirtMaleOverlayColor");

				//Female Clothes OVERLAYS
				TShirtFemaleOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.femaleOverlayClothes.shirt");
				UnderwearFemaleOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwear");
				JeansFemaleOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeans");
		
				JeansFemaleNameOVERLAY = umaModels.modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeansFemaleOverlay;
				TShirtFemaleNameOVERLAY = umaModels.modifiers.testModels.overlaysClothes.femaleOverlayClothes.tShirtFemaleOverlay;
				UnderwearFemaleNameOVERLAY = umaModels.modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwearFemaleOverlay;

				JeansFemaleColorOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeansFemaleOverlayColor");
				TShirtFemaleColorOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.femaleOverlayClothes.tShirtFemaleOverlayColor");
				UnderwearFemaleColorOVERLAY = serializedObject.FindProperty ("modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwearFemaleOverlayColor");


		 
		}


		//Interface
		public override void OnInspectorGUI ()
		{
				//Serialized!
				serializedObject.Update ();
				EditorGUILayout.BeginHorizontal ();
				EditorGUILayout.Space ();
				EditorGUILayout.LabelField(new GUIContent(Logo),GUILayout.Width(256),GUILayout.Height(128));
				EditorGUILayout.Space ();
				EditorGUILayout.EndHorizontal ();
				EditorGUILayout.Space ();
				EditorGUILayout.LabelField ("Customization Modes", EditorStyles.boldLabel);

				//Buttons
				EditorGUILayout.BeginHorizontal ();

				if (GUILayout.Button ("General")) {
			
						General = true;
						Body = false;
						Clothes = false;
						Physical = false;
						Custom = false;
				}	

				if (GUILayout.Button ("Body")) {
						Body = true;
						Clothes = false;
						Physical = false;
						General = false;
						Custom = false;
				}

				if (GUILayout.Button ("Clothes")) {
						Clothes = true;
						Body = false;
						Physical = false;
						General = false;
						Custom = false;
				}

				if (GUILayout.Button ("Physical")) {
						Physical = true;
						Body = false;
						Clothes = false;
						General = false;
						Custom = false;
				}

				if (GUILayout.Button ("Custom")) {
						Physical = false;
						Body = false;
						Clothes = false;
						General = false;
						Custom = true;
				}

				EditorGUILayout.EndHorizontal ();
				EditorGUILayout.HelpBox (stateLabel, MessageType.Info);

				if (Custom) {

						stateLabel = "You are now in CUSTOM mode";
						EditorPrefs.SetString ("Mode", "Custom");

						//Sex
						EditorGUILayout.BeginHorizontal ();
			
						if (GUILayout.Button ("Male")) {
								CustomFemale = false;
								CustomMale = true;
				
						}
			
						if (GUILayout.Button ("Female")) {
								CustomMale = false;
								CustomFemale = true;
						}

			EditorGUILayout.EndHorizontal ();

			if(CustomMale){
			EditorGUILayout.HelpBox ("You are now editing MALE custom slots/overlays", MessageType.Warning);
			EditorGUILayout.BeginHorizontal ();

			//	System.Array.Resize<UMAModels.UMAModifiers.UMATestModels.CUSTOMMeshesAndClothes.Male.CustomList>(ref umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList, MaleCustomSLOTNumber);
			
			if (GUILayout.Button ("+ Slot/Overlay")) {
					umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Add(null);
					umaModels.slotsNumberMale = umaModels.slotsNumberMale + 1;
				// this line works good	umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList = new UMAModels.UMAModifiers.UMATestModels.CUSTOMMeshesAndClothes.Male.CustomList[MaleCustomSLOTNumber];
			}
			if (GUILayout.Button ("- Slot/Overlay")) {
					if(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count > 0){
					umaModels.slotsNumberMale = umaModels.slotsNumberMale - 1;
					}
					umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Remove(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList[umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count-1]);
				// this line works good	umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList = new UMAModels.UMAModifiers.UMATestModels.CUSTOMMeshesAndClothes.Male.CustomList[MaleCustomSLOTNumber];
			}
			
			
			
			EditorGUILayout.EndHorizontal ();
			for (int i = 0; i < umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count-1; i++) {
				EditorGUILayout.Space ();
				EditorGUILayout.LabelField ("Element " + i + ":",EditorStyles.boldLabel);
				EditorGUILayout.BeginHorizontal ();
				EditorGUILayout.BeginVertical ();
					EditorGUILayout.BeginHorizontal ();
				umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].Slot = EditorGUILayout.Toggle (new GUIContent("Slot"),umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].Slot);
				umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].slotData = EditorGUILayout.ObjectField (umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].slotData, typeof(SlotData), false) as SlotData;
					if(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].slotData != null){
						slotLibrary.AddSlot(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].slotData);
						if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].slotData.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
							EditorGUIUtility.PingObject (umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].slotData);
					}
					}
					EditorGUILayout.EndHorizontal ();
					EditorGUILayout.BeginHorizontal ();
					umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].Overlay = EditorGUILayout.Toggle (new GUIContent("Overlay"),umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].Overlay);
					umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayData = EditorGUILayout.ObjectField (umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayData, typeof(OverlayData), false) as OverlayData;
					if(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayData != null){
						overlayLibrary.AddOverlay(umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayData);
						if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayData.textureList[0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
							EditorGUIUtility.PingObject (umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayData);
						}
					}
				EditorGUILayout.EndHorizontal ();
				EditorGUILayout.BeginHorizontal ();
				umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayColor = EditorGUILayout.ColorField (new GUIContent("Color"),umaModels.modifiers.testModels.customMeshesAndClothes.maleCustom.customList [i].overlayColor);
				EditorGUILayout.EndHorizontal ();
				EditorGUILayout.EndVertical ();
				EditorGUILayout.EndHorizontal ();

				
			}
				Rect dropArea2 = GUILayoutUtility.GetRect(0.0f,50.0f, GUILayout.ExpandWidth(true));
				GUI.Box(dropArea2,"");
				GUI.Label(new Rect((GUILayoutUtility.GetLastRect().x+120),(dropArea2.y+20),dropArea2.width,dropArea2.height),"Drop it!",EditorStyles.boldLabel);
				DropAreaGUI(dropArea2);
			}

			if(CustomFemale){
				EditorGUILayout.HelpBox ("You are now editing FEMALE custom slots/overlays", MessageType.Warning);
				EditorGUILayout.BeginHorizontal ();
				
				//	System.Array.Resize<UMAModels.UMAModifiers.UMATestModels.CUSTOMMeshesAndClothes.Female.CustomList>(ref umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList, FemaleCustomSLOTNumber);
				
				if (GUILayout.Button ("+ Slot/Overlay")) {
					umaModels.slotsNumberFemale = umaModels.slotsNumberFemale + 1;
					umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Add(null);
					// this line works good	umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList = new UMAModels.UMAModifiers.UMATestModels.CUSTOMMeshesAndClothes.Female.CustomList[FemaleCustomSLOTNumber];
				}
				if (GUILayout.Button ("- Slot/Overlay")) {
					if(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count > 0){
						umaModels.slotsNumberFemale = umaModels.slotsNumberFemale - 1;
					}
					umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Remove(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count-1]);

					// this line works good	umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList = new UMAModels.UMAModifiers.UMATestModels.CUSTOMMeshesAndClothes.Female.CustomList[FemaleCustomSLOTNumber];
				}
				
				EditorGUILayout.EndHorizontal ();
				

				for (int i = 0; i < umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count-1; i++) {
					EditorGUILayout.Space ();
					EditorGUILayout.LabelField ("Element " + i + ":",EditorStyles.boldLabel);
					EditorGUILayout.BeginHorizontal ();
					EditorGUILayout.BeginVertical ();
					EditorGUILayout.BeginHorizontal ();
					umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].Slot = EditorGUILayout.Toggle (new GUIContent("Slot"),umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].Slot);
					umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].slotData = EditorGUILayout.ObjectField (umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].slotData, typeof(SlotData), false) as SlotData;
					
					if(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].slotData != null){

						slotLibrary.AddSlot(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].slotData);
						if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].slotData.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
							EditorGUIUtility.PingObject (umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].slotData);
						}
					}

					EditorGUILayout.EndHorizontal ();
					EditorGUILayout.BeginHorizontal ();
					umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].Overlay = EditorGUILayout.Toggle (new GUIContent("Overlay"),umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].Overlay);
					umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayData = EditorGUILayout.ObjectField (umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayData, typeof(OverlayData), false) as OverlayData;

					if(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayData != null){
						overlayLibrary.AddOverlay(umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayData);
						if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayData.textureList[0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
							EditorGUIUtility.PingObject (umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayData);
						}
					}
					EditorGUILayout.EndHorizontal ();
					EditorGUILayout.BeginHorizontal ();
					umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayColor = EditorGUILayout.ColorField (new GUIContent("Color"),umaModels.modifiers.testModels.customMeshesAndClothes.femaleCustom.customList [i].overlayColor);
					EditorGUILayout.EndHorizontal ();
					EditorGUILayout.EndVertical ();
					EditorGUILayout.EndHorizontal ();
					
					
				}
				Rect dropArea2 = GUILayoutUtility.GetRect(0.0f,50.0f, GUILayout.ExpandWidth(true));
				GUI.Box(dropArea2,"");
				GUI.Label(new Rect((GUILayoutUtility.GetLastRect().x+120),(dropArea2.y+20),dropArea2.width,dropArea2.height),"Drop it!",EditorStyles.boldLabel);
				DropAreaGUI(dropArea2);
			}

					


		}

				//Body Mode
				if (Body) {
						stateLabel = "You are now in BODY mode";
						EditorPrefs.SetString ("Mode", "Body");

						//Sex
						EditorGUILayout.BeginHorizontal ();

						if (GUILayout.Button ("Male")) {
								BodyFemale = false;
								BodyMale = true;
			
						}

						if (GUILayout.Button ("Female")) {
								BodyMale = false;
								BodyFemale = true;
						}
		
		

						EditorGUILayout.EndHorizontal ();

						if (BodyMale) {

								if (BodyMaleSlots) {
										EditorGUILayout.HelpBox ("You are now editing MALE Slots", MessageType.Warning);
										scrollPos = EditorGUILayout.BeginScrollView (scrollPos, GUILayout.Height (310), GUILayout.ExpandWidth (true));
										//Head - Head

										EditorGUILayout.BeginHorizontal ();
										if (GUILayout.Button ("Slots")) {
												BodyMaleSlots = true;
												BodyMaleOverlays = false;
										}

										if (GUILayout.Button ("Overlays")) {
												BodyMaleSlots = false;
												BodyMaleOverlays = true;
										}


										EditorGUILayout.EndHorizontal ();
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleHeadSLOT);
										
												MaleHeadNameSLOT = EditorGUILayout.ObjectField (MaleHeadNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMaleSlot = MaleHeadNameSLOT as SlotData;
					if (MaleHeadNameSLOT != null) {
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHeadNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHeadNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();


										//Head - Eyes
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
				
										EditorGUILayout.PropertyField (MaleHeadEyesSLOT);
										
												MaleHeadEyesNameSLOT = EditorGUILayout.ObjectField (MaleHeadEyesNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEyesMaleSlot = MaleHeadEyesNameSLOT as SlotData;
						if (MaleHeadEyesNameSLOT != null) {
						slotLibrary.AddSlot(MaleHeadEyesNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHeadEyesNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHeadEyesNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Head - Mouth
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleHeadMouthSLOT);
										
												MaleHeadMouthNameSLOT = EditorGUILayout.ObjectField (MaleHeadMouthNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMouthMaleSlot = MaleHeadMouthNameSLOT as SlotData;
					if (MaleHeadMouthNameSLOT != null) {
					slotLibrary.AddSlot(MaleHeadMouthNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHeadMouthNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHeadMouthNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Head - Nose
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleHeadNoseSLOT);
										
												MaleHeadNoseNameSLOT = EditorGUILayout.ObjectField (MaleHeadNoseNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headNoseMaleSlot = MaleHeadNoseNameSLOT as SlotData;
					if (MaleHeadNoseNameSLOT != null) {
						slotLibrary.AddSlot(MaleHeadNoseNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHeadNoseNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHeadNoseNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Head - Ears
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleHeadEarsSLOT);
										
												MaleHeadEarsNameSLOT = EditorGUILayout.ObjectField (MaleHeadEarsNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEarsMaleSlot = MaleHeadEarsNameSLOT as SlotData;
					if (MaleHeadEarsNameSLOT != null) {
						slotLibrary.AddSlot(MaleHeadEarsNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHeadEarsNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHeadEarsNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Face
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleFaceSLOT);
										
												MaleFaceNameSLOT = EditorGUILayout.ObjectField (MaleFaceNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.faceMaleSlot = MaleFaceNameSLOT as SlotData;
					if (MaleFaceNameSLOT != null) {
						slotLibrary.AddSlot(MaleFaceNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleFaceNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleFaceNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Eyes
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleEyesSLOT);
										
												MaleEyesNameSLOT = EditorGUILayout.ObjectField (MaleEyesNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.eyesMaleSlot = MaleEyesNameSLOT as SlotData;
					if (MaleEyesNameSLOT != null) {
						slotLibrary.AddSlot(MaleEyesNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleEyesNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleEyesNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Torso
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleTorsoSLOT);
										
												MaleTorsoNameSLOT = EditorGUILayout.ObjectField (MaleTorsoNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.torsoMaleSlot = MaleTorsoNameSLOT as SlotData;
					if (MaleTorsoNameSLOT != null) {
						slotLibrary.AddSlot(MaleTorsoNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleTorsoNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleTorsoNameSLOT);
												}
										}
										GUILayout.EndHorizontal ();

										//Hands
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleHandsSLOT);
										
												MaleHandsNameSLOT = EditorGUILayout.ObjectField (MaleHandsNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.handsMaleSlot = MaleHandsNameSLOT as SlotData;
					if (MaleHandsNameSLOT != null) {
						slotLibrary.AddSlot(MaleHandsNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHandsNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHandsNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//InnerMouth
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleInnerMouthSLOT);
										
												MaleInnerMouthNameSLOT = EditorGUILayout.ObjectField (MaleInnerMouthNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.innerMouthMaleSlot = MaleInnerMouthNameSLOT as SlotData;
					if (MaleInnerMouthNameSLOT != null) {
						slotLibrary.AddSlot(MaleInnerMouthNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleInnerMouthNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleInnerMouthNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Legs
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleLegsSLOT);
										
												MaleLegsNameSLOT = EditorGUILayout.ObjectField (MaleLegsNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.legsMaleSlot = MaleLegsNameSLOT as SlotData;
					if (MaleLegsNameSLOT != null) {
						slotLibrary.AddSlot(MaleLegsNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleLegsNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleLegsNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Feet
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (MaleFeetSLOT);
										
												MaleFeetNameSLOT = EditorGUILayout.ObjectField (MaleFeetNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.feetMaleSlot = MaleFeetNameSLOT as SlotData;
										if (MaleFeetNameSLOT != null) {
						slotLibrary.AddSlot(MaleFeetNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleFeetNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleFeetNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
										EditorGUILayout.EndScrollView ();
								}

					
								if (BodyMaleOverlays) {
										EditorGUILayout.HelpBox ("You are now editing MALE Overlays", MessageType.Warning);
										scrollPos = EditorGUILayout.BeginScrollView (scrollPos, GUILayout.Height (310), GUILayout.ExpandWidth (true));
										EditorGUILayout.BeginHorizontal ();
										if (GUILayout.Button ("Slots")) {
												BodyMaleSlots = true;
												BodyMaleOverlays = false;
										}
					
										if (GUILayout.Button ("Overlays")) {
												BodyMaleSlots = false;
												BodyMaleOverlays = true;
										}
										EditorGUILayout.EndHorizontal ();

										EditorGUILayout.Space ();

										//Hair
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (HairMale);
										
												MaleHairNameOVERLAY = EditorGUILayout.ObjectField (MaleHairNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hairMaleOverlay = MaleHairNameOVERLAY as OverlayData;
					if (MaleHairNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleHairNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), hairMaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHairNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHairNameOVERLAY);
												}
										}
				
										EditorGUILayout.EndHorizontal ();

										//Beard
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (Beard);
										
												MaleBeardNameOVERLAY = EditorGUILayout.ObjectField (MaleBeardNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beardMaleOverlay = MaleBeardNameOVERLAY as OverlayData;
					if (MaleBeardNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleBeardNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), beardMaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleBeardNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleBeardNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Beard2
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (Beard2);
										
												MaleBeard2NameOVERLAY = EditorGUILayout.ObjectField (MaleBeard2NameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2MaleOverlay = MaleBeard2NameOVERLAY as OverlayData;
					if (MaleBeard2NameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleBeard2NameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), beard2MaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleBeard2NameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleBeard2NameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Eyebrow
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (EyebrowMale);
										
												MaleEyebrowNameOVERLAY = EditorGUILayout.ObjectField (MaleEyebrowNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrowMaleOverlay = MaleEyebrowNameOVERLAY as OverlayData;
					if (MaleEyebrowNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleEyebrowNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), eyeBrowMaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleEyebrowNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleEyebrowNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();


										//Face
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Face", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleFaceNameOVERLAY = EditorGUILayout.ObjectField (MaleFaceNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.faceMaleOverlay = MaleFaceNameOVERLAY as OverlayData;
					if (MaleFaceNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleFaceNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleFaceNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleFaceNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Head
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Head", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleHeadNameOVERLAY = EditorGUILayout.ObjectField (MaleHeadNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.headMaleOverlay = MaleHeadNameOVERLAY as OverlayData;
					if (MaleHeadNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleHeadNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHeadNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHeadNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Eyes
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Eyes", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleEyesNameOVERLAY = EditorGUILayout.ObjectField (MaleEyesNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlay = MaleEyesNameOVERLAY as OverlayData;
					if (MaleEyesNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleEyesNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), eyesMaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleEyesNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleEyesNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Mouth
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Mouth", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleMouthNameOVERLAY = EditorGUILayout.ObjectField (MaleMouthNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.mouthMaleOverlay = MaleMouthNameOVERLAY as OverlayData;
					if (MaleMouthNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleMouthNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleMouthNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleMouthNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Ears
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Ears", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleEarsNameOVERLAY = EditorGUILayout.ObjectField (MaleEarsNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.earsMaleOverlay = MaleEarsNameOVERLAY as OverlayData;
					if (MaleEarsNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleEarsNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleEarsNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleEarsNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();


										//Torso
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Torso", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleTorsoNameOVERLAY = EditorGUILayout.ObjectField (MaleTorsoNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.torsoMaleOverlay = MaleTorsoNameOVERLAY as OverlayData;
					if (MaleTorsoNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleTorsoNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleTorsoNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleTorsoNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Hands
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Hands", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleHandsNameOVERLAY = EditorGUILayout.ObjectField (MaleHandsNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.handsMaleOverlay = MaleHandsNameOVERLAY as OverlayData;
					if (MaleHandsNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleHandsNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleHandsNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleHandsNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//InnerMouth
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("InnerMouth", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleInnerMouthNameOVERLAY = EditorGUILayout.ObjectField (MaleInnerMouthNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.innerMouthMaleOverlay = MaleInnerMouthNameOVERLAY as OverlayData;
					if (MaleInnerMouthNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleInnerMouthNameOVERLAY);
						EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), innerMouthMaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleInnerMouthNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleInnerMouthNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
				
										//Legs
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Legs", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												MaleLegsNameOVERLAY = EditorGUILayout.ObjectField (MaleLegsNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.legsMaleOverlay = MaleLegsNameOVERLAY as OverlayData;
												if (MaleLegsNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleLegsNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleLegsNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleLegsNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();


										//Feet
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Feet", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										MaleFeetNameOVERLAY = EditorGUILayout.ObjectField (MaleFeetNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
										umaModels.modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.feetMaleOverlay = MaleFeetNameOVERLAY as OverlayData;
										if (MaleFeetNameOVERLAY != null) {
						overlayLibrary.AddOverlay(MaleFeetNameOVERLAY);
										EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (MaleFeetNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (MaleFeetNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										EditorGUILayout.EndScrollView ();

								}
						}
						if (BodyFemale) {


//Female Slots
								if (BodyFemaleSlots) {

										EditorGUILayout.HelpBox ("You are now editing FEMALE Slots", MessageType.Warning);
										scrollPos2 = EditorGUILayout.BeginScrollView (scrollPos2, GUILayout.Height (310), GUILayout.ExpandWidth (true));

										EditorGUILayout.BeginHorizontal ();
										if (GUILayout.Button ("Slots")) {
												BodyFemaleSlots = true;
												BodyFemaleOverlays = false;
										}
					
										if (GUILayout.Button ("Overlays")) {
												BodyFemaleSlots = false;
												BodyFemaleOverlays = true;
										}
										EditorGUILayout.EndHorizontal ();

										EditorGUILayout.Space ();

										//Hair
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleHairSLOT);
										FemaleHairNameSLOT = EditorGUILayout.ObjectField (FemaleHairNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
										umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hairFemaleSlot = FemaleHairNameSLOT as SlotData;
										if (FemaleHairNameSLOT != null) {
						slotLibrary.AddSlot(FemaleHairNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHairNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHairNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										EditorGUILayout.Space ();
										//Head - Head
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleHeadSLOT);
										
												FemaleHeadNameSLOT = EditorGUILayout.ObjectField (FemaleHeadNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headFemaleSlot = FemaleHeadNameSLOT as SlotData;
									if (FemaleHeadNameSLOT != null) {
						slotLibrary.AddSlot(FemaleHeadNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHeadNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHeadNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();

										//Head - Eyes
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleHeadEyesSLOT);
									
												FemaleHeadEyesNameSLOT = EditorGUILayout.ObjectField (FemaleHeadEyesNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEyesFemaleSlot = FemaleHeadEyesNameSLOT as SlotData;
						if (FemaleHeadEyesNameSLOT != null) {
						slotLibrary.AddSlot(FemaleHeadEyesNameSLOT);
						if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHeadEyesNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHeadEyesNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Head - Mouth
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleHeadMouthSLOT);
										
												FemaleHeadMouthNameSLOT = EditorGUILayout.ObjectField (FemaleHeadMouthNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headMouthFemaleSlot = FemaleHeadMouthNameSLOT as SlotData;
					if (FemaleHeadMouthNameSLOT != null) {
						slotLibrary.AddSlot(FemaleHeadMouthNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHeadMouthNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHeadMouthNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Head - Nose
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleHeadNoseSLOT);
										
												FemaleHeadNoseNameSLOT = EditorGUILayout.ObjectField (FemaleHeadNoseNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headNoseFemaleSlot = FemaleHeadNoseNameSLOT as SlotData;
											if (FemaleHeadNoseNameSLOT != null) {
						slotLibrary.AddSlot(FemaleHeadNoseNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHeadNoseNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHeadNoseNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Head - Ears
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleHeadEarsSLOT);
										
												FemaleHeadEarsNameSLOT = EditorGUILayout.ObjectField (FemaleHeadEarsNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEarsFemaleSlot = FemaleHeadEarsNameSLOT as SlotData;
					if (FemaleHeadEarsNameSLOT != null) {
						slotLibrary.AddSlot(FemaleHeadEarsNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHeadEarsNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHeadEarsNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Face
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleFaceSLOT);
										
												FemaleFaceNameSLOT = EditorGUILayout.ObjectField (FemaleFaceNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.faceFemaleSlot = FemaleFaceNameSLOT as SlotData;
										if (FemaleFaceNameSLOT != null) {
						slotLibrary.AddSlot(FemaleFaceNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleFaceNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleFaceNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Eyes
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleEyesSLOT);
										
												FemaleEyesNameSLOT = EditorGUILayout.ObjectField (FemaleEyesNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.eyesFemaleSlot = FemaleEyesNameSLOT as SlotData;
							if (FemaleEyesNameSLOT != null) {
						slotLibrary.AddSlot(FemaleEyesNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleEyesNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleEyesNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Torso
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleTorsoSLOT);
										
												FemaleTorsoNameSLOT = EditorGUILayout.ObjectField (FemaleTorsoNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.torsoFemaleSlot = FemaleTorsoNameSLOT as SlotData;
						if (FemaleTorsoNameSLOT != null) {
						slotLibrary.AddSlot(FemaleTorsoNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleTorsoNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleTorsoNameSLOT);
												}
										}
										GUILayout.EndHorizontal ();
				
										//Hands
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleHandsSLOT);
										
												FemaleHandsNameSLOT = EditorGUILayout.ObjectField (FemaleHandsNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.handsFemaleSlot = FemaleHandsNameSLOT as SlotData;
						if (FemaleHandsNameSLOT != null) {
						slotLibrary.AddSlot(FemaleHandsNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHandsNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHandsNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//InnerMouth
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleInnerMouthSLOT);
										
												FemaleInnerMouthNameSLOT = EditorGUILayout.ObjectField (FemaleInnerMouthNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.innerMouthFemaleSlot = FemaleInnerMouthNameSLOT as SlotData;
						if (FemaleInnerMouthNameSLOT != null) {
						slotLibrary.AddSlot(FemaleInnerMouthNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleInnerMouthNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleInnerMouthNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Legs
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleLegsSLOT);
										
												FemaleLegsNameSLOT = EditorGUILayout.ObjectField (FemaleLegsNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.legsFemaleSlot = FemaleLegsNameSLOT as SlotData;
						if (FemaleLegsNameSLOT != null) {
						slotLibrary.AddSlot(FemaleLegsNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleLegsNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleLegsNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Feet
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleFeetSLOT);
										
												FemaleFeetNameSLOT = EditorGUILayout.ObjectField (FemaleFeetNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.feetFemaleSlot = FemaleFeetNameSLOT as SlotData;
						if (FemaleFeetNameSLOT != null) {
						slotLibrary.AddSlot(FemaleFeetNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleFeetNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleFeetNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
										EditorGUILayout.EndScrollView ();
								}
		
//Female Overlays

								if (BodyFemaleOverlays) {
										EditorGUILayout.HelpBox ("You are now editing FEMALE Overlays", MessageType.Warning);
										scrollPos = EditorGUILayout.BeginScrollView (scrollPos, GUILayout.Height (310), GUILayout.ExpandWidth (true));
										EditorGUILayout.BeginHorizontal ();
										if (GUILayout.Button ("Slots")) {
												BodyFemaleSlots = true;
												BodyFemaleOverlays = false;
										}
				
										if (GUILayout.Button ("Overlays")) {
												BodyFemaleSlots = false;
												BodyFemaleOverlays = true;
										}
										EditorGUILayout.EndHorizontal ();
				
										EditorGUILayout.Space ();
				
										//Lipstick
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleLipstick);
										
												FemaleLipstickNameOVERLAY = EditorGUILayout.ObjectField (FemaleLipstickNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.lipStickFemaleOverlay = FemaleLipstickNameOVERLAY as OverlayData;
								if (FemaleLipstickNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleLipstickNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), lipStickFemaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleLipstickNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleLipstickNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Eyebrow
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (FemaleEyebrow);
										
												FemaleEyebrowNameOVERLAY = EditorGUILayout.ObjectField (FemaleEyebrowNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlay = FemaleEyebrowNameOVERLAY as OverlayData;
					if (FemaleEyebrowNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleEyebrowNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), eyeBrowFemaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleEyebrowNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleEyebrowNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();


										//Hair
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Hair", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleHairNameOVERLAY = EditorGUILayout.ObjectField (FemaleHairNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlay = FemaleHairNameOVERLAY as OverlayData;
					if (FemaleHairNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleHairNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), hairFemaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHairNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHairNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
				
				
				
										//Face
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Face", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleFaceNameOVERLAY = EditorGUILayout.ObjectField (FemaleFaceNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.faceFemaleOverlay = FemaleFaceNameOVERLAY as OverlayData;
					if (FemaleFaceNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleFaceNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleFaceNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleFaceNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Head
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Head", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleHeadNameOVERLAY = EditorGUILayout.ObjectField (FemaleHeadNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.headFemaleOverlay = FemaleHeadNameOVERLAY as OverlayData;
					if (FemaleHeadNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleHeadNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHeadNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHeadNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Eyes
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Eyes", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleEyesNameOVERLAY = EditorGUILayout.ObjectField (FemaleEyesNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlay = FemaleEyesNameOVERLAY as OverlayData;
					if (FemaleEyesNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleEyesNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), eyesFemaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleEyesNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleEyesNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Mouth
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Mouth", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleMouthNameOVERLAY = EditorGUILayout.ObjectField (FemaleMouthNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.mouthFemaleOverlay = FemaleMouthNameOVERLAY as OverlayData;
					if (FemaleMouthNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleMouthNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleMouthNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleMouthNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Ears
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Ears", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleEarsNameOVERLAY = EditorGUILayout.ObjectField (FemaleEarsNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.earsFemaleOverlay = FemaleEarsNameOVERLAY as OverlayData;
					if (FemaleEarsNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleEarsNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleEarsNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleEarsNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
				
										//Torso
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Torso", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleTorsoNameOVERLAY = EditorGUILayout.ObjectField (FemaleTorsoNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.torsoFemaleOverlay = FemaleTorsoNameOVERLAY as OverlayData;
					if (FemaleTorsoNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleTorsoNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleTorsoNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleTorsoNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//Hands
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Hands", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleHandsNameOVERLAY = EditorGUILayout.ObjectField (FemaleHandsNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.handsFemaleOverlay = FemaleHandsNameOVERLAY as OverlayData;
					if (FemaleHandsNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleHandsNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleHandsNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleHandsNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										//InnerMouth
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("InnerMouth", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleInnerMouthNameOVERLAY = EditorGUILayout.ObjectField (FemaleInnerMouthNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.innerMouthFemaleOverlay = FemaleInnerMouthNameOVERLAY as OverlayData;
					if (FemaleInnerMouthNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleInnerMouthNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), innerMouthFemaleOverlayColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleInnerMouthNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleInnerMouthNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
				
										//Legs
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Legs", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleHandsNameOVERLAY = EditorGUILayout.ObjectField (FemaleLegsNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.legsFemaleOverlay = FemaleLegsNameOVERLAY as OverlayData;
					if (FemaleLegsNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleLegsNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleLegsNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleLegsNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
				
										//Hands
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Feet", EditorStyles.boldLabel, GUILayout.ExpandWidth (false));
										
												FemaleFeetNameOVERLAY = EditorGUILayout.ObjectField (FemaleFeetNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.feetFemaleOverlay = FemaleFeetNameOVERLAY as OverlayData;
					if (FemaleFeetNameOVERLAY != null) {
						overlayLibrary.AddOverlay(FemaleFeetNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), SkinColor, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (FemaleFeetNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (FemaleFeetNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
										EditorGUILayout.EndScrollView ();
								}
						}

				}

//Clothes
				if (Clothes) {
						stateLabel = "You are now in CLOTHES mode";
						EditorPrefs.SetString ("Mode", "Clothes");
				
						//Sex
						EditorGUILayout.BeginHorizontal ();
				
						if (GUILayout.Button ("Male")) {
								ClothesFemale = false;
								ClothesMale = true;
					
						}
				
						if (GUILayout.Button ("Female")) {
								ClothesMale = false;
								ClothesFemale = true;
						}
						EditorGUILayout.EndHorizontal ();

						if (ClothesMale) {

								
								scrollPos = EditorGUILayout.BeginScrollView (scrollPos, GUILayout.Height (310), GUILayout.ExpandWidth (true));

								EditorGUILayout.BeginHorizontal ();
								if (GUILayout.Button ("Slots")) {
										ClothesMaleSlots = true;
										ClothesMaleOverlays = false;
								}
				
								if (GUILayout.Button ("Overlays")) {
										ClothesMaleSlots = false;
										ClothesMaleOverlays = true;
								}
								EditorGUILayout.EndHorizontal ();


								if (ClothesMaleSlots) {
								EditorGUILayout.HelpBox ("You are now editing MALE Slots", MessageType.Warning);
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (JeansMaleSLOT);
										
												JeansMaleNameSLOT = EditorGUILayout.ObjectField (JeansMaleNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsClothes.maleSlotClothes.jeansMaleSlot = JeansMaleNameSLOT as SlotData;
					if (JeansMaleNameSLOT != null) {
						slotLibrary.AddSlot(JeansMaleNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (JeansMaleNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (JeansMaleNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
								}

								if (ClothesMaleOverlays) {
								EditorGUILayout.HelpBox ("You are now editing MALE Overlays", MessageType.Warning);
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (ShirtMaleOVERLAY);
										
												ShirtMaleNameOVERLAY = EditorGUILayout.ObjectField (ShirtMaleNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysClothes.maleOverlayClothes.shirtMaleOverlay = ShirtMaleNameOVERLAY as OverlayData;
					if (ShirtMaleNameOVERLAY != null) {
						overlayLibrary.AddOverlay(ShirtMaleNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), ShirtMaleColorOVERLAY, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (ShirtMaleNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (ShirtMaleNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
				
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (UnderwearMaleOVERLAY);
										
												UnderwearMaleNameOVERLAY = EditorGUILayout.ObjectField (UnderwearMaleNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysClothes.maleOverlayClothes.underwearMaleOverlay = UnderwearMaleNameOVERLAY as OverlayData;
					if (UnderwearMaleNameOVERLAY != null) {
						overlayLibrary.AddOverlay(UnderwearMaleNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), UnderwearMaleColorOVERLAY, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (UnderwearMaleNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (UnderwearMaleNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Jeans", EditorStyles.boldLabel);
										
												JeansMaleNameOVERLAY = EditorGUILayout.ObjectField (JeansMaleNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysClothes.maleOverlayClothes.jeansMaleOverlay = JeansMaleNameOVERLAY as OverlayData;
					if (JeansMaleNameOVERLAY != null) {
						overlayLibrary.AddOverlay(JeansMaleNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), JeansMaleColorOVERLAY, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (JeansMaleNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (JeansMaleNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();

								}
								EditorGUILayout.EndScrollView ();
	
						}
						if (ClothesFemale) {


								
								scrollPos = EditorGUILayout.BeginScrollView (scrollPos, GUILayout.Height (310), GUILayout.ExpandWidth (true));
				
								EditorGUILayout.BeginHorizontal ();
								if (GUILayout.Button ("Slots")) {
										ClothesFemaleSlots = true;
										ClothesFemaleOverlays = false;
								}
				
								if (GUILayout.Button ("Overlays")) {
										ClothesFemaleSlots = false;
										ClothesFemaleOverlays = true;
								}
								EditorGUILayout.EndHorizontal ();
				
				
								if (ClothesFemaleSlots) {
								EditorGUILayout.HelpBox ("You are now editing FEMALE Slots", MessageType.Warning);
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (TShirtFemaleSLOT);
										
												TShirtFemaleNameSLOT = EditorGUILayout.ObjectField (TShirtFemaleNameSLOT, typeof(SlotData), false, GUILayout.ExpandWidth (false)) as SlotData;
												umaModels.modifiers.testModels.slotsClothes.femaleSlotClothes.tShirtFemaleSlot = TShirtFemaleNameSLOT as SlotData;
					if (TShirtFemaleNameSLOT != null) {
						slotLibrary.AddSlot(TShirtFemaleNameSLOT);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (TShirtFemaleNameSLOT.meshRenderer.gameObject as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (TShirtFemaleNameSLOT);
												}
										}
										EditorGUILayout.EndHorizontal ();
					
								}
				
								if (ClothesFemaleOverlays) {
								EditorGUILayout.HelpBox ("You are now editing FEMALE Overlays", MessageType.Warning);
										EditorGUILayout.Space ();
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (JeansFemaleOVERLAY);
										
												JeansFemaleNameOVERLAY = EditorGUILayout.ObjectField (JeansFemaleNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeansFemaleOverlay = JeansFemaleNameOVERLAY as OverlayData;
					if (JeansFemaleNameOVERLAY != null) {
						overlayLibrary.AddOverlay(JeansFemaleNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), JeansFemaleColorOVERLAY, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (JeansFemaleNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (JeansFemaleNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
					
										EditorGUILayout.BeginHorizontal ();
										EditorGUILayout.PropertyField (UnderwearFemaleOVERLAY);
										
												UnderwearFemaleNameOVERLAY = EditorGUILayout.ObjectField (UnderwearFemaleNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
												umaModels.modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwearFemaleOverlay = UnderwearFemaleNameOVERLAY as OverlayData;
					if (UnderwearFemaleNameOVERLAY != null) {
						overlayLibrary.AddOverlay(UnderwearFemaleNameOVERLAY);
												EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), UnderwearFemaleColorOVERLAY, GUIContent.none);
												if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (UnderwearFemaleNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
														EditorGUIUtility.PingObject (UnderwearFemaleNameOVERLAY);
												}
										}
										EditorGUILayout.EndHorizontal ();
					
										EditorGUILayout.BeginHorizontal ();

										EditorGUILayout.LabelField ("TShirt", EditorStyles.boldLabel);
										TShirtFemaleNameOVERLAY = EditorGUILayout.ObjectField (TShirtFemaleNameOVERLAY, typeof(OverlayData), false, GUILayout.ExpandWidth (false)) as OverlayData;
										umaModels.modifiers.testModels.overlaysClothes.femaleOverlayClothes.tShirtFemaleOverlay = TShirtFemaleNameOVERLAY as OverlayData;
										EditorGUI.PropertyField (new Rect (GUILayoutUtility.GetLastRect ().x, GUILayoutUtility.GetLastRect ().y + 20, GUILayoutUtility.GetLastRect ().width, GUILayoutUtility.GetLastRect ().height), TShirtFemaleColorOVERLAY, GUIContent.none);
										if (GUILayout.Button (new GUIContent (AssetPreview.GetAssetPreview (TShirtFemaleNameOVERLAY.textureList [0] as Object)), GUILayout.Width (80), GUILayout.Height (80), GUILayout.ExpandWidth (true))) {
												EditorGUIUtility.PingObject (TShirtFemaleNameOVERLAY);
										}
										EditorGUILayout.EndHorizontal ();
					
								}
								EditorGUILayout.EndScrollView ();


						}

				}

				//TRANSFER VALUES IF RANDOM = FALSE
				if (EditorApplication.isPlaying && !randomValues && oneTime) {

					if (umaDna != umaModels.umaData.umaRecipe.GetDna<UMA.UMADnaHumanoid>() as UMA.UMADnaHumanoid) {
						umaDna = umaModels.umaData.umaRecipe.GetDna<UMA.UMADnaHumanoid>() as UMA.UMADnaHumanoid;
								umaData = umaModels.umaData;
						}

						umaDna.height = Height;
				
						umaDna.headWidth = HeadWidth;
				
						umaDna.neckThickness = NeckThickness;
				
						umaDna.armLength = ArmLength;
				
						umaDna.handsSize = HandsSize;
				
						umaDna.feetSize = FeetSize;
				
						umaDna.legSeparation = LegSeparation;
				
						umaDna.upperMuscle = UpperMuscle;
				
						umaDna.lowerMuscle = LowerMuscle;
				
						umaDna.upperWeight = UpperWeight;
				
						umaDna.lowerWeight = LowerWeight;
				
						umaDna.legsSize = LegsSize;
				
						umaDna.earsSize = EarsSize;
				
						umaDna.earsPosition = EarsPosition;
				
						umaDna.earsRotation = EarsRotation;
				
						umaDna.noseSize = NoseSize;
				
						umaDna.noseCurve = NoseCurve;
				
						umaDna.noseWidth = NoseWidth;
				
						umaDna.noseInclination = NoseInclination;
				
						umaDna.nosePosition = NosePosition;
				
						umaDna.nosePronounced = NosePronounced;
				
						umaDna.noseFlatten = NoseFlatten;
				
						umaDna.chinSize = ChinSize;
				
						umaDna.chinPronounced = ChinPronounced;
				
						umaDna.chinPosition = ChinPosition;
				
						umaDna.mandibleSize = MandibleSize;
				
						umaDna.jawsSize = JawsSize;
				
						umaDna.jawsPosition = JawsPosition;
				
						umaDna.cheekSize = CheekSize;
				
						umaDna.cheekPosition = CheekPosition;
				
						umaDna.lowCheekPronounced = LowCheekPronounced;
				
						umaDna.lowCheekPosition = LowCheekPosition;
				
						umaDna.foreheadSize = ForeheadSize;
				
						umaDna.foreheadPosition = ForeheadPosition;
				
						umaDna.eyeSize = EyeSize;
				
						umaDna.eyeRotation = EyeRotation;
				
						umaDna.lipsSize = LipsSize;
				
						umaDna.mouthSize = MouthSize;
				
						umaDna.breastSize = BreastSize;
				
						umaDna.gluteusSize = GluteusSize;
				
						umaDna.armWidth = ArmWidth;
				
						umaDna.forearmLength = ForearmLength;
				
						umaDna.forearmWidth = ForearmWidth;
				
						umaDna.belly = Belly;
				
						umaDna.waist = Waist;
						oneTime = false;
				}

				if (!EditorApplication.isPlaying && semiReset && reset) {
			

			
						Height = 0.5f;
			
						HeadWidth = 0.5f;
			
						NeckThickness = 0.5f;
			
						ArmLength = 0.5f;
			
						HandsSize = 0.5f;
			
						FeetSize = 0.5f;
			
						LegSeparation = 0.5f;
			
						UpperMuscle = 0.5f;
			
						LowerMuscle = 0.5f;
			
						UpperWeight = 0.5f;
			
						LowerWeight = 0.5f;
			
						LegsSize = 0.5f;
			
						EarsSize = 0.5f;
			
						EarsPosition = 0.5f;
			
						EarsRotation = 0.5f;
			
						NoseSize = 0.5f;
			
						NoseCurve = 0.5f;
			
						NoseWidth = 0.5f;
			
						NoseInclination = 0.5f;
			
						NosePosition = 0.5f;
			
						NosePronounced = 0.5f;
			
						NoseFlatten = 0.5f;
			
						ChinSize = 0.5f;
			
						ChinPronounced = 0.5f;
			
						ChinPosition = 0.5f;
			
						MandibleSize = 0.5f;
			
						JawsSize = 0.5f;
			
						JawsPosition = 0.5f;
			
						CheekSize = 0.5f;
			
						CheekPosition = 0.5f;
			
						LowCheekPronounced = 0.5f;
			
						LowCheekPosition = 0.5f;
			
						ForeheadSize = 0.5f;
			
						ForeheadPosition = 0.5f;
			
						EyeSize = 0.5f;
			
						EyeRotation = 0.5f;
			
						LipsSize = 0.5f;
			
						MouthSize = 0.5f;
			
						BreastSize = 0.5f;
			
						GluteusSize = 0.5f;
			
						ArmWidth = 0.5f;
			
						ForearmLength = 0.5f;
			
						ForearmWidth = 0.5f;
			
						Belly = 0.5f;

						Waist = 0.5f;

						semiReset = false;
						reset = false;
				}


				//IF PHYSICAL
				if (Physical) {

						stateLabel = "You are now in PHYSICAL mode";
						EditorPrefs.SetString ("Mode", "Physical");

						if (!EditorApplication.isPlaying) {

								GUILayout.BeginHorizontal ();

								randomValues = EditorGUILayout.Toggle ("Random Values?", randomValues);
								EditorPrefs.SetBool ("RandomValues", randomValues);


								semiReset = EditorGUILayout.Toggle ("Reset", semiReset, GUILayout.ExpandWidth (false));



								GUILayout.EndHorizontal ();
								if (semiReset) {
					
										reset = EditorGUILayout.Toggle ("Sure?", reset, GUILayout.ExpandWidth (false));
					
								}
								EditorGUILayout.Space ();

								if (!randomValues) {
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Height", EditorStyles.boldLabel, GUILayout.Width (130));
										Height = EditorGUILayout.Slider (Height, 0, 1);
										EditorPrefs.SetFloat ("Height", Height);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Head Width", EditorStyles.boldLabel, GUILayout.Width (130));
										HeadWidth = EditorGUILayout.Slider (HeadWidth, 0, 1);
										EditorPrefs.SetFloat ("HeadWidth", HeadWidth);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Neck Thickness", EditorStyles.boldLabel, GUILayout.Width (130));
										NeckThickness = EditorGUILayout.Slider (NeckThickness, 0, 1);
										EditorPrefs.SetFloat ("NeckThickness", NeckThickness);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Arm Length", EditorStyles.boldLabel, GUILayout.Width (130));
										ArmLength = EditorGUILayout.Slider (ArmLength, 0, 1);
										EditorPrefs.SetFloat ("ArmLength", ArmLength);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Hands Size", EditorStyles.boldLabel, GUILayout.Width (130));
										HandsSize = EditorGUILayout.Slider (HandsSize, 0, 1);
										EditorPrefs.SetFloat ("HandsSize", HandsSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Feet Size", EditorStyles.boldLabel, GUILayout.Width (130));
										FeetSize = EditorGUILayout.Slider (FeetSize, 0, 1);
										EditorPrefs.SetFloat ("FeetSize", FeetSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Leg Separation", EditorStyles.boldLabel, GUILayout.Width (130));
										LegSeparation = EditorGUILayout.Slider (LegSeparation, 0, 1);
										EditorPrefs.SetFloat ("LegSeparation", LegSeparation);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Upper Muscle", EditorStyles.boldLabel, GUILayout.Width (130));
										UpperMuscle = EditorGUILayout.Slider (UpperMuscle, 0, 1);
										EditorPrefs.SetFloat ("UpperMuscle", UpperMuscle);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Lower Muscle", EditorStyles.boldLabel, GUILayout.Width (130));
										LowerMuscle = EditorGUILayout.Slider (LowerMuscle, 0, 1);
										EditorPrefs.SetFloat ("LowerMuscle", LowerMuscle);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Upper Weight", EditorStyles.boldLabel, GUILayout.Width (130));
										UpperWeight = EditorGUILayout.Slider (UpperWeight, 0, 1);
										EditorPrefs.SetFloat ("UpperWeight", UpperWeight);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Lower Weight", EditorStyles.boldLabel, GUILayout.Width (130));
										LowerWeight = EditorGUILayout.Slider (LowerWeight, 0, 1);
										EditorPrefs.SetFloat ("LowerWeight", LowerWeight);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Legs Size", EditorStyles.boldLabel, GUILayout.Width (130));
										LegsSize = EditorGUILayout.Slider (LegsSize, 0, 1);
										EditorPrefs.SetFloat ("LegsSize", LegsSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Ears Size", EditorStyles.boldLabel, GUILayout.Width (130));
										EarsSize = EditorGUILayout.Slider (EarsSize, 0, 1);
										EditorPrefs.SetFloat ("EarsSize", EarsSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Ears Position", EditorStyles.boldLabel, GUILayout.Width (130));
										EarsPosition = EditorGUILayout.Slider (EarsPosition, 0, 1);
										EditorPrefs.SetFloat ("EarsPosition", EarsPosition);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Ears Rotation", EditorStyles.boldLabel, GUILayout.Width (130));
										EarsRotation = EditorGUILayout.Slider (EarsRotation, 0, 1);
										EditorPrefs.SetFloat ("EarsRotation", EarsRotation);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Nose Size", EditorStyles.boldLabel, GUILayout.Width (130));
										NoseSize = EditorGUILayout.Slider (NoseSize, 0, 1);
										EditorPrefs.SetFloat ("NoseSize", NoseSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Nose Curve", EditorStyles.boldLabel, GUILayout.Width (130));
										NoseCurve = EditorGUILayout.Slider (NoseCurve, 0, 1);
										EditorPrefs.SetFloat ("NoseCurve", NoseCurve);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Nose Width", EditorStyles.boldLabel, GUILayout.Width (130));
										NoseWidth = EditorGUILayout.Slider (NoseWidth, 0, 1);
										EditorPrefs.SetFloat ("NoseWidth", NoseWidth);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Nose Inclination", EditorStyles.boldLabel, GUILayout.Width (130));
										NoseInclination = EditorGUILayout.Slider (NoseInclination, 0, 1);
										EditorPrefs.SetFloat ("NoseInclination", NoseInclination);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Nose Position", EditorStyles.boldLabel, GUILayout.Width (130));
										NosePosition = EditorGUILayout.Slider (NosePosition, 0, 1);
										EditorPrefs.SetFloat ("NosePosition", NosePosition);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Nose Pronounced", EditorStyles.boldLabel, GUILayout.Width (130));
										NosePronounced = EditorGUILayout.Slider (NosePronounced, 0, 1);
										EditorPrefs.SetFloat ("NosePronounced", NosePronounced);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Nose Flatten", EditorStyles.boldLabel, GUILayout.Width (130));
										NoseFlatten = EditorGUILayout.Slider (NoseFlatten, 0, 1);
										EditorPrefs.SetFloat ("NoseFlatten", NoseFlatten);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Chin Size", EditorStyles.boldLabel, GUILayout.Width (130));
										ChinSize = EditorGUILayout.Slider (ChinSize, 0, 1);
										EditorPrefs.SetFloat ("ChinSize", ChinSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Chin Pronounced", EditorStyles.boldLabel, GUILayout.Width (130));
										ChinPronounced = EditorGUILayout.Slider (ChinPronounced, 0, 1);
										EditorPrefs.SetFloat ("ChinPronounced", ChinPronounced);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Chin Position", EditorStyles.boldLabel, GUILayout.Width (130));
										ChinPosition = EditorGUILayout.Slider (ChinPosition, 0, 1);
										EditorPrefs.SetFloat ("ChinPosition", ChinPosition);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Mandible Size", EditorStyles.boldLabel, GUILayout.Width (130));
										MandibleSize = EditorGUILayout.Slider (MandibleSize, 0, 1);
										EditorPrefs.SetFloat ("MandibleSize", MandibleSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Jaws Size", EditorStyles.boldLabel, GUILayout.Width (130));
										JawsSize = EditorGUILayout.Slider (JawsSize, 0, 1);
										EditorPrefs.SetFloat ("JawsSize", JawsSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Jaws Position", EditorStyles.boldLabel, GUILayout.Width (130));
										JawsPosition = EditorGUILayout.Slider (JawsPosition, 0, 1);
										EditorPrefs.SetFloat ("JawsPosition", JawsPosition);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Cheek Size", EditorStyles.boldLabel, GUILayout.Width (130));
										CheekSize = EditorGUILayout.Slider (CheekSize, 0, 1);
										EditorPrefs.SetFloat ("CheekSize", CheekSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Cheek Position", EditorStyles.boldLabel, GUILayout.Width (130));
										CheekPosition = EditorGUILayout.Slider (CheekPosition, 0, 1);
										EditorPrefs.SetFloat ("CheekPosition", CheekPosition);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Low Cheek Pronounced", EditorStyles.boldLabel, GUILayout.Width (130));
										LowCheekPronounced = EditorGUILayout.Slider (LowCheekPronounced, 0, 1);
										EditorPrefs.SetFloat ("LowCheekPronounced", LowCheekPronounced);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Low Cheek Position", EditorStyles.boldLabel, GUILayout.Width (130));
										LowCheekPosition = EditorGUILayout.Slider (LowCheekPosition, 0, 1);
										EditorPrefs.SetFloat ("LowCheekPosition", LowCheekPosition);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Forehead Size", EditorStyles.boldLabel, GUILayout.Width (130));
										ForeheadSize = EditorGUILayout.Slider (ForeheadSize, 0, 1);
										EditorPrefs.SetFloat ("ForeheadSize", ForeheadSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Forehead Position", EditorStyles.boldLabel, GUILayout.Width (130));
										ForeheadPosition = EditorGUILayout.Slider (ForeheadPosition, 0, 1);
										EditorPrefs.SetFloat ("ForeheadPosition", ForeheadPosition);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Eye Size", EditorStyles.boldLabel, GUILayout.Width (130));
										EyeSize = EditorGUILayout.Slider (EyeSize, 0, 1);
										EditorPrefs.SetFloat ("EyeSize", EyeSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Eye Rotation", EditorStyles.boldLabel, GUILayout.Width (130));
										EyeRotation = EditorGUILayout.Slider (EyeRotation, 0, 1);
										EditorPrefs.SetFloat ("EyeRotation", EyeRotation);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Lips Size", EditorStyles.boldLabel, GUILayout.Width (130));
										LipsSize = EditorGUILayout.Slider (LipsSize, 0, 1);
										EditorPrefs.SetFloat ("LipsSize", LipsSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Mouth Size", EditorStyles.boldLabel, GUILayout.Width (130));
										MouthSize = EditorGUILayout.Slider (MouthSize, 0, 1);
										EditorPrefs.SetFloat ("MouthSize", MouthSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Breast Size", EditorStyles.boldLabel, GUILayout.Width (130));
										BreastSize = EditorGUILayout.Slider (BreastSize, 0, 1);
										EditorPrefs.SetFloat ("BreastSize", BreastSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Gluteus Size", EditorStyles.boldLabel, GUILayout.Width (130));
										GluteusSize = EditorGUILayout.Slider (GluteusSize, 0, 1);
										EditorPrefs.SetFloat ("GluteusSize", GluteusSize);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Arm Width", EditorStyles.boldLabel, GUILayout.Width (130));
										ArmWidth = EditorGUILayout.Slider (ArmWidth, 0, 1);
										EditorPrefs.SetFloat ("ArmWidth", ArmWidth);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Forearm Length", EditorStyles.boldLabel, GUILayout.Width (130));
										ForearmLength = EditorGUILayout.Slider (ForearmLength, 0, 1);
										EditorPrefs.SetFloat ("ForearmLength", ForearmLength);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Forearm Width", EditorStyles.boldLabel, GUILayout.Width (130));
										ForearmWidth = EditorGUILayout.Slider (ForearmWidth, 0, 1);
										EditorPrefs.SetFloat ("ForearmWidth", ForearmWidth);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Belly", EditorStyles.boldLabel, GUILayout.Width (130));
										Belly = EditorGUILayout.Slider (Belly, 0, 1);
										EditorPrefs.SetFloat ("Belly", Belly);
										GUILayout.EndHorizontal ();
				
										GUILayout.BeginHorizontal ();
										EditorGUILayout.LabelField ("Waist", EditorStyles.boldLabel, GUILayout.Width (130));
										Waist = EditorGUILayout.Slider (Waist, 0, 1);
										EditorPrefs.SetFloat ("Waist", Waist);
										GUILayout.EndHorizontal ();
								}
						}

						if (EditorApplication.isPlaying) {

							if (umaDna != umaModels.umaData.umaRecipe.GetDna<UMA.UMADnaHumanoid>() as UMA.UMADnaHumanoid) {
								umaDna = umaModels.umaData.umaRecipe.GetDna<UMA.UMADnaHumanoid>() as UMA.UMADnaHumanoid;
										umaData = umaModels.umaData;
								}


								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Height", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.height = EditorGUILayout.Slider (umaDna.height, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Head Width", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.headWidth = EditorGUILayout.Slider (umaDna.headWidth, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Neck Thickness", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.neckThickness = EditorGUILayout.Slider (umaDna.neckThickness, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Arm Lenght", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.armLength = EditorGUILayout.Slider (umaDna.armLength, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Hands Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.handsSize = EditorGUILayout.Slider (umaDna.handsSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Feet Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.feetSize = EditorGUILayout.Slider (umaDna.feetSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Leg Separation", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.legSeparation = EditorGUILayout.Slider (umaDna.legSeparation, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Upper Muscle", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.upperMuscle = EditorGUILayout.Slider (umaDna.upperMuscle, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Lower Muscle", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.lowerMuscle = EditorGUILayout.Slider (umaDna.lowerMuscle, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Upper Weight", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.upperWeight = EditorGUILayout.Slider (umaDna.upperWeight, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Lower Height", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.lowerWeight = EditorGUILayout.Slider (umaDna.lowerWeight, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Legs Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.legsSize = EditorGUILayout.Slider (umaDna.legsSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Ears Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.earsSize = EditorGUILayout.Slider (umaDna.earsSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Ears Position", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.earsPosition = EditorGUILayout.Slider (umaDna.earsPosition, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Ears Rotation", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.earsRotation = EditorGUILayout.Slider (umaDna.earsRotation, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Nose Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.noseSize = EditorGUILayout.Slider (umaDna.noseSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Nose Curve", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.noseCurve = EditorGUILayout.Slider (umaDna.noseCurve, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Nose Width", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.noseWidth = EditorGUILayout.Slider (umaDna.noseWidth, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Nose Inclination", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.noseInclination = EditorGUILayout.Slider (umaDna.noseInclination, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Nose Position", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.nosePosition = EditorGUILayout.Slider (umaDna.nosePosition, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Nose Pronounced", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.nosePronounced = EditorGUILayout.Slider (umaDna.nosePronounced, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Nose Flatten", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.noseFlatten = EditorGUILayout.Slider (umaDna.noseFlatten, 0, 1);
								GUILayout.EndHorizontal ();
			
								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Chin Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.chinSize = EditorGUILayout.Slider (umaDna.chinSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Chin Pronounced", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.chinPronounced = EditorGUILayout.Slider (umaDna.chinPronounced, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Chin Position", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.chinPosition = EditorGUILayout.Slider (umaDna.chinPosition, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Mandible Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.mandibleSize = EditorGUILayout.Slider (umaDna.mandibleSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Jaws Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.jawsSize = EditorGUILayout.Slider (umaDna.jawsSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Jaws Position", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.jawsPosition = EditorGUILayout.Slider (umaDna.jawsPosition, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Cheek Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.cheekSize = EditorGUILayout.Slider (umaDna.cheekSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Cheek Position", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.cheekPosition = EditorGUILayout.Slider (umaDna.cheekPosition, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Low Cheek Pronounced", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.lowCheekPronounced = EditorGUILayout.Slider (umaDna.lowCheekPronounced, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Low Cheek Position", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.lowCheekPosition = EditorGUILayout.Slider (umaDna.lowCheekPosition, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Forehead Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.foreheadSize = EditorGUILayout.Slider (umaDna.foreheadSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Forehead Position", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.foreheadPosition = EditorGUILayout.Slider (umaDna.foreheadPosition, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Eye Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.eyeSize = EditorGUILayout.Slider (umaDna.eyeSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Eye Rotation", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.eyeRotation = EditorGUILayout.Slider (umaDna.eyeRotation, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Lips Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.lipsSize = EditorGUILayout.Slider (umaDna.lipsSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Mouth Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.mouthSize = EditorGUILayout.Slider (umaDna.mouthSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Breast Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.breastSize = EditorGUILayout.Slider (umaDna.breastSize, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Gluteus Size", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.gluteusSize = EditorGUILayout.Slider (umaDna.gluteusSize, 0, 1);	
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Arm Width", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.armWidth = EditorGUILayout.Slider (umaDna.armWidth, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Forearm Length", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.forearmLength = EditorGUILayout.Slider (umaDna.forearmLength, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Forearm Width", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.forearmWidth = EditorGUILayout.Slider (umaDna.forearmWidth, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Belly", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.belly = EditorGUILayout.Slider (umaDna.belly, 0, 1);
								GUILayout.EndHorizontal ();

								GUILayout.BeginHorizontal ();
								EditorGUILayout.LabelField ("Waist", EditorStyles.boldLabel, GUILayout.Width (130));
								umaDna.waist = EditorGUILayout.Slider (umaDna.waist, 0, 1);
								GUILayout.EndHorizontal ();
								UpdateUMAShape ();

						}

				}


				if (General) {
						EditorPrefs.SetString ("Mode", "General");
						stateLabel = "You are now in GENERAL settings";
						EditorGUILayout.Space ();
						GUILayout.BeginHorizontal ();
						EditorGUILayout.PropertyField (Male);
						EditorGUILayout.PropertyField (Female);
						GUILayout.EndHorizontal ();
						EditorGUILayout.Space ();
						EditorGUILayout.PropertyField (SpawnPoint);
						EditorGUILayout.Space ();

						GUILayout.BeginHorizontal ();
						if (GUILayout.Button ("Tutorials (Videos)")) {
						Application.OpenURL ("http://www.youtube.com/watch?v=iAm0uIXojOI&list=PLZjL_AW6Ltiyf4iSxMvHTxJtZoZXtNAdL");
						
						}

						if (GUILayout.Button ("Forum")) {
								Application.OpenURL ("http://forum.unity3d.com/threads/220571-UMA-Helper-Pack");
						}

						if (GUILayout.Button ("Help (Via Email)")) {
							Application.OpenURL ("mailto:neo5icekcore@gmail.com");
						}
						GUILayout.EndHorizontal ();

				}

				serializedObject.ApplyModifiedProperties ();
		}

		public void UpdateUMAAtlas ()
		{
				umaData.isTextureDirty = true;
				umaData.Dirty ();

		}
	
		public void UpdateUMAShape ()
		{
				umaData.isShapeDirty = true;
				umaData.Dirty ();
		}

		void OnInspectorUpdate ()
		{
				this.Repaint ();

		}
}