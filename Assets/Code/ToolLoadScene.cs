//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor.SceneManagement;
//using UnityEditor;
//using UnityEngine;

//public class ToolLoadScene : MonoBehaviour
//{
//    [MenuItem("Open Scene/Load &1")]
//    public static void OpenSceneRoot()
//    {
//        OpenScene("Loading");
//    }

//    [MenuItem("Open Scene/Home &2")]
//    public static void OpenSceneMenu()
//    {
//        OpenScene("HomeScene");
//    }

//    [MenuItem("Open Scene/GamePlay &3")]
//    public static void OpenSceneGamePlay()
//    {
//        OpenScene("GamePlay");
//    }


//    public static void OpenScene(string sceneName)
//    {
//        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
//        {
//            EditorSceneManager.OpenScene("Assets/Scenes/" + sceneName + ".unity");
//        }
//    }
//}
