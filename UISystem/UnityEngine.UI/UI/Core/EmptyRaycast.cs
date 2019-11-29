using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/EmptyRayCast", 10)]
    public class EmptyRaycast:MaskableGraphic
    {
        protected EmptyRaycast()
        {
            useLegacyMeshGeneration = false;
        }

        protected override void OnPopulateMesh(VertexHelper toFill)
        {
            toFill.Clear();
        }
    }
}
