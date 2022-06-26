using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class LevelNeeds : Editor
{
    [MenuItem("Level/Needed")]
    private static void SetupLevel()
    {
        PrefabUtility.InstantiatePrefab(Resources.Load("Prefabs/LevelBuild/WayPointPlacing"));
        PrefabUtility.InstantiatePrefab(Resources.Load("Prefabs/LevelBuild/TowerPlacing"));
        PrefabUtility.InstantiatePrefab(Resources.Load("Prefabs/LevelBuild/WayPointHandler"));
        PrefabUtility.InstantiatePrefab(Resources.Load("Prefabs/LevelBuild/SpawnSystem"));


        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
    }
}
