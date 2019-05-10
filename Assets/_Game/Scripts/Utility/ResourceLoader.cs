using UnityEngine;
using System.Collections;

public class ResourceLoader
{
    public const string STAGE_RESOURCE_PATH = "Prefabs/Backgrounds";

    static public GameObject GetBackgroundByName(string name)
    {
        return (GameObject)Resources.Load(STAGE_RESOURCE_PATH+"/"+name);
    }
}
