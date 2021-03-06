﻿/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.Access
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/


namespace G1ANT.Addon.Access.Models.Access
{
    internal class AccessDynamicPropertyModel : INameModel
    {
        public string Name { get; }
        public string Value { get; }

        public AccessDynamicPropertyModel(dynamic property)
        {
            try
            {
                Name = property.Name;
                Value = property.Value?.ToString();
            }
            catch { }
        }

        public override string ToString() => $"{Name}: {Value}";
    }
}
