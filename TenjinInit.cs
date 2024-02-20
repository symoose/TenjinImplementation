using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenjinInit : MonoBehaviour
{
    void Start()
    {
        MaxSdkCallbacks.OnSdkInitializedEvent +=(MaxSdkBase.SdkConfiguration sdkConfiguration) => TenjinConnect();
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (!pauseStatus)
        {
            MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) => TenjinConnect();
        }
    }

    public void TenjinConnect()
    {
        BaseTenjin instance = Tenjin.getInstance("AAAAAAAAAAAAAAAAAAAAAAA");
        instance.SetAppStoreType(AppStoreType.googleplay);
        bool optInOut = instance.OptInOutUsingCMP();
        if (optInOut) instance.OptIn();
        else instance.OptOut();
        // Sends install/open event to Tenjin
        instance.Connect();
        instance.SubscribeAppLovinImpressions();
    }
}
