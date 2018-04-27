using UnityEngine;
using VRTK;

public class SnapDropTestEvents : MonoBehaviour
{
    public void OnEnterZone(object obj, SnapDropZoneEventArgs args)
    {
        Debug.Log("OnEnterZone " + obj.GetType().Name + " SnapDuration=" + ((VRTK_SnapDropZone) obj).snapDuration);
    }

    public void OnExitZone(object obj, SnapDropZoneEventArgs args)
    {
        Debug.Log("OnExitZone");
    }

    public void OnSnappedZone(object obj, SnapDropZoneEventArgs args)
    {
        Debug.Log("OnSnappedZone");
    }

    public void OnUnsnappedZone(object obj, SnapDropZoneEventArgs args)
    {
        Debug.Log("OnUnsnappedZone");
    }
}
