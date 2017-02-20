using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using BabylonExport.Entities;

namespace Assets.Unity3D2Babylon.Entities
{
    class BabylonExtendedAnimation : BabylonAnimation
    {
        /// <summary>
        /// The unity path for a mesh
        /// </summary>
        [DataMember]
        public string meshpath { get; set; }
    }
}
