using UnityEngine;
using System.Collections;

namespace ProceduralSceneGenerator
{
    public class TilingPlane : MonoBehaviour
    {
        public float scaleToTiles;
        public Dir dir;
        private Material mat;

        void LateUpdate()
        {
            float scaleX = 1;
            float scaleY = 1;

            switch (dir)
            {
                case Dir.XY:
                    scaleX = transform.lossyScale.x;
                    scaleY = transform.lossyScale.y;
                    break;
                case Dir.ZY:
                    scaleX = transform.lossyScale.z;
                    scaleY = transform.lossyScale.y;
                    break;
                case Dir.XZ:
                    scaleX = transform.lossyScale.x;
                    scaleY = transform.lossyScale.z;
                    break;
            }
            // if (!Application.isEditor || Application.isPlaying)
            if (Application.isPlaying)
            {
                mat = GetComponent<Renderer>().material;
                mat.SetTextureScale("_MainTex",
                    new Vector2(scaleX * scaleToTiles, scaleY * scaleToTiles));               
            }
        }
    }
}

public enum Dir { XY, ZY, XZ }