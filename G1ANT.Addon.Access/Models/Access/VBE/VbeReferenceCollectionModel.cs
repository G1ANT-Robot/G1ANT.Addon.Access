﻿using Microsoft.Vbe.Interop;
using System.Collections.Generic;
using System.Linq;

namespace G1ANT.Addon.Access.Models.Access.VBE
{
    internal class VbeReferenceCollectionModel : List<VbeReferenceModel>
    {
        public VbeReferenceCollectionModel(References references)
        {
            AddRange(references.Cast<Reference>().Select(r => new VbeReferenceModel(r)));
        }

        public override string ToString() => "References";
    }
}
