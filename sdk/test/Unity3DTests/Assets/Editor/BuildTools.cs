using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Linq;
using System;
using System.IO;

public class BuildTools
{

    public static void Android()
    {
        var buildpath = ValidateBuildPath(@"Android");
        BuildPipeline.BuildPlayer(new string[] { @"Assets\TestDriver.unity" }, string.Format("{0}{1}UnityTestRunner.apk", buildpath, Path.DirectorySeparatorChar), BuildTarget.Android, BuildOptions.None);
    }

    public static void Ios64()
    {
        var buildpath = ValidateBuildPath(@"iOS64");
        PlayerSettings.SetPropertyInt("ScriptingBackend", (int)ScriptingImplementation.IL2CPP, BuildTarget.iOS);
        PlayerSettings.SetPropertyInt("Architecture", 2, BuildTarget.iOS);//corresponds to iphone architecture universal
        BuildPipeline.BuildPlayer(new string[] { @"Assets\TestDriver.unity" }, buildpath, BuildTarget.iOS, BuildOptions.None);
    }

    public static void IosMono()
    {
        var buildpath = ValidateBuildPath(@"iOSMono");
        PlayerSettings.SetPropertyInt("ScriptingBackend", (int)ScriptingImplementation.Mono2x, BuildTarget.iOS);
        PlayerSettings.SetPropertyInt("Architecture", 0, BuildTarget.iOS);//corresponds to iphone architecture armv7
        BuildPipeline.BuildPlayer(new string[] { @"Assets\TestDriver.unity" }, buildpath, BuildTarget.iOS, BuildOptions.None);
    }

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


}
