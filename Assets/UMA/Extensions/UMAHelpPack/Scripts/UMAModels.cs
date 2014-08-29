//Made by KirbyRawr from Overflowing Studios
//Please don't claim it as yourself.
//If you pirated it consider buying it (:
//Thanks

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UMA;

public class UMAModels : MonoBehaviour {
	static public UMAModels UMAModelsSingleton;


	[System.NonSerialized]
	public UMAGeneratorBase generator;
	public UMAData umaData;
	[System.NonSerialized]
	public SlotLibrary slotLibrary;
	[System.NonSerialized]
	public OverlayLibrary overlayLibrary;
	[System.NonSerialized]
	public RaceLibrary raceLibrary;
	public UMACustomization umaCustomization;
	public float atlasResolutionScale;
	public bool randomDna;
	public bool generateUMA;
	public bool generateRandomUMAS;
	public Vector2 umaCrowdSize = new Vector2(2,2);
	public Transform zeroPoint;
	public Transform SpawnPoint;

	private Transform tempUMA;
	private int X;
	private int Y;
	private float umaTimer;

	[HideInInspector]
	public int slotsNumberMale = 22;
	[HideInInspector]
	public int slotsNumberFemale = 22;

	[System.Serializable]
	public class UMAModifiers {

		public bool Male = true;
		public bool Female = false;
		public Color skinColor = new Color(1,1,1,1);
		public UMATestModels testModels = new UMATestModels();
		[System.Serializable]
		public class UMATestModels{
			public SLOTBodyParts slotsBodyParts = new SLOTBodyParts();
			public OVERLAYBodyParts overlaysBodyParts = new OVERLAYBodyParts();
			public SLOTClothes slotsClothes = new SLOTClothes ();
			public OVERLAYClothes overlaysClothes = new OVERLAYClothes ();
			public CUSTOMMeshesAndClothes customMeshesAndClothes = new CUSTOMMeshesAndClothes();
			[System.Serializable]
			public class SLOTBodyParts{
				public Male maleSlotsBodyParts = new Male();
				public Female femaleSlotsBodyParts = new Female();
				[System.Serializable]
				public class Male{

					public SLOTheadMaleParts slotHeadMaleParts = new SLOTheadMaleParts();
					public bool face = false;
					public bool eyes = false;
					public bool torso = false;
					public bool hands = false;
					public bool innerMouth = false;
					public bool legs = false;
					public bool feet = false;


					[System.Serializable]
					public class SLOTheadMaleParts{
						public bool head = false;
						public bool headEyes = false;
						public bool headMouth = false;
						public bool headNose = false;
						public bool headEars = false;
						
						public SlotData headMaleSlot;
						public SlotData headEyesMaleSlot;
						public SlotData headMouthMaleSlot;
						public SlotData headNoseMaleSlot;
						public SlotData headEarsMaleSlot;


					}

					public SlotData faceMaleSlot;
					public SlotData eyesMaleSlot;
					public SlotData innerMouthMaleSlot;
					public SlotData torsoMaleSlot;
					public SlotData handsMaleSlot;
					public SlotData legsMaleSlot;
					public SlotData feetMaleSlot;
				}
				[System.Serializable]
				public class Female{
					public SLOTheadFemaleParts slotHeadFemaleParts = new SLOTheadFemaleParts();
					public bool face = false;
					public bool hair = false;
					public bool eyes = false;
					public bool eyeLash = false;
					public bool torso = false;
					public bool hands = false;
					public bool innerMouth = false;
					public bool legs = false;
					public bool feet = false;

					[System.Serializable]
					public class SLOTheadFemaleParts{
						public bool headFemale = false;
						public bool headEyesFemale = false;
						public bool headMouthFemale = false;
						public bool headNoseFemale = false;
						public bool headEarsFemale = false;
						
						public SlotData headFemaleSlot;
						public SlotData headEyesFemaleSlot;
						public SlotData headMouthFemaleSlot;
						public SlotData headNoseFemaleSlot;
						public SlotData headEarsFemaleSlot;
					}


					public SlotData faceFemaleSlot;
					public SlotData hairFemaleSlot;
					public SlotData eyesFemaleSlot;
					public SlotData eyeLashSlot;
					public SlotData torsoFemaleSlot;
					public SlotData handsFemaleSlot;
					public SlotData innerMouthFemaleSlot;
					public SlotData legsFemaleSlot;
					public SlotData feetFemaleSlot;
				}
			}
			[System.Serializable]
			public class OVERLAYBodyParts{
				public Male maleOverlaysBodyParts = new Male();
				public Female femaleOverlaysBodyParts = new Female();
				[System.Serializable]
				public class Male{
					public bool hair = false;
					public bool beard = false;
					public bool beard2 = false;
					public bool eyeBrow = false;
					public OverlayData hairMaleOverlay;
					public OverlayData beardMaleOverlay;
					public OverlayData beard2MaleOverlay;
					public OverlayData eyeBrowMaleOverlay;
					public OverlayData faceMaleOverlay;
					public OverlayData headMaleOverlay;
					public OverlayData eyesMaleOverlay;
					public OverlayData mouthMaleOverlay;
					public OverlayData noseMaleOverlay;
					public OverlayData earsMaleOverlay;
					public OverlayData torsoMaleOverlay;
					public OverlayData handsMaleOverlay;
					public OverlayData innerMouthMaleOverlay;
					public OverlayData legsMaleOverlay;
					public OverlayData feetMaleOverlay;

