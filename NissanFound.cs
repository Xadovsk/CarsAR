using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class NissanFound : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    public GameObject nissanB, silvia;
    public GameObject info, infoPanel;

    
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour) ;
        mTrackableBehaviour.RegisterTrackableEventHandler(this);

    }

    //Check to see if the image found is the nissan logo. If it is activate car models, buttons and infos.
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {
            infoPanel.SetActive(true);
            silvia.SetActive(true);
            nissanB.SetActive(true);
            info.SetActive(true);
        }
        else
        {
            infoPanel.SetActive(false);
            silvia.SetActive(false);
            nissanB.SetActive(false);
            info.SetActive(false);
        }
    }
}

