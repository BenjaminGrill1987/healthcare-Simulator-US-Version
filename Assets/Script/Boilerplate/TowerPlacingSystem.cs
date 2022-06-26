using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif

public class TowerPlacingSystem : Singleton<TowerPlacingSystem>
{
    [SerializeField] private GameObject towerPlace;
    [SerializeField] private int remove;

    private List<GameObject> towerPlaces;


    private int index = 1;

#if UNITY_EDITOR
    [Button]
    private void AddTowerPlace()
    {
        int childs = transform.childCount;

        if (index <= childs)
        {
            index = childs + 1;
        }

        GameObject tower = Instantiate(towerPlace, gameObject.transform.position, Quaternion.identity);
        tower.name = "TowerPlace" + index;
        tower.transform.parent = this.gameObject.transform;
        DrawIcon(tower, 1);

        index++;

        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
    }

    [Button]
    private void RemoveTowerPlace()
    {
        int childs = transform.childCount;
        if (remove > 0 && remove < childs + 1)
        {
            if (index <= childs + 1 && index != 1)
            {
                index = childs + 1;
            }

            for (int i = 0; i < childs; i++)
            {
                if (remove - 1 == i)
                {
                    DestroyImmediate(transform.GetChild(i).gameObject);
                    index--;
                    Rearange();
                }
            }
            EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        }
        else
        {
            Debug.LogError("No Tower to remove");
        }
    }

    [Button]
    private void RemoveLastTowerPlace()
    {
        int childs = transform.childCount;

        if (index <= childs + 1 && index != 1)
        {
            index = childs + 1;
        }

        for (int i = 0; i < childs; i++)
        {
            if (i == childs - 1)
            {
                DestroyImmediate(transform.GetChild(i).gameObject);
                index--;
            }
        }
        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
    }

    private void Rearange()
    {
        int childs = transform.childCount;
        for (int i = 0; i < childs; i++)
        {
            transform.GetChild(i).name = "TowerPlace" + (i + 1);
        }
    }

    private void DrawIcon(GameObject gameObject, int idx)
    {
        GUIContent[] icons = GetTextures("sv_label_", string.Empty, 0, 8);
        GUIContent icon = icons[idx];
        EditorGUIUtility.SetIconForObject(gameObject, (Texture2D)icon.image);
    }

    private GUIContent[] GetTextures(string baseName, string postFix, int startIndex, int count)
    {
        GUIContent[] Iconarray = new GUIContent[count];
        for (int i = 0; i < count; i++)
        {
            Iconarray[i] = EditorGUIUtility.IconContent(baseName + (startIndex + i) + postFix);
        }
        return Iconarray;
    }
#endif
}
