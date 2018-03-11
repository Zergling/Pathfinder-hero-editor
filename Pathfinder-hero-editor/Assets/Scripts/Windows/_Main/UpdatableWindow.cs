using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatableWindow : BaseWindow
{
    public void UpdateInfo(object info)
    {
        if (info == null)
            return;

        OnUpdateInfo(info);
    }

    protected virtual void OnUpdateInfo(object info)
    {
    }
}
