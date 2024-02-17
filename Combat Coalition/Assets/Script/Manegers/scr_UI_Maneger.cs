using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class scr_UI_Maneger : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    [SerializeField] TextMeshProUGUI FPSText;
    public static scr_UI_Maneger Instance;
    private float CurrentRectileSize;
    private RectTransform Rectile;
    [Header("Interact")]
    [SerializeField] GameObject InteractObj;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Slider slider;
    [Header("CrossHair")]
    [SerializeField] float MaxRectileSize;
    [SerializeField] float MinRectileSize;
    [SerializeField] float RectileSizeSmoothing;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        Instance = this;
    }
    private void Start()
    {
        scr_GameManeger.Instance.OnFpsUpdateText += UpdateFPSText;
        foreach (var Player in scr_GameManeger.Instance.GetPlayerList())
        {
            CurrentRectileSize = MinRectileSize;
            if (Player.WeaponController.GetWeapon().GetScr_WeaponSO().WeaponType == scr_Models.WeaponType.Gun)
            {
                var gunso = Player.WeaponController.GetWeapon().GetScr_WeaponSO() as scr_GunSO;
                Rectile = Instantiate(gunso.Rectile, canvas.transform);
            }
        }
    }


    public void Interact(scr_Pickable pickable,float holdTime)
    {
        InteractObj.SetActive(pickable);
        if (pickable == null) return;
        Debug.Log(holdTime);
        slider.value = holdTime;
        text.text = pickable.Weapon.GetScr_WeaponSO().WeaponName;
    }
    private void LateUpdate()
    { 
        UpdateRectileSize();
    }
    void UpdateRectileSize()
    {
        if (scr_InputManeger.Instance.Input_Movement != Vector2.zero)
        {
            CurrentRectileSize = Mathf.Lerp(CurrentRectileSize, MaxRectileSize, RectileSizeSmoothing);
        }
        else
        {
            CurrentRectileSize = Mathf.Lerp(CurrentRectileSize, MinRectileSize, RectileSizeSmoothing);
        }
        if (Rectile != null)
        {
            Rectile.sizeDelta = new Vector2(CurrentRectileSize, CurrentRectileSize);
        }
    }
    void UpdateFPSText(object sender,scr_GameManeger.OnFpsUpdateTextEventArgs e)
    {
        FPSText.text = e.FrameRate + " fps";
    }
}
