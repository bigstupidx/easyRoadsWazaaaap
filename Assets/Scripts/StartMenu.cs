using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	public GameObject loadScreen;
	public GameObject backMenu;
	public GameObject abs;
	public GameObject prclose;

	public void moreGames()
	{
		Application.OpenURL ("https://play.google.com/store/apps/developer?id=i6+Games");
	}
	public void onGamePress()
	{
		AppSoundManager.Get ().PlaySfx (Sfx.Type.sfx_click);
//		if (GameData.Get ().interstitialCount == 0)
//			GameObject.Find ("AdmobAdAgent").GetComponent<AdMob_Manager> ().showInterstitialDelegate (OnInterstitialCallback);
		loadScreen.SetActive (true);
		GoTo.LoadNewShop ();
	}

	private void OnInterstitialCallback(){
		if(GameData.Get ().interstitialCount == 0)
			GameData.Get ().interstitialCount++;
	}

	public void onShopPress()
	{
		loadScreen.SetActive (true);
		GoTo.LoadShop();
	}

	void Awake()
	{
		GameData.Get ();
		DontDestroyOnLoad (abs);
	}
	void Start()
	{
		IAS_Manager.Instance.ResetMainBanners(); 
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			PreClosePopup.showPopup = true;
			backMenu.SetActive(true);
		}
	}
}
