﻿using Microsoft.Vbe.Interop;
using System.Collections.Generic;
using System.Linq;

namespace G1ANT.Addon.Access.Models.Access.VBE
{
    internal class VbeProjectCollectionModel : List<VbeProjectModel>
    {
        public VbeProjectCollectionModel(VBProjects projects)
        {
            AddRange(projects.Cast<VBProject>().Select(p => new VbeProjectModel(p)));
        }

        public override string ToString() => "Projects";
    }
}
