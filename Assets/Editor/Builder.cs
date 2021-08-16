using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Builder
{
    [MenuItem("Build/Mac")]
    public static void BuildMac() {

        // necesitamos escenas
        EditorBuildSettingsScene[] levels = EditorBuildSettings.scenes;

        // ordenar construccion
        BuildPipeline.BuildPlayer(levels, "./Build/MacOS.app", BuildTarget.StandaloneOSX, BuildOptions.None);
    }
}
