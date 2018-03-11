using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("MainInstaller InstallBindings");
    }

    public override void Start()
    {
        Debug.Log("MainInstaller Start");
    }
}
