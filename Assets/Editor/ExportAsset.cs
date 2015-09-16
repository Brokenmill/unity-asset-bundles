using UnityEngine;
using UnityEditor;
using System.Collections;

public class ExportAsset : MonoBehaviour {

	[MenuItem ("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles ()
	{
		BuildPipeline.BuildAssetBundles ("AssetBundles");
	}

}
