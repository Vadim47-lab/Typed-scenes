﻿using UnityEngine;
using IJunior.TypedScenes;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private LevelConfig _levelConfig;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Game.Load(_levelConfig);
        }
    }
}