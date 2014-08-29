using UnityEngine;
using System.Collections;
using UMA;
using com.ootii.Cameras;
using com.ootii.AI.Controllers;

public class LoadPlayer : BaseBehaviour {

  public string txtFileName;
  public AdventureRig camRig;
  public UIFade mainFadeEffect;

  public override void Start() {
    Load();
    StartCoroutine("StartFade");
  }

  private IEnumerator StartFade()
  {
    yield return new WaitForSeconds(2);
    mainFadeEffect.StartFadeOut(1f);
  }

  private void Load() {
    Debug.Log("!!");
    GameObject go = new GameObject("Player");
    UMAAvatarBase ua = go.AddComponent<UMADynamicAvatar>();
    ua.context = UMAContext.FindInstance();

    ua.Initialize();

    string path = Application.dataPath + "/" + txtFileName;
    var asset = ScriptableObject.CreateInstance<UMATextRecipe>();
    asset.recipeString = System.IO.File.ReadAllText(path);
    ua.Load(asset);
    Destroy(asset);
    //set rigs controller and controllers rig!!
    AdventureController ac = go.GetComponentInChildren<AdventureController>();
    Debug.Log(ac.ToString());
    camRig._Controller = ac;
    ac._CameraRig = camRig;
    Animator anim = ac.transform.GetComponent<Animator>();

    // NPC npc = go.AddComponent<NPC>();
  }
}
