using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Assets.Unity3D2Babylon.Entities
{
    class BabylonExtendedStandardMaterial : BabylonExport.Entities.BabylonStandardMaterial 
    {
        [DataMember]
        public bool useAlphaFromDiffuseTexture { get; set; }
    }
}
