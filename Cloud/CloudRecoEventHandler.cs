/*==============================================================================
Copyright (c) 2015-2018 PTC Inc. All Rights Reserved.

Copyright (c) 2012-2015 Qualcomm Connected Experiences, Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
==============================================================================*/
using UnityEngine;
using Vuforia;

/// <summary>
/// This MonoBehaviour implements the Cloud Reco Event handling for this sample.
/// It registers itself at the CloudRecoBehaviour and is notified of new search results as well as error messages
/// The current state is visualized and new results are enabled using the TargetFinder API.
/// </summary>
public class CloudRecoEventHandler : MonoBehaviour, IObjectRecoEventHandler
{
    #region PRIVATE_MEMBERS
    CloudRecoBehaviour m_CloudRecoBehaviour;
    ObjectTracker m_ObjectTracker;
    TargetFinder m_TargetFinder;
    #endregion // PRIVATE_MEMBERS

    private string targetName = "P0000";


    #region PUBLIC_MEMBERS
    /// <summary>
    /// Can be set in the Unity inspector to reference a ImageTargetBehaviour 
    /// that is used for augmentations of new cloud reco results.
    /// </summary>
    [Tooltip("Here you can set the ImageTargetBehaviour from the scene that will be used to " +
             "augment new cloud reco search results.")]
    public ImageTargetBehaviour m_ImageTargetBehaviour;
    public UnityEngine.UI.Image m_CloudActivityIcon;
    public UnityEngine.UI.Image m_CloudIdleIcon;

    public GameObject o1;
    public GameObject o11;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject o5;
    public GameObject o6;
    public GameObject o7;
    public GameObject o8;
    public GameObject o9;


    #endregion // PUBLIC_MEMBERS


    #region MONOBEHAVIOUR_METHODS
    /// <summary>
    /// Register for events at the CloudRecoBehaviour
    /// </summary>
    void Start()
    {
        o1.SetActive(false);
        o11.SetActive(false);
        o2.SetActive(false);
        o3.SetActive(false);
        o4.SetActive(false);
        o5.SetActive(false);
        o6.SetActive(false);
        o7.SetActive(false);
        o8.SetActive(false);
        o9.SetActive(false);
        // Register this event handler at the CloudRecoBehaviour
        m_CloudRecoBehaviour = GetComponent<CloudRecoBehaviour>();
        if (m_CloudRecoBehaviour)
        {
            m_CloudRecoBehaviour.RegisterEventHandler(this);
        }

        if (m_CloudActivityIcon)
        {
            m_CloudActivityIcon.enabled = false;
        }
    }

    void Update()
    {
        if (m_CloudRecoBehaviour.CloudRecoInitialized && m_TargetFinder != null)
        {
            SetCloudActivityIconVisible(m_TargetFinder.IsRequesting());
        }

        if (m_CloudIdleIcon)
        {
            m_CloudIdleIcon.color = m_CloudRecoBehaviour.CloudRecoEnabled ? Color.white : Color.gray;
        }
    }
    #endregion // MONOBEHAVIOUR_METHODS


    #region INTERFACE_IMPLEMENTATION_ICloudRecoEventHandler
    /// <summary>
    /// called when TargetFinder has been initialized successfully
    /// </summary>
    public void OnInitialized()
    {
        Debug.Log("Cloud Reco initialized successfully.");

        m_ObjectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
        m_TargetFinder = m_ObjectTracker.GetTargetFinder<ImageTargetFinder>();
    }

    public void OnInitialized(TargetFinder targetFinder)
    {
        Debug.Log("Cloud Reco initialized successfully.");

        m_ObjectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
        m_TargetFinder = targetFinder;
    }

    // Error callback methods implemented in CloudErrorHandler
    public void OnInitError(TargetFinder.InitState initError) { }
    public void OnUpdateError(TargetFinder.UpdateState updateError) { }


    /// <summary>
    /// when we start scanning, unregister Trackable from the ImageTargetBehaviour, 
    /// then delete all trackables
    /// </summary>
    public void OnStateChanged(bool scanning)
    {
        Debug.Log("<color=blue>OnStateChanged(): </color>" + scanning);

        if (scanning)
        {
            // clear all known trackables
            var tracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
            tracker.GetTargetFinder<ImageTargetFinder>().ClearTrackables(false);
        }
    }

