using UnityEngine;
using AWSSDK.Tests;
using UnityEditor;
using System;
using System.IO;
using UnityEngine.UI;

public class BuildTools
{
    private const string TestDriverScenePath = @"Assets\TestDriver.unity";
    public static void Android()
    {
#if UNITY_5
        var buildpath = ValidateBuildPath(@"Android");
        AddTestDriverComponent();
        BuildPipeline.BuildPlayer(
            new string[] { TestDriverScenePath },
            string.Format("{0}{1}UnityTestRunner.apk", buildpath, Path.DirectorySeparatorChar),
            BuildTarget.Android, BuildOptions.Development | BuildOptions.AllowDebugging);
#endif
    }

    public static void Ios64()
    {
#if UNITY_5
        var buildpath = ValidateBuildPath(@"iOS64");
        AddTestDriverComponent();
        PlayerSettings.SetPropertyInt("ScriptingBackend", (int)ScriptingImplementation.IL2CPP, BuildTarget.iOS);
        PlayerSettings.SetPropertyInt("Architecture", 2, BuildTarget.iOS);//corresponds to iphone architecture universal
        BuildPipeline.BuildPlayer(new string[] { TestDriverScenePath }, buildpath, BuildTarget.iOS, BuildOptions.Development | BuildOptions.AllowDebugging);
#endif
    }

    public static void IosMono()
    {
#if UNITY_5
        var buildpath = ValidateBuildPath(@"iOSMono");
        AddTestDriverComponent();
        PlayerSettings.SetPropertyInt("ScriptingBackend", (int)ScriptingImplementation.Mono2x, BuildTarget.iOS);
        PlayerSettings.SetPropertyInt("Architecture", 0, BuildTarget.iOS);//corresponds to iphone architecture armv7
        BuildPipeline.BuildPlayer(new string[] { TestDriverScenePath }, buildpath, BuildTarget.iOS, BuildOptions.None);
#endif
    }

#if UNITY_5
    private static string ValidateBuildPath(string Platform)
    {

        var buildPath = Environment.GetEnvironmentVariable("UNITYBUILDPATH");

        if (string.IsNullOrEmpty(buildPath))
            throw new ArgumentNullException("UNITYBUILDPATH");

        buildPath = buildPath.Replace('\\', Path.DirectorySeparatorChar);

        Debug.Log(buildPath);

        if (!Directory.Exists(buildPath))
            Directory.CreateDirectory(buildPath);


        var platformPath = string.Format("{0}{1}{2}", buildPath, Path.DirectorySeparatorChar, Platform);
        if (!Directory.Exists(platformPath))
            Directory.CreateDirectory(platformPath);


        return platformPath;

    }

    [MenuItem("AWSTest/Refresh Test Driver Script")]
    public static void AddTestDriverComponent()
    {
        if (EditorApplication.currentScene != TestDriverScenePath)
        {
            Debug.Log(EditorApplication.currentScene);
            EditorApplication.OpenScene(TestDriverScenePath);
        }
        object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));
        GameObject testDriver = null;
        GameObject results = null;
        foreach (object obj in objects)
        {
            GameObject gameObj = (GameObject)obj;
            if (gameObj.name == "TestDriver")
            {
                testDriver = gameObj;
            }
            else if (gameObj.name == "Results")
            {
                results = gameObj;
            }
        }
        if (testDriver != null)
        {
            GameObject.DestroyImmediate(testDriver);
        }
        testDriver = new GameObject("TestDriver");
        var testDriverComponent = testDriver.AddComponent<TestDriver>();
        testDriverComponent.ResultsText = results.GetComponent<Text>();

    }
#endif


}
