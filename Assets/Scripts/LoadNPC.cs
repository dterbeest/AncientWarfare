using UnityEngine;
using System.Collections;
using UMA;
using com.ootii.Cameras;

public class LoadNPC : BaseBehaviour {

  public string txtFileName;
  public IndAdventureRig camRig;

  public override void Start() {
    Load();
  }

  public override void OnGUI() {
    // if (GUI.Button(new Rect(10,10,100,100), "Load NPC")) {
      // Load();
    // }
  }

  private void Load() {
    GameObject go = new GameObject("Player");
    UMAAvatarBase ua = go.AddComponent<UMADynamicAvatar>();
    ua.context = UMAContext.FindInstance();

    ua.Initialize();

    string path = Application.dataPath + "/" + txtFileName;
    var asset = ScriptableObject.CreateInstance<UMATextRecipe>();
    asset.recipeString = System.IO.File.ReadAllText(path);
    ua.Load(asset);
    Destroy(asset);
    camRig.Anchor = go.GetComponentInChildren<Locomotion>().transform;
    // NPC npc = go.AddComponent<NPC>();
  }
}
