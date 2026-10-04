using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class WristOcclusion : MonoBehaviour
{
    void Start()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        
        // Créer le matériau d'occlusion
        Material occlusionMat = new Material(Shader.Find("Custom/DepthMaskFixed"));
        
        if (occlusionMat.shader == null || 
            occlusionMat.shader.name == "Hidden/InternalErrorShader")
        {
            // Fallback si shader introuvable
            occlusionMat = new Material(Shader.Find("Standard"));
            occlusionMat.color = new Color(0, 0, 0, 0);
        }
        
        mr.material = occlusionMat;
        mr.shadowCastingMode = 
            UnityEngine.Rendering.ShadowCastingMode.Off;
        mr.receiveShadows = false;
    }
}