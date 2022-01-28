using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(ARRaycastManager))]

public class PlacementControllerWithMultiple : MonoBehaviour
{
    [SerializeField]
    private Button fireButton;
    [SerializeField]
    private Button waterButton;
    [SerializeField]
    private Button airButton;
    [SerializeField]
    private Button earthButton;
    public Camera arCamera;
    private GameObject placedPrefab;
    private ARRaycastManager arRaycastManager;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public bool isSelected;
    public GameObject fireInteractable;
    public GameObject waterInteractable;
    public GameObject airInteractable;
    public GameObject earthInteractable;



    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
        //fireButton.onClick.AddListener(() => ChangePrefabTo("FireInteractable"));
        //fireButton.onClick.AddListener(() => ChangePrefabTo("WaterInteractable"));
        ChangePrefabTo("FireInteractable");
    }

    public void ChangePrefabTo(string prefabName)
    {
        /*placedPrefab = Resources.Load<GameObject>($"Prefabs/{prefabName}");
        if (placedPrefab == null)
        {
            Debug.LogError($"Prefab with name {prefabName} could not be loaded, make sure you check the naming of your prefabs...");
            Logger.Instance.LogInfo($"Prefab with name {prefabName} could not be loaded, make sure you check the naming of your prefabs...");
        }*/
        //create temp color var to access alpha.
        Color firec = fireButton.image.color;
        Color waterc = waterButton.image.color;
        Color airc = airButton.image.color;
        Color earthc = earthButton.image.color;

        //Debug.Log("is fire" + firec.a + " " + waterc.a);
        switch (prefabName)
        {
            case "FireInteractable":
                Debug.Log("is fire");
                Logger.Instance.LogInfo("is fire");
                firec.a = 1f;
                waterc.a = 0.5f;
                airc.a = 0.5f;
                earthc.a = 0.5f;
                waterInteractable.SetActive(false);
                fireInteractable.SetActive(true);
                airInteractable.SetActive(false);
                earthInteractable.SetActive(false);
                break;
            case "WaterInteractable":
                Debug.Log("is water");
                Logger.Instance.LogInfo("is water");
                firec.a = 0.5f;
                waterc.a = 1f;
                airc.a = 0.5f;
                earthc.a = 0.5f;
                fireInteractable.SetActive(false);
                waterInteractable.SetActive(true);
                airInteractable.SetActive(false);
                earthInteractable.SetActive(false);
                break;
            case "AirInteractable":
                Debug.Log("is air");
                Logger.Instance.LogInfo("is air");
                firec.a = 0.5f;
                waterc.a = 0.5f;
                airc.a = 1f;
                earthc.a = 0.5f;
                fireInteractable.SetActive(false);
                waterInteractable.SetActive(false);
                airInteractable.SetActive(true);
                earthInteractable.SetActive(false);
                break;
            case "EarthInteractable":
                Debug.Log("is earth");
                Logger.Instance.LogInfo("is earth");
                firec.a = 0.5f;
                waterc.a = 0.5f;
                airc.a = 0.5f;
                earthc.a = 1f;
                fireInteractable.SetActive(false);
                waterInteractable.SetActive(false);
                airInteractable.SetActive(false);
                earthInteractable.SetActive(true);
                break;
        }
        fireButton.image.color = firec;
        waterButton.image.color = waterc;
        airButton.image.color = airc;
        earthButton.image.color = earthc;
        
    }

    void Update()
    {
        if (placedPrefab == null)
        {
            return;
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                bool isOverUI = EventSystem.current.IsPointerOverGameObject(touch.fingerId);
                if (isOverUI)
                {
                    Debug.Log(" blocked raycast");
                    Logger.Instance.LogInfo(" blocked raycast by UI");
                    return;
                }

            }
            Ray ray = arCamera.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Logger.Instance.LogInfo("Casting out ray");
                if (hit.collider.tag == "fire" || hit.collider.tag == "water" || hit.collider.tag == "air" || hit.collider.tag == "earth")
                {
                    Logger.Instance.LogInfo(" blocked raycast by already spawned object " + hit.collider.tag);
                    return;
                }
            }

            var touchPosition = touch.position;
            //Check if AR Ray cast hits a trackable plane
            /*if (arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes))
            {
                if (isSelected == false)
                {
                    Debug.Log("ar raycast");
                    Logger.Instance.LogInfo("Instantiating object");
                    var hitPose = hits[0].pose;
                    Instantiate(placedPrefab, hitPose.position, hitPose.rotation);
                }
            }*/
        }
    }
}
    //public void ChangePrefab(string prefabName)
    //{
    //    switch (prefabName)
    //    {
    //            case "fire":
    //                placementPrefab = fire;
    //                break;
    //            case "water":
    //                placementPrefab = water;
    //                break;
    //    }

    //}

