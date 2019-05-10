using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class TurretSceneManager : Singleton<TurretSceneManager>
{
    public delegate void FloatDelegate(float num);
    public FloatDelegate OnMapWidthChange;

    private void Start()
    {
        var backgroundParent = GameObject.Find(StageManager.BACKGROUND_STAGE_FIND_PATH)?.transform;
        var backgroundPrefab = ResourceLoader.GetBackgroundByName("StandardBG");
        GameObject newBackground = (GameObject)Instantiate(backgroundPrefab, backgroundParent);
        float mapWidth = newBackground.GetComponent<SpriteRenderer>().bounds.size.x;
        OnMapWidthChange?.Invoke(mapWidth);
    }
}
