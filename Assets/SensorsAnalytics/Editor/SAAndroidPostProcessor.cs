using System.IO;
using UnityEditor.Android;

public class SAAndroidPostProcessor : IPostGenerateGradleAndroidProject
{
    public int callbackOrder
    {
        get
        {
            return 1;
        }
    }

    public void OnPostGenerateGradleAndroidProject(string path)
    {
        //string appBuildGradleFile = path + "/app/build.gradle";
        //if (File.Exists(appBuildGradleFile))
        //{
        //    string appBuildGradle = File.ReadAllText(appBuildGradleFile);
        //    appBuildGradle = appBuildGradle.Replace("minSdkVersion 15", "minSdkVersion 19");
        //    File.WriteAllText(appBuildGradleFile, appBuildGradle);
        //}
    }
}