					public Color hairMaleOverlayColor;
					public Color beardMaleOverlayColor;
					public Color beard2MaleOverlayColor;
					public Color eyeBrowMaleOverlayColor;
					public Color eyesMaleOverlayColor;
					public Color innerMouthMaleOverlayColor;

				}
				[System.Serializable]
				public class Female{
				    public bool eyeBrow = false;
					public bool lipStick = false;

					public OverlayData faceFemaleOverlay;
					public OverlayData headFemaleOverlay;
					public OverlayData eyesFemaleOverlay;
					public OverlayData hairFemaleOverlay;
					public OverlayData eyeBrowFemaleOverlay;
					public OverlayData mouthFemaleOverlay;
					public OverlayData lipStickFemaleOverlay;
					public OverlayData noseFemaleOverlay;
					public OverlayData earsFemaleOverlay;
					public OverlayData torsoFemaleOverlay;
					public OverlayData handsFemaleOverlay;
					public OverlayData innerMouthFemaleOverlay;
					public OverlayData legsFemaleOverlay;
					public OverlayData feetFemaleOverlay;

					public Color eyesFemaleOverlayColor;
					public Color hairFemaleOverlayColor;
					public Color eyeBrowFemaleOverlayColor;
					public Color lipStickFemaleOverlayColor;
					public Color innerMouthFemaleOverlayColor;
				}
			}
				[System.Serializable]
				public class SLOTClothes{
					public Male maleSlotClothes = new Male();
					public Female femaleSlotClothes = new Female ();
				 [System.Serializable]
				 public class Male{
					public bool jeans = false;
					public SlotData jeansMaleSlot;
				}
				[System.Serializable]
				public class Female{
					public bool tShirt = false;
					public SlotData tShirtFemaleSlot;
				}

			}
				[System.Serializable]
				public class OVERLAYClothes{
					public Male maleOverlayClothes = new Male();
					public Female femaleOverlayClothes = new Female ();
					[System.Serializable]
					public class Male{
						public bool underwear = true;
						public bool shirt = false;

						public OverlayData jeansMaleOverlay;
						public OverlayData shirtMaleOverlay;
						public OverlayData underwearMaleOverlay;

						public Color jeansMaleOverlayColor;
						public Color shirtMaleOverlayColor;
						public Color underwearMaleOverlayColor;
				}
					[System.Serializable]
					public class Female{
						public bool jeans = false;
						public bool shirt = false;
						public bool underwear = true;
					
						public OverlayData jeansFemaleOverlay;
						public OverlayData tShirtFemaleOverlay;
						public OverlayData shirtFemaleOverlay;
						public OverlayData underwearFemaleOverlay;

						public Color jeansFemaleOverlayColor;
						public Color tShirtFemaleOverlayColor;
						public Color shirtFemaleOverlayColor;
						public Color underwearFemaleOverlayColor;
						
				}
					
				}
			[System.Serializable]
			public class CUSTOMMeshesAndClothes{
				public Male maleCustom= new Male();
				public Female femaleCustom = new Female ();

				[System.Serializable]
				public class Male{

					public List<CustomList> customList = new List<CustomList>();

					[System.Serializable]
					public class CustomList{
						public bool Slot = false;
						public SlotData slotData;
						public bool Overlay = false;
						public OverlayData overlayData;
						public Color overlayColor = new Color(1,1,1);
					}
				}

				[System.Serializable]
				public class Female{
					public List<CustomList> customList = new List<CustomList>();
					[System.Serializable]
					public class CustomList{
						public bool Slot = false;
						public SlotData slotData;
						public bool Overlay = false;
						public OverlayData overlayData;
						public Color overlayColor = new Color(1,1,1);
					}
				}
			}	
		}
	}

	public UMAModifiers modifiers = new UMAModifiers();

