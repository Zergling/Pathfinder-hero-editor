using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller
{
    [SerializeField] private WindowsManager _windowsManager;

    public override void InstallBindings()
    {
        Debug.Log("MainInstaller InstallBindings");

        Container.BindInstance(_windowsManager).AsSingle();
    }

    public override void Start()
    {
        Debug.Log("MainInstaller Start");
        _windowsManager.Show<FontTestWindow>();
    }
}
