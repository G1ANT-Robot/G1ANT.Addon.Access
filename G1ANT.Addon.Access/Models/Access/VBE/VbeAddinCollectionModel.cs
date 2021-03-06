﻿using Microsoft.Vbe.Interop;
using System.Collections.Generic;
using System.Linq;

namespace G1ANT.Addon.Access.Models.Access.VBE
{
    internal class VbeAddinCollectionModel : List<VbeAddinModel>
    {
        public VbeAddinCollectionModel(Addins addins)
        {
            AddRange(addins.Cast<AddIn>().Select(a => new VbeAddinModel(a)));
        }

        public override string ToString() => "Addins";
    }
}