	void Awake(){
		UMAModelsSingleton = FindObjectOfType(typeof(UMAModels)) as UMAModels;
		if(UMAModelsSingleton == null)
			Debug.Log("Couldn't locate UMAModels in the scene.");
		generator = GameObject.Find("UMAGenerator").GetComponent<UMAGenerator>();
		slotLibrary = GameObject.Find("SlotLibrary").GetComponent<SlotLibrary>();
		overlayLibrary = GameObject.Find("OverlayLibrary").GetComponent<OverlayLibrary>();
		raceLibrary = GameObject.Find("RaceLibrary").GetComponent<RaceLibrary>();
		string tempVersion = Application.unityVersion;
		tempVersion = tempVersion.Substring(0,3);
		if (modifiers.Male) modifiers.Female = false;
		if (modifiers.Female) modifiers.Male = false;
		if (!modifiers.Male && !modifiers.Female) modifiers.Male = true;

	}
	public bool oneTime = true;
	public bool readyForNew = true;
	void Update () {

		if(generateRandomUMAS){	
			if( readyForNew )
			{
				readyForNew = false;
				GenerateOneUMA();
				umaData.OnCharacterUpdated += new System.Action<UMAData>(umaData_OnUpdated);

				if(zeroPoint){
					tempUMA.position = new Vector3(X+zeroPoint.position.x - umaCrowdSize.x*0.5f + 0.5f,zeroPoint.position.y,Y+zeroPoint.position.z - umaCrowdSize.y*0.5f + 0.5f);
				}else{
					tempUMA.position = new Vector3(X - umaCrowdSize.x*0.5f + 0.5f,0,Y - umaCrowdSize.y*0.5f + 0.5f);	
				}
				
				X = X + 1;
				if(X >= umaCrowdSize.x){
					X = 0;
					Y = Y + 1;
				}
				if(Y >= umaCrowdSize.y){
					generateRandomUMAS = false;
					X = 0;
					Y = 0;
				}
				
			}
		}
		
		if(generateUMA){
			GenerateOneUMA();
			generateUMA = false;
			tempUMA.position = SpawnPoint.localPosition;

		}
	}
	
	void umaData_OnUpdated(UMAData obj)
	{
		readyForNew = true;
	}
	