    private string mTargetMetadata = "";
    /// <summary>
    /// Handles new search results
    /// </summary>
    /// <param name="targetSearchResult"></param>
    public void OnNewSearchResult(TargetFinder.TargetSearchResult targetSearchResult)
    {
        o1.SetActive(false);
        o11.SetActive(false);
        o2.SetActive(false);
        o3.SetActive(false);
        o4.SetActive(false);
        o5.SetActive(false);
        o6.SetActive(false);
        o7.SetActive(false);
        o8.SetActive(false);
        o9.SetActive(false);

        Debug.Log("<color=blue>OnNewSearchResult(): </color>" + targetSearchResult.TargetName);

        TargetFinder.CloudRecoSearchResult cloudRecoResult = (TargetFinder.CloudRecoSearchResult)targetSearchResult;
        TargetFinder.CloudRecoSearchResult cloudRecoResult1 = (TargetFinder.CloudRecoSearchResult)targetSearchResult;

        if (cloudRecoResult.MetaData == null)
            {
               Debug.Log("Target metadata not available.");
            }
            else if(targetSearchResult.TargetName == "P0000")
            {
            o3.SetActive(false);
            o2.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(false);
            o7.SetActive(false);
            o8.SetActive(false);
            o9.SetActive(false);
            o1.SetActive(true);
            o11.SetActive(true);
            //Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);
            }
            else if (targetSearchResult.TargetName == "P0001")
            {
            o3.SetActive(false);
            o2.SetActive(true);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(false);
            o7.SetActive(false);
            o8.SetActive(false);
            o9.SetActive(false);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

            }
            else if (targetSearchResult.TargetName == "P0002")
            {
            o3.SetActive(true);
            o2.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(false);
            o7.SetActive(false);
            o8.SetActive(false);
            o9.SetActive(false);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

            }
        else if (targetSearchResult.TargetName == "P0003")
        {
            o3.SetActive(false);
            o2.SetActive(false);
            o4.SetActive(true);
            o5.SetActive(false);
            o6.SetActive(false);
            o7.SetActive(false);
            o8.SetActive(false);
            o9.SetActive(false);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

        }
        else if (targetSearchResult.TargetName == "P0004")
        {
            o3.SetActive(false);
            o2.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(true);
            o6.SetActive(false);
            o7.SetActive(false);
            o8.SetActive(false);
            o9.SetActive(false);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

        }
        else if (targetSearchResult.TargetName == "P0005")
        {
            o3.SetActive(false);
            o2.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(true);
            o7.SetActive(false);
            o8.SetActive(false);
            o9.SetActive(false);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

        }
        else if (targetSearchResult.TargetName == "P0006")
        {
            o3.SetActive(false);
            o2.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(false);
            o7.SetActive(true);
            o8.SetActive(false);
            o9.SetActive(false);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

        }
        else if (targetSearchResult.TargetName == "P0007")
        {
            o3.SetActive(false);
            o2.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(false);
            o7.SetActive(false);
            o8.SetActive(true);
            o9.SetActive(false);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

        }
        else if (targetSearchResult.TargetName == "P0008")
        {
            o3.SetActive(false);
            o2.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(false);
            o7.SetActive(false);
            o8.SetActive(false);
            o9.SetActive(true);
            o1.SetActive(false);
            o11.SetActive(false);
            // Destroy(o1.gameObject);
            Debug.Log("MetaData: " + cloudRecoResult.MetaData);
            Debug.Log("TargetName: " + cloudRecoResult.TargetName);
            Debug.Log("Pointer: " + cloudRecoResult.TargetSearchResultPtr);
            Debug.Log("TrackingRating: " + cloudRecoResult.TrackingRating);

        }


        // Changing CloudRecoBehaviour.CloudRecoEnabled to false will call TargetFinder.Stop()
        // and also call all registered ICloudRecoEventHandler.OnStateChanged() with false.
        m_CloudRecoBehaviour.CloudRecoEnabled = true;

            // Clear any existing trackables
            m_TargetFinder.ClearTrackables(false);

            // Enable the new result with the same ImageTargetBehaviour:
            m_TargetFinder.EnableTracking(cloudRecoResult, m_ImageTargetBehaviour.gameObject);
            //o1.SetActive(true);

            // Pass the TargetSearchResult to the Trackable Event Handler for processing
            m_ImageTargetBehaviour.gameObject.SendMessage("TargetCreated", cloudRecoResult, SendMessageOptions.DontRequireReceiver);
        
    }
    #endregion // INTERFACE_IMPLEMENTATION_ICloudRecoEventHandler


    #region PRIVATE_METHODS
    void SetCloudActivityIconVisible(bool visible)
    {
        if (!m_CloudActivityIcon) return;

        m_CloudActivityIcon.enabled = visible;
    }
    #endregion // PRIVATE_METHODS
}