	void DefineSlots (){

		//Male Avatar
		if (umaData.umaRecipe.raceData.raceName == "HumanMale")
		{
			
			umaData.umaRecipe.slotDataList = new SlotData[slotsNumberMale];

		//Eyes Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.eyes){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.eyesMaleSlot.slotName != "MaleEyes")
					umaData.umaRecipe.slotDataList[0] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.eyesMaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[0] = slotLibrary.InstantiateSlot("MaleEyes");
		
				//Eye Overlay
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlay.overlayName != "EyeOverlay"){
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlay.overlayName));
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlayColor));
				}
				else{
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlay"));
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlayAdjust",modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyesMaleOverlayColor));
				}
			}

		//Face Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.face){

				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.faceMaleSlot.slotName!= "MaleFace")
					umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.faceMaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot("MaleFace");

				//Face Overlay
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.faceMaleOverlay.overlayName != "MaleHead01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.faceMaleOverlay.overlayName,modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleHead01",modifiers.skinColor));
			}
				
				
				
		//Head - Head Parts Slot Male
		if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.head){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMaleSlot.slotName != "MaleHead_Head")
					umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot("MaleHead_Head");
				//Head Overlay
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.headMaleOverlay.overlayName != "MaleHead01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.headMaleOverlay.overlayName,modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleHead01",modifiers.skinColor));
				}

		//Eyes - Head Parts Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEyes){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEyesMaleSlot.slotName != "MaleHead_Eyes")
					umaData.umaRecipe.slotDataList[7] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEyesMaleSlot.slotName,umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[7] = slotLibrary.InstantiateSlot("MaleHead_Eyes",umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}

		//Ears - Head Parts Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEars){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEarsMaleSlot.slotName != "MaleHead_Ears")
					umaData.umaRecipe.slotDataList[8] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headEarsMaleSlot.slotName,umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[8] = slotLibrary.InstantiateSlot("MaleHead_Ears", umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}

		//Mouth - Head Parts Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMouth){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMouthMaleSlot.slotName != "MaleHead_Mouth")
					umaData.umaRecipe.slotDataList[9] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headMouthMaleSlot.slotName, umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[9] = slotLibrary.InstantiateSlot("MaleHead_Mouth", umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}
		
		//Nose - Head Parts Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headNose){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headNoseMaleSlot.slotName != "MaleHead_Nose")
					umaData.umaRecipe.slotDataList[10] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.slotHeadMaleParts.headNoseMaleSlot.slotName, umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[10] = slotLibrary.InstantiateSlot("MaleHead_Nose", umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}


		//Hair Overlay Male	
			if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hair){
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hairMaleOverlay.overlayName != "MaleHair01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hairMaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hairMaleOverlayColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleHair01",  modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.hairMaleOverlayColor));
			}


		//Beard1 Overlay Male
			if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard){
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beardMaleOverlay.overlayName != "MaleBeard01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beardMaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beardMaleOverlayColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard01", modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beardMaleOverlayColor));
			}
				

			
			
		//Beard2 Overlay Male	
			if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2){
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2MaleOverlay.overlayName != "MaleBeard02")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2MaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2MaleOverlayColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBeard02", modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.beard2MaleOverlayColor));
			}

		//EyeBrow Overlay Male
			if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrow){
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrowMaleOverlay.overlayName != "MaleEyebrow01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrowMaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrowMaleOverlayColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("MaleEyebrow01", modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.eyeBrowMaleOverlayColor));
			}

		//Torso Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.torso){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.torsoMaleSlot.slotName != "MaleTorso")
					umaData.umaRecipe.slotDataList[2] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.torsoMaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[2] = slotLibrary.InstantiateSlot("MaleTorso");
				//Torso Overlay
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.torsoMaleOverlay.overlayName != "MaleBody01")
					umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.torsoMaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBody01", modifiers.skinColor));

			}

		//Hands Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.hands){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.handsMaleSlot.slotName != "MaleHands")
					umaData.umaRecipe.slotDataList[3] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.handsMaleSlot.slotName, umaData.umaRecipe.slotDataList[2].GetOverlayList());
				else umaData.umaRecipe.slotDataList[3] = slotLibrary.InstantiateSlot("MaleHands");

				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.handsMaleOverlay.overlayName != "MaleBody01")
					umaData.umaRecipe.slotDataList[3].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.handsMaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[3].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBody01", modifiers.skinColor));

			}
		
		//InnerMouth Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.innerMouth){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.innerMouthMaleSlot.slotName != "MaleInnerMouth")
					umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.innerMouthMaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot("MaleInnerMouth");
				//InnerMouth Overlay
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.mouthMaleOverlay.overlayName!= "InnerMouth")
					umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.mouthMaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay("InnerMouth", modifiers.skinColor));
				
			}

		//Legs Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.legs){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.legsMaleSlot.slotName != "MaleLegs")
					umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.legsMaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot("MaleLegs");
				//Legs Overlay
				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.legsMaleOverlay.overlayName != "MaleBody01")
					umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.legsMaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBody01", modifiers.skinColor));

			}
		
		//Feet Slot Male
			if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.feet){
				if(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.feetMaleSlot.slotName != "MaleFeet")
					umaData.umaRecipe.slotDataList[6] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.feetMaleSlot.slotName, umaData.umaRecipe.slotDataList[2].GetOverlayList());
				else umaData.umaRecipe.slotDataList[6] = slotLibrary.InstantiateSlot("MaleFeet");

				if(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.feetMaleOverlay.overlayName != "MaleBody01")
					umaData.umaRecipe.slotDataList[6].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.maleOverlaysBodyParts.feetMaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[6].AddOverlay(overlayLibrary.InstantiateOverlay("MaleBody01", modifiers.skinColor));

			}		
	//////////////////////////
	//////Clothes Male////////
	//////////////////////////

			//Jeans Slot Male
			if(modifiers.testModels.slotsClothes.maleSlotClothes.jeans){
				if(modifiers.testModels.slotsClothes.maleSlotClothes.jeansMaleSlot.slotName != "MaleJeans01")
					umaData.umaRecipe.slotDataList[5] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsClothes.maleSlotClothes.jeansMaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[5] = slotLibrary.InstantiateSlot("MaleJeans01");

				//Jeans Overlay Male
				if(modifiers.testModels.overlaysClothes.maleOverlayClothes.jeansMaleOverlay.overlayName!= "MaleJeans01")
					umaData.umaRecipe.slotDataList[5].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysClothes.maleOverlayClothes.jeansMaleOverlay.overlayName,modifiers.testModels.overlaysClothes.maleOverlayClothes.jeansMaleOverlayColor));	
				else umaData.umaRecipe.slotDataList[5].AddOverlay(overlayLibrary.InstantiateOverlay("MaleJeans01",modifiers.testModels.overlaysClothes.maleOverlayClothes.jeansMaleOverlayColor));	
			}

			//Shirt Overlay Male
			if(modifiers.testModels.overlaysClothes.maleOverlayClothes.shirt){
				if(modifiers.testModels.overlaysClothes.maleOverlayClothes.shirtMaleOverlay.overlayName != "MaleShirt01")
					umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysClothes.maleOverlayClothes.shirtMaleOverlay.overlayName, modifiers.testModels.overlaysClothes.maleOverlayClothes.shirtMaleOverlayColor));
				else umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("MaleShirt01",modifiers.testModels.overlaysClothes.maleOverlayClothes.shirtMaleOverlayColor));
			}
		
			//Underwear Overlay Male
			if(modifiers.testModels.overlaysClothes.maleOverlayClothes.underwear){
				if(modifiers.testModels.overlaysClothes.maleOverlayClothes.underwearMaleOverlay.overlayName != "MaleUnderwear01")
					umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysClothes.maleOverlayClothes.underwearMaleOverlay.overlayName, modifiers.testModels.overlaysClothes.maleOverlayClothes.underwearMaleOverlayColor));
				else umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("MaleUnderwear01", modifiers.testModels.overlaysClothes.maleOverlayClothes.underwearMaleOverlayColor));
			}

			//Custom SLOTS and OVERLAYS Male
			int number = 12;
			for(int i = 0; i<modifiers.testModels.customMeshesAndClothes.maleCustom.customList.Count; i++){
				if(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].Slot){
					if(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].slotData.slotName != null){
					umaData.umaRecipe.slotDataList[(number + i)] = slotLibrary.InstantiateSlot(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].slotData.slotName);
					if(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].overlayData.overlayName != null){
						if(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].Overlay){
								umaData.umaRecipe.slotDataList[(number + i)].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].overlayData.overlayName, modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].overlayColor));
						}
					}
				}
				}
				if(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].Overlay && !modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].Slot && modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].overlayData.overlayName != null){
					umaData.umaRecipe.slotDataList[(number + i)].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].overlayData.overlayName, modifiers.testModels.customMeshesAndClothes.maleCustom.customList[i].overlayColor));
					}
				}

		}
		

		//Female Avatar
		else if (umaData.umaRecipe.raceData.raceName == "HumanFemale")
		{
			umaData.umaRecipe.slotDataList = new SlotData[slotsNumberFemale];
			
			//Eyes Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.eyes){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.eyesFemaleSlot.slotName != "FemaleEyes")
					umaData.umaRecipe.slotDataList[0] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.eyesFemaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[0] = slotLibrary.InstantiateSlot("FemaleEyes");
				
				//Eye Overlay
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlay.overlayName != "EyeOverlay"){
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlay.overlayName));
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlayColor));
				}
				else{
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlay"));
					umaData.umaRecipe.slotDataList[0].AddOverlay(overlayLibrary.InstantiateOverlay("EyeOverlayAdjust", modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyesFemaleOverlayColor));
				}
			}
			
			//Face Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.face){
				
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.faceFemaleSlot.slotName!= "FemaleFace")
					umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.faceFemaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot("FemaleFace");
				
				//Face Overlay
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.faceFemaleOverlay.overlayName != "FemaleHead01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.faceFemaleOverlay.overlayName,modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleHead01",modifiers.skinColor));
			}
			
			
			
			//Head - Head Parts Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headFemale){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headFemaleSlot.slotName != "FemaleHead_Head")
					umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headFemaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[1] = slotLibrary.InstantiateSlot("FemaleHead_Head");
				//Head Overlay
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.headFemaleOverlay.overlayName != "FemaleHead01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.headFemaleOverlay.overlayName,modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleHead01",modifiers.skinColor));
			}
			
			//Eyes - Head Parts Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEyesFemale){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headFemaleSlot.slotName != "FemaleHead_Eyes")
					umaData.umaRecipe.slotDataList[7] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEyesFemaleSlot.slotName,umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[7] = slotLibrary.InstantiateSlot("FemaleHead_Eyes",umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}
			
			//Ears - Head Parts Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEarsFemale){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEarsFemaleSlot.slotName != "FemaleHead_Ears")
					umaData.umaRecipe.slotDataList[8] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headEarsFemaleSlot.slotName, umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[8] = slotLibrary.InstantiateSlot("FemaleHead_Ears", umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}
			
			//Mouth - Head Parts Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headMouthFemale){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headMouthFemaleSlot.slotName != "FemaleHead_Mouth")
					umaData.umaRecipe.slotDataList[9] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headMouthFemaleSlot.slotName, umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[9] = slotLibrary.InstantiateSlot("FemaleHead_Mouth", umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}

			//LipStick Overlay Female
			if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.lipStick){
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.lipStickFemaleOverlay.overlayName != "FemaleLipstick01")
					umaData.umaRecipe.slotDataList[9].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.lipStickFemaleOverlay.overlayName, new Color(modifiers.skinColor.r + Random.Range(0.0f,0.3f) ,modifiers.skinColor.g,modifiers.skinColor.b + Random.Range(0.0f,0.2f),1)));
				else umaData.umaRecipe.slotDataList[9].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleLipstick01", new Color(modifiers.skinColor.r + Random.Range(0.0f,0.3f) ,modifiers.skinColor.g,modifiers.skinColor.b + Random.Range(0.0f,0.2f),1)));
			}
			
			//Nose - Head Parts Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headNoseFemale){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headNoseFemaleSlot.slotName != "FemaleHead_Nose")
					umaData.umaRecipe.slotDataList[10] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.slotHeadFemaleParts.headNoseFemaleSlot.slotName, umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[10] = slotLibrary.InstantiateSlot("FemaleHead_Nose", umaData.umaRecipe.slotDataList[1].GetOverlayList());
			}

			
			//Hair Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hair){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hairFemaleSlot.slotName != "FemaleShortHair01")
					umaData.umaRecipe.slotDataList[11] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hairFemaleSlot.slotName, umaData.umaRecipe.slotDataList[1].GetOverlayList());
				else umaData.umaRecipe.slotDataList[11] = slotLibrary.InstantiateSlot("FemaleShortHair01", umaData.umaRecipe.slotDataList[1].GetOverlayList());
				//Hair Overlay Female
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlay.overlayName != "FemaleShortHair01")
					umaData.umaRecipe.slotDataList[11].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlayColor));
				else umaData.umaRecipe.slotDataList[11].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleShortHair01", modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.hairFemaleOverlayColor));
			}

			
			//EyeBrow Overlay Female
			if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrow){
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlay.overlayName != "FemaleEyebrow01")
					umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlay.overlayName, modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlayColor));
				else umaData.umaRecipe.slotDataList[1].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleEyebrow01", modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.eyeBrowFemaleOverlayColor));
			}
			
			//Torso Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.torso){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.torsoFemaleSlot.slotName != "FemaleTorso")
					umaData.umaRecipe.slotDataList[2] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.torsoFemaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[2] = slotLibrary.InstantiateSlot("FemaleTorso");
				//Torso Overlay
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.torsoFemaleOverlay.overlayName != "FemaleBody01")
					umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.torsoFemaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleBody01", modifiers.skinColor));
				
			}
			
			//Hands Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.hands){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.handsFemaleSlot.slotName != "FemaleHands")
					umaData.umaRecipe.slotDataList[3] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.handsFemaleSlot.slotName, umaData.umaRecipe.slotDataList[2].GetOverlayList());
				else umaData.umaRecipe.slotDataList[3] = slotLibrary.InstantiateSlot("FemaleHands", umaData.umaRecipe.slotDataList[2].GetOverlayList());
			}
			
			//InnerMouth Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.innerMouth){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.innerMouthFemaleSlot.slotName != "FemaleInnerMouth")
					umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.innerMouthFemaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot("FemaleInnerMouth");
				//InnerMouth Overlay
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.mouthFemaleOverlay.overlayName!= "InnerMouth")
					umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.innerMouthFemaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay("InnerMouth", modifiers.skinColor));
				
			}
			
			//Legs Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.legs){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.legsFemaleSlot.slotName != "FemaleLegs")
					umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.legsFemaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot("FemaleLegs");
				//Legs Overlay
				if(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.legsFemaleOverlay.overlayName!= "FemaleBody01")
					umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysBodyParts.femaleOverlaysBodyParts.legsFemaleOverlay.overlayName, modifiers.skinColor));
				else umaData.umaRecipe.slotDataList[4].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleBody01", modifiers.skinColor));
			}
			
			//Feet Slot Female
			if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.feet){
				if(modifiers.testModels.slotsBodyParts.femaleSlotsBodyParts.feetFemaleSlot.slotName != "FemaleFeet")
					umaData.umaRecipe.slotDataList[5] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsBodyParts.maleSlotsBodyParts.feetMaleSlot.slotName, umaData.umaRecipe.slotDataList[2].GetOverlayList());
				else umaData.umaRecipe.slotDataList[5] = slotLibrary.InstantiateSlot("FemaleFeet", umaData.umaRecipe.slotDataList[2].GetOverlayList());
			}

		//////////////////////////
		//////Clothes Female/////
		////////////////////////
			
			//T-Shirt Slot Male
			if(modifiers.testModels.slotsClothes.femaleSlotClothes.tShirt){
				if(modifiers.testModels.slotsClothes.femaleSlotClothes.tShirtFemaleSlot.slotName != "FemaleTshirt01")
					umaData.umaRecipe.slotDataList[6] = slotLibrary.InstantiateSlot(modifiers.testModels.slotsClothes.femaleSlotClothes.tShirtFemaleSlot.slotName);
				else umaData.umaRecipe.slotDataList[6] = slotLibrary.InstantiateSlot("FemaleTshirt01");
				
				//T-Shirt Overlay Female
				if(modifiers.testModels.overlaysClothes.femaleOverlayClothes.tShirtFemaleOverlay.overlayName != "FemaleTshirt01")
					umaData.umaRecipe.slotDataList[6].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysClothes.femaleOverlayClothes.tShirtFemaleOverlay.overlayName, modifiers.testModels.overlaysClothes.femaleOverlayClothes.tShirtFemaleOverlayColor));	
				else umaData.umaRecipe.slotDataList[6].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleTshirt01", modifiers.testModels.overlaysClothes.femaleOverlayClothes.tShirtFemaleOverlayColor));	
			}

			//Underwear Overlay Female
			if(modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwear){
				if(modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwearFemaleOverlay.overlayName != "FemaleUnderwear01")
					umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwearFemaleOverlay.overlayName, modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwearFemaleOverlayColor));
				else umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleUnderwear01",  modifiers.testModels.overlaysClothes.femaleOverlayClothes.underwearFemaleOverlayColor));
			}

			//Shirt Overlay Female
			if(modifiers.testModels.overlaysClothes.femaleOverlayClothes.shirt){
				if(modifiers.testModels.overlaysClothes.femaleOverlayClothes.shirtFemaleOverlay.overlayName != "FemaleShirt01")
					umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysClothes.femaleOverlayClothes.shirtFemaleOverlay.overlayName, modifiers.testModels.overlaysClothes.femaleOverlayClothes.shirtFemaleOverlayColor));
				else umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleShirt01", modifiers.testModels.overlaysClothes.femaleOverlayClothes.shirtFemaleOverlayColor));
			}

			//Jeans Overlay Female
			if(modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeans){
				if(modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeansFemaleOverlay.overlayName != "FemaleJeans01")
					umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeansFemaleOverlay.overlayName, modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeansFemaleOverlayColor));
				else umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("FemaleJeans01", modifiers.testModels.overlaysClothes.femaleOverlayClothes.jeansFemaleOverlayColor));
			}

			int number = 12;
			//Custom SLOTS and OVERLAYS Female
			for(int i = 0; i<modifiers.testModels.customMeshesAndClothes.femaleCustom.customList.Count; i++){
				if(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].Slot){
					if(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].slotData != null){
					umaData.umaRecipe.slotDataList[(number + i)] = slotLibrary.InstantiateSlot(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].slotData.slotName);
					if(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].Overlay){
							if(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].overlayData.overlayName != null){
								umaData.umaRecipe.slotDataList[(number + i)].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].overlayData.overlayName, modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].overlayColor));
					}
					}
					}
				}
				if(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].Overlay && !modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].Slot && modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].overlayData != null){
					umaData.umaRecipe.slotDataList[(number + i)].AddOverlay(overlayLibrary.InstantiateOverlay(modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].overlayData.overlayName, modifiers.testModels.customMeshesAndClothes.femaleCustom.customList[i].overlayColor));
				}
			}

		}
	}
			
	
	void SetUMAData (){
		umaData.atlasResolutionScale = atlasResolutionScale;
		umaData.OnCharacterUpdated += MyOnUpdateMethod;
		umaData.OnCharacterUpdated += myColliderUpdateMethod;
		umaData.Dirty(true, true, true);
	}
	
	void MyOnUpdateMethod(UMAData umaData){
		
	}
	
	void myColliderUpdateMethod(UMAData umaData){
		CapsuleCollider tempCollider = umaData.GetComponent("CapsuleCollider") as CapsuleCollider;
		if(tempCollider){ 
			UMADnaHumanoid umaDna = umaData.umaRecipe.GetDna<UMADnaHumanoid>();
			tempCollider.height = (umaDna.height + 0.5f)*2 + 0.1f;
			tempCollider.center = new Vector3(0,tempCollider.height*0.5f - 0.04f,0);
		}
	}
	
	void GenerateUMAShapes (){		
		UMADnaHumanoid umaDna = new UMADnaHumanoid();
		//umaData.umaRecipe.umaDna.Add(umaDna.GetType(),umaDna);
		umaData.umaRecipe.AddDna(umaDna);
		if(randomDna){
			
			umaDna.height = Random.Range(0.3f,0.5f);
			umaDna.headSize = Random.Range(0.485f,0.515f);
			umaDna.headWidth = Random.Range(0.4f,0.6f);
			
			umaDna.neckThickness = Random.Range(0.495f,0.51f);
			
			if (umaData.umaRecipe.raceData.raceName == "HumanMale"){
				umaDna.handsSize = Random.Range(0.485f,0.515f);
				umaDna.feetSize = Random.Range(0.485f,0.515f);
				umaDna.legSeparation = Random.Range(0.4f,0.6f);
				umaDna.waist = 0.5f;
			}else{
				umaDna.handsSize = Random.Range(0.485f,0.515f);
				umaDna.feetSize = Random.Range(0.485f,0.515f);
				umaDna.legSeparation = Random.Range(0.485f,0.515f);
				umaDna.waist = Random.Range(0.3f,0.8f);
			}
			
			
			umaDna.armLength = Random.Range(0.485f,0.515f);
			umaDna.forearmLength = Random.Range(0.485f,0.515f);
			umaDna.armWidth = Random.Range(0.3f,0.8f);
			umaDna.forearmWidth = Random.Range(0.3f,0.8f);
			
			umaDna.upperMuscle = Random.Range(0.0f,1.0f);
			umaDna.upperWeight = Random.Range(-0.2f,0.2f) + umaDna.upperMuscle;
			if(umaDna.upperWeight > 1.0){ umaDna.upperWeight = 1.0f;}
			if(umaDna.upperWeight < 0.0){ umaDna.upperWeight = 0.0f;}
			
			umaDna.lowerMuscle = Random.Range(-0.2f,0.2f) + umaDna.upperMuscle;
			if(umaDna.lowerMuscle > 1.0){ umaDna.lowerMuscle = 1.0f;}
			if(umaDna.lowerMuscle < 0.0){ umaDna.lowerMuscle = 0.0f;}
			
			umaDna.lowerWeight = Random.Range(-0.1f,0.1f) + umaDna.upperWeight;
			if(umaDna.lowerWeight > 1.0){ umaDna.lowerWeight = 1.0f;}
			if(umaDna.lowerWeight < 0.0){ umaDna.lowerWeight = 0.0f;}
			
			umaDna.belly = umaDna.upperWeight;
			umaDna.legsSize = Random.Range(0.4f,0.6f);
			umaDna.gluteusSize = Random.Range(0.4f,0.6f);
			
			umaDna.earsSize = Random.Range(0.3f,0.8f);
			umaDna.earsPosition = Random.Range(0.3f,0.8f);
			umaDna.earsRotation = Random.Range(0.3f,0.8f);
			
			umaDna.noseSize = Random.Range(0.3f,0.8f);
			
			umaDna.noseCurve = Random.Range(0.3f,0.8f);
			umaDna.noseWidth = Random.Range(0.3f,0.8f);
			umaDna.noseInclination = Random.Range(0.3f,0.8f);
			umaDna.nosePosition = Random.Range(0.3f,0.8f);
			umaDna.nosePronounced = Random.Range(0.3f,0.8f);
			umaDna.noseFlatten = Random.Range(0.3f,0.8f);
			
			umaDna.chinSize = Random.Range(0.3f,0.8f);
			umaDna.chinPronounced = Random.Range(0.3f,0.8f);
			umaDna.chinPosition = Random.Range(0.3f,0.8f);
			
			umaDna.mandibleSize = Random.Range(0.45f,0.52f);
			umaDna.jawsSize = Random.Range(0.3f,0.8f);
			umaDna.jawsPosition = Random.Range(0.3f,0.8f);
			
			umaDna.cheekSize = Random.Range(0.3f,0.8f);
			umaDna.cheekPosition = Random.Range(0.3f,0.8f);
			umaDna.lowCheekPronounced = Random.Range(0.3f,0.8f);
			umaDna.lowCheekPosition = Random.Range(0.3f,0.8f);
			
			umaDna.foreheadSize = Random.Range(0.3f,0.8f);
			umaDna.foreheadPosition = Random.Range(0.15f,0.65f);
			
			umaDna.lipsSize = Random.Range(0.3f,0.8f);
			umaDna.mouthSize = Random.Range(0.3f,0.8f);
			umaDna.eyeRotation = Random.Range(0.3f,0.8f);
			umaDna.eyeSize = Random.Range(0.3f,0.8f);
			umaDna.breastSize = Random.Range(0.3f,0.8f);
			
			
		}
	}
	
	void GenerateOneUMA(){
		var newGO = new GameObject("Generated Character");
		newGO.transform.parent = transform;
		var umaDynamicAvatar = newGO.AddComponent<UMADynamicAvatar>();
		umaDynamicAvatar.Initialize();
		umaData = umaDynamicAvatar.umaData;
		umaDynamicAvatar.umaGenerator = generator;
		umaData.umaGenerator = generator;
		var umaRecipe = umaDynamicAvatar.umaData.umaRecipe;

		
		if(modifiers.Male)
		{
			umaRecipe.SetRace(raceLibrary.GetRace("HumanMale"));
		}else{
			umaRecipe.SetRace(raceLibrary.GetRace("HumanFemale"));
		}
		
		SetUMAData();
		GenerateUMAShapes();
		
		DefineSlots();
		
		umaDynamicAvatar.UpdateNewRace();
		umaDynamicAvatar.umaData.myRenderer.enabled = false;
		tempUMA = umaData.umaRoot.transform;
		
		if (zeroPoint)
		{
			tempUMA.position = new Vector3(zeroPoint.position.x, zeroPoint.position.y, zeroPoint.position.z);
		}
		else
		{
			tempUMA.position = new Vector3(0, 0, 0);
		}
		
		
	}
}
